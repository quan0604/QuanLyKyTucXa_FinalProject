
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmHoaDon : Form
    {
        private HoaDonService _service = new HoaDonService();
        private NhanVienService _nhanVienService = new NhanVienService();
        private PhongService _phongService = new PhongService();
        private bool _isAdding = false;

        public FrmHoaDon()
        {
            InitializeComponent();
            this.Load += FrmHoaDon_Load;

            // Event Binding
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += BtnThoat_Click;
            dgvHoaDon.CellClick += DgvHoaDon_CellClick;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        private void LoadComboBoxes()
        {
            try
            {
                var listNV = _nhanVienService.GetAll();
                cmbNhanVien.DataSource = listNV;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";

                var listPhong = _phongService.GetAll();
                cmbPhong.DataSource = listPhong;
                cmbPhong.DisplayMember = "MaPhong"; // Phong has MaPhong and TenPhong? Check Entity. Phong entity has MaPhong, Khu...
                cmbPhong.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                var list = _service.GetAll();
                BindGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<HOADON> list)
        {
            dgvHoaDon.DataSource = list.Select(h => new
            {
                h.MaHD,
                // Format NgayHD only if not null
                NgayHD = h.NgayHD.HasValue ? h.NgayHD.Value.ToString("dd/MM/yyyy") : "",
                h.MaNV,
                TenNV = h.NHANVIEN != null ? h.NHANVIEN.HoTen : "",
                h.MaPhong,
                // Calculate Total
                TongTien = _service.TinhTongTien(h.MaHD)
            }).ToList();

            dgvHoaDon.Columns["MaHD"].HeaderText = "Mã HĐ";
            dgvHoaDon.Columns["NgayHD"].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns["MaNV"].HeaderText = "Mã NV";
            dgvHoaDon.Columns["TenNV"].HeaderText = "Tên NV";
            dgvHoaDon.Columns["MaPhong"].HeaderText = "Phòng";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private void SetButtonState(bool isEditing)
        {
            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            btnThoat.Enabled = isEditing;
            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;
        }

        private void SetInputState(bool enable)
        {
            txtMaHD.Enabled = enable;
            dtpNgayHD.Enabled = enable;
            cmbNhanVien.Enabled = enable;
            cmbPhong.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaHD.Clear();
            dtpNgayHD.Value = DateTime.Now;
            if (cmbNhanVien.Items.Count > 0) cmbNhanVien.SelectedIndex = 0;
            if (cmbPhong.Items.Count > 0) cmbPhong.SelectedIndex = 0;
        }

        private void DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                
                // Parse Date safely
                if (DateTime.TryParseExact(row.Cells["NgayHD"].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    dtpNgayHD.Value = date;
                }

                if (row.Cells["MaNV"].Value != null)
                    cmbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();

                if (row.Cells["MaPhong"].Value != null)
                    cmbPhong.SelectedValue = row.Cells["MaPhong"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaHD.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaHD.Enabled = false; // Primary key cannot be changed
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn {txtMaHD.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (_service.Delete(txtMaHD.Text))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbNhanVien.SelectedValue == null || cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên và Phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HOADON hd = new HOADON
            {
                MaHD = txtMaHD.Text.Trim(),
                NgayHD = dtpNgayHD.Value,
                MaNV = cmbNhanVien.SelectedValue.ToString(),
                MaPhong = cmbPhong.SelectedValue.ToString()
            };

            try
            {
                bool result;
                if (_isAdding)
                {
                    result = _service.Insert(hd);
                    if (!result) MessageBox.Show("Mã hóa đơn đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = _service.Update(hd);
                }

                if (result)
                {
                    MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    SetButtonState(true);
                    SetInputState(false);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            SetButtonState(true);
            SetInputState(false);
            ClearInputs();
            dgvHoaDon.ClearSelection();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var list = _service.GetAll().Where(h =>
                h.MaHD.ToLower().Contains(keyword) ||
                (h.NHANVIEN != null && h.NHANVIEN.HoTen.ToLower().Contains(keyword)) ||
                h.MaPhong.ToLower().Contains(keyword)
            ).ToList();

            BindGrid(list);
        }
    }
}
