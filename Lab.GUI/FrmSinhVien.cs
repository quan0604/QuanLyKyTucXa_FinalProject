
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab.BUS;
using Lab.DAL.Entities;

namespace Lab.GUI
{
    public partial class FrmSinhVien : Form
    {
        private readonly SinhVienService _studentService = new SinhVienService();
        private readonly LopService _classService = new LopService();
        private bool _isAdding = false;
        private List<SINHVIEN> _originalList = new List<SINHVIEN>(); // Cache

        public FrmSinhVien()
        {
            InitializeComponent();
            
            // Wire Events
            this.Load += FrmSinhVien_Load;
            this.btnThem.Click += btnThem_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnLuu.Click += btnLuu_Click;
            this.btnHuy.Click += btnHuy_Click;
            this.btnThoat.Click += btnThoat_Click;
            this.dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            this.txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            LoadComboboxLop();
            LoadData();
            ResetControlState();
        }

        // ================= LOADING DATA =================
        private void LoadComboboxLop()
        {
            cmbLop.DataSource = _classService.GetAll();
            cmbLop.DisplayMember = "MaLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void LoadData()
        {
            try
            {
                _originalList = _studentService.GetAll();
                BindGrid(_originalList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void BindGrid(List<SINHVIEN> list)
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = list;
            
            // Format columns if needed
            if (dgvSinhVien.Columns["LOP"] != null) dgvSinhVien.Columns["LOP"].Visible = false;
            if (dgvSinhVien.Columns["NGUOITHAN"] != null) dgvSinhVien.Columns["NGUOITHAN"].Visible = false;
            if (dgvSinhVien.Columns["PHIEUDK"] != null) dgvSinhVien.Columns["PHIEUDK"].Visible = false;
            if (dgvSinhVien.Columns["AnhChanDung"] != null) dgvSinhVien.Columns["AnhChanDung"].Visible = false;
        }

        // ================= UI STATE MANAGEMENT =================
        private void ResetControlState()
        {
            grpThongTin.Enabled = false;
            
            btnThem.Enabled = true;
            btnSua.Enabled = true; // Enabled but needs selection, handled in logic or simplified
            btnXoa.Enabled = true;
            
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            
            ClearInputs();
        }

        private void EnableEditMode(bool adding)
        {
            _isAdding = adding;
            grpThongTin.Enabled = true;
            
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            if (adding)
            {
                ClearInputs();
                txtMSSV.Focus();
            }
            else
            {
                txtMSSV.Enabled = false; // Cannot change ID when editing
                txtHoTen.Focus();
            }
        }

        private void ClearInputs()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            cmbLop.SelectedIndex = -1;
            cmbPhai.SelectedIndex = -1;
            dtpNgSinh.Value = DateTime.Now;
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtQueQuan.Text = "";
            txtDienSV.Text = "";
            txtBHYT.Text = "";
            txtAnhChanDung.Text = "";
            txtMSSV.Enabled = true;
        }

        // ================= EVENTS =================
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled) // Only fill if not in edit mode
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["MSSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                cmbLop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
                cmbPhai.Text = row.Cells["Phai"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["NgSinh"].Value?.ToString(), out DateTime date))
                    dtpNgSinh.Value = date;
                txtCMND.Text = row.Cells["CMND"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString();
                txtDienSV.Text = row.Cells["DienSV"].Value?.ToString();
                txtBHYT.Text = row.Cells["BHYT"].Value?.ToString();
                // Image handling if needed
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableEditMode(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }
            EnableEditMode(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_studentService.Delete(txtMSSV.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ResetControlState();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SINHVIEN sv = new SINHVIEN
                {
                    MSSV = txtMSSV.Text,
                    HoTen = txtHoTen.Text,
                    MaLop = cmbLop.SelectedValue?.ToString(),
                    Phai = cmbPhai.Text,
                    NgSinh = dtpNgSinh.Value,
                    CMND = txtCMND.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    QueQuan = txtQueQuan.Text,
                    DienSV = txtDienSV.Text,
                    BHYT = txtBHYT.Text,
                    AnhChanDung = null // Simplify for now
                };

                bool result;
                if (_isAdding)
                {
                    result = _studentService.Insert(sv);
                }
                else
                {
                    result = _studentService.Update(sv);
                }

                if (result)
                {
                    MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!");
                    LoadData();
                    ResetControlState();
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControlState();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (_originalList == null) return;
            string keyword = txtTimKiem.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_originalList);
                return;
            }
            var list = _originalList.FindAll(s => 
                (s.MSSV != null && s.MSSV.ToLower().Contains(keyword)) || 
                (s.HoTen != null && s.HoTen.ToLower().Contains(keyword)));
            BindGrid(list);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Họ tên!");
                return false;
            }
            if (cmbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Lớp!");
                return false;
            }
            return true;
        }
    }
}
