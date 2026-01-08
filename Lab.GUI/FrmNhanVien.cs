using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab.BUS;
using Lab.DAL.Entities;

namespace Lab.GUI
{
    public partial class FrmNhanVien : Form
    {
        private readonly NhanVienService _nhanVienService = new NhanVienService();
        private bool _isAdding = false;
        private List<NHANVIEN> _originalList = new List<NHANVIEN>(); // Cache

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboboxNguoiQuanLy();
            LoadData();
            ResetControlState();
        }

        // ================= LOADING DATA =================
        private void LoadComboboxNguoiQuanLy()
        {
            try
            {
                var managers = _nhanVienService.GetAll();
                cmbNguoiQuanLy.DataSource = managers;
                cmbNguoiQuanLy.DisplayMember = "HoTen";
                cmbNguoiQuanLy.ValueMember = "MaNV";
                cmbNguoiQuanLy.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quản lý: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                _originalList = _nhanVienService.GetAll(); // Cache data
                BindGrid(_originalList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void BindGrid(List<NHANVIEN> list)
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = list;

            // Hide navigation properties
            if (dgvNhanVien.Columns["DANGNHAP"] != null) dgvNhanVien.Columns["DANGNHAP"].Visible = false;
            if (dgvNhanVien.Columns["HOADON"] != null) dgvNhanVien.Columns["HOADON"].Visible = false;
            if (dgvNhanVien.Columns["NHANVIEN1"] != null) dgvNhanVien.Columns["NHANVIEN1"].Visible = false;
            if (dgvNhanVien.Columns["NHANVIEN2"] != null) dgvNhanVien.Columns["NHANVIEN2"].Visible = false;
            if (dgvNhanVien.Columns["PHIEUDK"] != null) dgvNhanVien.Columns["PHIEUDK"].Visible = false;
            if (dgvNhanVien.Columns["AnhChanDung"] != null) dgvNhanVien.Columns["AnhChanDung"].Visible = false;
            
            // Set header text to Vietnamese if desired
            if (dgvNhanVien.Columns["MaNV"] != null) dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
            if (dgvNhanVien.Columns["HoTen"] != null) dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dgvNhanVien.Columns["DiaChi"] != null) dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            if (dgvNhanVien.Columns["Luong"] != null) dgvNhanVien.Columns["Luong"].HeaderText = "Lương";
            if (dgvNhanVien.Columns["MaNQL"] != null) dgvNhanVien.Columns["MaNQL"].HeaderText = "Mã QL";
        }

        // ================= UI STATE MANAGEMENT =================
        private void ResetControlState()
        {
            grpThongTin.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
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
                txtMaNV.Focus();
            }
            else
            {
                txtMaNV.Enabled = false;
                txtHoTen.Focus();
            }
        }

        private void ClearInputs()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            cmbNguoiQuanLy.SelectedIndex = -1;
            txtMaNV.Enabled = true;
        }

        // ================= EVENTS =================
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtCMND.Text = row.Cells["CMND"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtLuong.Text = row.Cells["Luong"].Value?.ToString();
                if (dgvNhanVien.Columns.Contains("MaNQL") && row.Cells["MaNQL"].Value != null)
                {
                    cmbNguoiQuanLy.SelectedValue = row.Cells["MaNQL"].Value;
                }
                else
                {
                    cmbNguoiQuanLy.SelectedIndex = -1;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableEditMode(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }
            EnableEditMode(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (_nhanVienService.Delete(txtMaNV.Text))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        LoadComboboxNguoiQuanLy();
                        ResetControlState();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                NHANVIEN nv = new NHANVIEN
                {
                    MaNV = txtMaNV.Text,
                    HoTen = txtHoTen.Text,
                    CMND = txtCMND.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    DiaChi = txtDiaChi.Text,
                    Luong = string.IsNullOrWhiteSpace(txtLuong.Text) ? (decimal?)null : decimal.Parse(txtLuong.Text),
                    MaNQL = cmbNguoiQuanLy.SelectedValue?.ToString()
                };

                try
                {
                    bool result;
                    if (_isAdding)
                    {
                        result = _nhanVienService.Insert(nv);
                    }
                    else
                    {
                        result = _nhanVienService.Update(nv);
                    }

                    if (result)
                    {
                        MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!");
                        LoadData();
                        LoadComboboxNguoiQuanLy();
                        ResetControlState();
                    }
                    else
                    {
                        MessageBox.Show("Thao tác thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
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

            var filteredList = _originalList.Where(nv =>
                (nv.MaNV != null && nv.MaNV.ToLower().Contains(keyword)) ||
                (nv.HoTen != null && nv.HoTen.ToLower().Contains(keyword)) ||
                (nv.Email != null && nv.Email.ToLower().Contains(keyword))
            ).ToList();
            
            BindGrid(filteredList);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV và Họ tên!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                if (!decimal.TryParse(txtLuong.Text, out decimal luong))
                {
                    MessageBox.Show("Lương phải là số!");
                    return false;
                }
            }

            return true;
        }
    }
}
