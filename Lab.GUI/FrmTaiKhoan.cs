
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmTaiKhoan : Form
    {
        private readonly DangNhapService _service = new DangNhapService();
        private readonly NhanVienService _nvService = new NhanVienService();
        private bool _isAdding = false;

        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        private void LoadNhanVien()
        {
            try
            {
                var list = _nvService.GetAll(); // Assuming GetAll() exists in NhanVienService
                cmbNhanVien.DataSource = list;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhân viên: " + ex.Message);
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
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message);
            }
        }

        private void BindGrid(List<DANGNHAP> list)
        {
            dgvTaiKhoan.DataSource = null;
            // Project to anonymous to hide Password and show Staff Name
            var displayList = list.Select(x => new 
            {
                x.TenDN,
                MatKhau = "******", // Hide password
                x.MaNV,
                TenNhanVien = x.NHANVIEN != null ? x.NHANVIEN.HoTen : "N/A"
            }).ToList();

            dgvTaiKhoan.DataSource = displayList;

            // Headers
            if (dgvTaiKhoan.Columns["TenDN"] != null) dgvTaiKhoan.Columns["TenDN"].HeaderText = "Tên Đăng Nhập";
            if (dgvTaiKhoan.Columns["MatKhau"] != null) dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            if (dgvTaiKhoan.Columns["MaNV"] != null) dgvTaiKhoan.Columns["MaNV"].HeaderText = "Mã NV";
            if (dgvTaiKhoan.Columns["TenNhanVien"] != null) dgvTaiKhoan.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
        }

        // ================= UI STATE =================
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
            txtTenDN.Enabled = enable;
            txtMatKhau.Enabled = enable;
            cmbNhanVien.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
            if (cmbNhanVien.Items.Count > 0) cmbNhanVien.SelectedIndex = 0;
        }

        // ================= EVENTS =================
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenDN.Text = row.Cells["TenDN"].Value?.ToString();
                txtMatKhau.Text = ""; // Don't show password
                
                string maNV = row.Cells["MaNV"].Value?.ToString();
                if (maNV != null) cmbNhanVien.SelectedValue = maNV;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtTenDN.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần đổi mật khẩu!");
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtTenDN.Enabled = false; // PK
            cmbNhanVien.Enabled = false; // Changing owner usually not allowed, create new instead
            
            txtMatKhau.Focus();
            MessageBox.Show("Nhập mật khẩu mới và nhấn Lưu.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {txtTenDN.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.XoaTaiKhoan(txtTenDN.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string tenDN = txtTenDN.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim(); // In real app, hash this!
            string maNV = cmbNhanVien.SelectedValue?.ToString();

            bool result;
            if (_isAdding)
            {
                result = _service.ThemTaiKhoan(tenDN, matKhau, maNV);
            }
            else
            {
                // Logic for Admin Reset Password
                result = _service.UpdatePasswordAdmin(tenDN, matKhau);
            }

            if (result)
            {
                MessageBox.Show(_isAdding ? "Thêm thành công!" : "Cập nhật mật khẩu thành công!");
                LoadData();
                SetButtonState(true);
                SetInputState(false);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại! (Có thể tên đăng nhập đã tồn tại)");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButtonState(true);
            SetInputState(false);
            ClearInputs();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
