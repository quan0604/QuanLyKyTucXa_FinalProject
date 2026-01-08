using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab.BUS;

namespace Lab.GUI
{
    public partial class FrmDiemDanh : Form
    {
        private readonly DiemDanhService _attendanceService = new DiemDanhService();
        private readonly PhongService _roomService = new PhongService();
        private string _currentSessionCode = ""; // Store current code
        private int _timeLeft = 0; // Timer logic

        public FrmDiemDanh()
        {
            InitializeComponent();
            
            // Wire Events
            this.Load += FrmDiemDanh_Load;
            this.btnXem.Click += btnXem_Click;
            this.btnLuu.Click += btnLuu_Click;
            this.btnThoat.Click += btnThoat_Click;
            
            // QR Events
            this.btnTaoMa.Click += btnTaoMa_Click;
            this.txtInputMSSV.KeyDown += txtInputMSSV_KeyDown;
            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            this.timerSession.Tick += TimerSession_Tick;
        }

        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {
            LoadComboboxPhong();
            dtpNgay.Value = DateTime.Now;
        }

        private void LoadComboboxPhong()
        {
            try 
            {
                cmbPhong.DataSource = _roomService.GetAll();
                cmbPhong.DisplayMember = "TenPhong";
                cmbPhong.ValueMember = "MaPhong";
            }
            catch
            {
                // Fallback if Service fail
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng!");
                return;
            }

            string maPhong = cmbPhong.SelectedValue.ToString();
            DateTime date = dtpNgay.Value.Date;

            LoadData(date, maPhong);
        }

        private void LoadData(DateTime date, string maPhong)
        {
            try
            {
                var list = _attendanceService.GetAttendanceList(date, maPhong);
                dgvDiemDanh.DataSource = null;
                dgvDiemDanh.DataSource = list;
                
                // Format Columns
                if (dgvDiemDanh.Columns["MaDiemDanh"] != null) dgvDiemDanh.Columns["MaDiemDanh"].Visible = false;
                if (dgvDiemDanh.Columns["MSSV"] != null) 
                {
                    dgvDiemDanh.Columns["MSSV"].HeaderText = "MSSV";
                    dgvDiemDanh.Columns["MSSV"].ReadOnly = true;
                }
                if (dgvDiemDanh.Columns["HoTen"] != null)
                {
                    dgvDiemDanh.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvDiemDanh.Columns["HoTen"].ReadOnly = true;
                    dgvDiemDanh.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (dgvDiemDanh.Columns["MaPhong"] != null) dgvDiemDanh.Columns["MaPhong"].Visible = false;
                
                if (dgvDiemDanh.Columns["CoMat"] != null)
                {
                    dgvDiemDanh.Columns["CoMat"].HeaderText = "Có Mặt";
                    dgvDiemDanh.Columns["CoMat"].Width = 80;
                }
                
                if (dgvDiemDanh.Columns["GhiChu"] != null)
                {
                    dgvDiemDanh.Columns["GhiChu"].HeaderText = "Ghi Chú";
                    dgvDiemDanh.Columns["GhiChu"].Width = 200;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvDiemDanh.DataSource == null) return;
            
            try
            {
                var list = (List<DiemDanhService.AttendanceDTO>)dgvDiemDanh.DataSource;
                _attendanceService.SaveAttendance(list, dtpNgay.Value.Date);
                MessageBox.Show("Lưu điểm danh thành công!");
                
                // Reload
                if (cmbPhong.SelectedValue != null)
                    LoadData(dtpNgay.Value.Date, cmbPhong.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================================
        // KHU VỰC XỬ LÝ QUÉT MÃ / TẠO QR
        // ==========================================

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If switching back to List Tab, reload data to show results from QR Tab
            if (tabControl.SelectedTab == tabDanhSach)
            {
                if (cmbPhong.SelectedValue != null)
                {
                    LoadData(dtpNgay.Value.Date, cmbPhong.SelectedValue.ToString());
                }
            }
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng cần điểm danh trước!");
                return;
            }

            // Generate Random Code (4 digits)
            Random rnd = new Random();
            _currentSessionCode = rnd.Next(1000, 9999).ToString();
            
            lblQRCode.Text = "MÃ SỐ: " + _currentSessionCode;
            lblQRCode.ForeColor = Color.Navy;
            
            // Clear Log
            lstLog.Items.Clear();
            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đã tạo phiên cho phòng {cmbPhong.SelectedValue}");
            lstLog.Items.Add("-------------------------------");
            
            // Start Timer (60s)
            _timeLeft = 60;
            lblTimer.Text = $"Thời gian còn lại: {_timeLeft}s";
            timerSession.Interval = 1000;
            timerSession.Start();
            txtInputMSSV.Enabled = true;

            txtInputMSSV.Text = "";
            txtInputMSSV.Focus();
        }

        private void TimerSession_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                lblTimer.Text = $"Thời gian còn lại: {_timeLeft}s";
                
                if (_timeLeft <= 10) lblTimer.ForeColor = Color.Red;
                else lblTimer.ForeColor = Color.Black;
            }
            else
            {
                timerSession.Stop();
                _currentSessionCode = ""; // Invalidate
                lblTimer.Text = "Hết hạn! Vui lòng tạo mã mới.";
                lblQRCode.Text = "HẾT HẠN";
                lblQRCode.ForeColor = Color.Red;
                txtInputMSSV.Enabled = false; // Initial lock
            }
        }

        private void txtInputMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // No ding
                
                string mssv = txtInputMSSV.Text.Trim();
                if (string.IsNullOrEmpty(mssv)) return;

                if (string.IsNullOrEmpty(_currentSessionCode))
                {
                    MessageBox.Show("Vui lòng bấm 'Tạo Phiên Điểm Danh' trước!");
                    return;
                }

                // Call Logic
                if (cmbPhong.SelectedValue == null) return;
                string maPhong = cmbPhong.SelectedValue.ToString();
                DateTime date = dtpNgay.Value.Date;

                try
                {
                    var result = _attendanceService.CheckInSingle(mssv, maPhong, date);
                    
                    if (result.Success)
                    {
                        // Success Log
                        string logMsg = $"[{DateTime.Now:HH:mm:ss}] ✅ {result.StudentName} ({mssv}) - {result.Message}";
                        lstLog.Items.Insert(0, logMsg); // Add to top
                    }
                    else
                    {
                        // Error Log
                        string logMsg = $"[{DateTime.Now:HH:mm:ss}] ❌ {mssv} - {result.Message}";
                        lstLog.Items.Insert(0, logMsg);
                    }
                }
                catch (Exception ex)
                {
                    lstLog.Items.Insert(0, $"Error: {ex.Message}");
                }

                // Reset Textbox for next scan
                txtInputMSSV.Text = "";
                txtInputMSSV.Focus();
            }
        }
    }
}
