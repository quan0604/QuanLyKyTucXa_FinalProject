
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmNguoiThan : Form
    {
        private readonly NguoiThanService _service = new NguoiThanService();
        private readonly SinhVienService _svService = new SinhVienService();
        private bool _isAdding = false;

        public FrmNguoiThan()
        {
            InitializeComponent();
        }

        private void FrmNguoiThan_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        private void LoadSinhVien()
        {
            try
            {
                var listSV = _svService.GetAll();
                cmbSinhVien.DataSource = listSV;
                cmbSinhVien.DisplayMember = "HoTen"; // Assuming SINHVIEN has HoTen. Or use MSSV? Displaying "MSSV - Name" is best.
                // Let's check SINHVIEN entity later. For now assume HoTen exists or just use MSSV if not sure.
                // Actually SINHVIEN usually has HoTen. I will use a formatted string if possible, but DisplayMember takes property name.
                // Let's stick to "MSSV" for now to be safe, or just "HoTen" if I am sure. 
                // Previous FrmSinhVien used default binding.
                // I will use MSSV as ValueMember.
                cmbSinhVien.ValueMember = "MSSV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sinh viên: " + ex.Message);
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
                MessageBox.Show("Lỗi tải danh sách người thân: " + ex.Message);
            }
        }

        private void BindGrid(List<NGUOITHAN> list)
        {
            dgvNguoiThan.DataSource = null;
            // Map to anonymous type to show Student Name if possible, or just raw list
            dgvNguoiThan.DataSource = list;

            if (dgvNguoiThan.Columns["SINHVIEN"] != null) dgvNguoiThan.Columns["SINHVIEN"].Visible = false;

            // Headers
            if (dgvNguoiThan.Columns["MSSV"] != null) dgvNguoiThan.Columns["MSSV"].HeaderText = "MSSV";
            if (dgvNguoiThan.Columns["SDT"] != null) dgvNguoiThan.Columns["SDT"].HeaderText = "Số Điện Thoại";
            if (dgvNguoiThan.Columns["HoTen"] != null) dgvNguoiThan.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dgvNguoiThan.Columns["Email"] != null) dgvNguoiThan.Columns["Email"].HeaderText = "Email";
            if (dgvNguoiThan.Columns["DiaChi"] != null) dgvNguoiThan.Columns["DiaChi"].HeaderText = "Địa Chỉ";
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
            cmbSinhVien.Enabled = enable;
            txtSDT.Enabled = enable;
            txtHoTen.Enabled = enable;
            txtEmail.Enabled = enable;
            txtDiaChi.Enabled = enable;
        }

        private void ClearInputs()
        {
            if (cmbSinhVien.Items.Count > 0) cmbSinhVien.SelectedIndex = 0;
            txtSDT.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
        }

        // ================= EVENTS =================
        private void dgvNguoiThan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvNguoiThan.Rows[e.RowIndex];
                
                string mssv = row.Cells["MSSV"].Value?.ToString();
                if (mssv != null) cmbSinhVien.SelectedValue = mssv;

                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            cmbSinhVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng chọn người thân cần sửa!");
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            
            // Lock PKs
            cmbSinhVien.Enabled = false;
            txtSDT.Enabled = false;

            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text) || cmbSinhVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người thân cần xóa!");
                return;
            }

            string mssv = cmbSinhVien.SelectedValue.ToString();
            string sdt = txtSDT.Text;

            if (MessageBox.Show($"Bạn có chắc muốn xóa người thân {txtHoTen.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(mssv, sdt))
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
            if (cmbSinhVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Sinh viên và Số điện thoại!");
                return;
            }

            NGUOITHAN nt = new NGUOITHAN
            {
                MSSV = cmbSinhVien.SelectedValue.ToString(),
                SDT = txtSDT.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            bool result;
            if (_isAdding)
            {
                // Verify Exists
                if (_service.GetById(nt.MSSV, nt.SDT) != null)
                {
                     MessageBox.Show("Người thân này đã tồn tại (trùng SĐT và SV)!");
                     return;
                }
                result = _service.Insert(nt);
            }
            else
            {
                result = _service.Update(nt);
            }

            if (result)
            {
                MessageBox.Show(_isAdding ? "Thêm thành công!" : "Cập nhật thành công!");
                LoadData();
                SetButtonState(true);
                SetInputState(false);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButtonState(true);
            SetInputState(false);
            ClearInputs();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
             // Implement logic simple: Filter local list or call Service
             // Local filter for speed
             string keyword = txtTimKiem.Text.ToLower();
             if (string.IsNullOrWhiteSpace(keyword))
             {
                 LoadData();
                 return;
             }
             var list = _service.GetAll().Where(x => 
                 x.MSSV.ToLower().Contains(keyword) || 
                 x.SDT.ToLower().Contains(keyword) || 
                 (x.HoTen != null && x.HoTen.ToLower().Contains(keyword))
             ).ToList();
             BindGrid(list);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
