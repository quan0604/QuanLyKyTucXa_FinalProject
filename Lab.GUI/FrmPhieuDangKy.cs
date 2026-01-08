
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmPhieuDangKy : Form
    {
        private readonly PhieuDKService _service = new PhieuDKService();
        private readonly SinhVienService _svService = new SinhVienService();
        private readonly PhongService _phongService = new PhongService();
        private readonly NhanVienService _nvService = new NhanVienService();

        private bool _isAdding = false;

        public FrmPhieuDangKy()
        {
            InitializeComponent();
        }

        private void FrmPhieuDangKy_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
            SetButtonState(true);
            SetInputState(false);
            
            // Default Year
            txtNamHoc.Text = DateTime.Now.Year.ToString() + "-" + (DateTime.Now.Year + 1).ToString();
        }

        // ================= LOADING DATA =================
        private void LoadComboboxes()
        {
            try
            {
                // Sinh Vien
                var listSV = _svService.GetAll();
                cmbSinhVien.DataSource = listSV;
                cmbSinhVien.DisplayMember = "HoTen";
                cmbSinhVien.ValueMember = "MSSV";
                
                // Phong
                var listPhong = _phongService.GetAll();
                cmbPhong.DataSource = listPhong;
                cmbPhong.DisplayMember = "MaPhong"; // Or name if available
                cmbPhong.ValueMember = "MaPhong";

                // Nhan Vien
                var listNV = _nvService.GetAll();
                cmbNhanVien.DataSource = listNV;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu combobox: " + ex.Message);
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
                MessageBox.Show("Lỗi tải danh sách phiếu: " + ex.Message);
            }
        }

        private void BindGrid(List<PHIEUDK> list)
        {
            dgvPhieuDK.DataSource = null;
            dgvPhieuDK.DataSource = list;

            // Hide navigation properties
            if (dgvPhieuDK.Columns["SINHVIEN"] != null) dgvPhieuDK.Columns["SINHVIEN"].Visible = false;
            if (dgvPhieuDK.Columns["PHONG"] != null) dgvPhieuDK.Columns["PHONG"].Visible = false;
            if (dgvPhieuDK.Columns["NHANVIEN"] != null) dgvPhieuDK.Columns["NHANVIEN"].Visible = false;

            // Headers
            if (dgvPhieuDK.Columns["MaPDK"] != null) dgvPhieuDK.Columns["MaPDK"].HeaderText = "Mã Phiếu";
            if (dgvPhieuDK.Columns["MSSV"] != null) dgvPhieuDK.Columns["MSSV"].HeaderText = "MSSV";
            if (dgvPhieuDK.Columns["MaPhong"] != null) dgvPhieuDK.Columns["MaPhong"].HeaderText = "Mã Phòng";
            if (dgvPhieuDK.Columns["NgayDK"] != null) dgvPhieuDK.Columns["NgayDK"].HeaderText = "Ngày ĐK"; // Entitiy might be NgayGioDK
            if (dgvPhieuDK.Columns["NgayGioDK"] != null) dgvPhieuDK.Columns["NgayGioDK"].HeaderText = "Ngày ĐK";
            if (dgvPhieuDK.Columns["HocKy"] != null) dgvPhieuDK.Columns["HocKy"].HeaderText = "Học Kỳ";
            if (dgvPhieuDK.Columns["NamHoc"] != null) dgvPhieuDK.Columns["NamHoc"].HeaderText = "Năm Học";
            if (dgvPhieuDK.Columns["ThoiHan"] != null) dgvPhieuDK.Columns["ThoiHan"].HeaderText = "Thời Hạn (Tháng)";
            if (dgvPhieuDK.Columns["NgayBD"] != null) dgvPhieuDK.Columns["NgayBD"].HeaderText = "Ngày BĐ";
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
            txtMaPDK.Enabled = enable;
            cmbSinhVien.Enabled = enable;
            cmbPhong.Enabled = enable;
            cmbNhanVien.Enabled = enable;
            numHocKy.Enabled = enable;
            txtNamHoc.Enabled = enable;
            dtpNgayDK.Enabled = enable;
            numThoiHan.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaPDK.Clear();
            if(cmbSinhVien.Items.Count > 0) cmbSinhVien.SelectedIndex = 0;
            if(cmbPhong.Items.Count > 0) cmbPhong.SelectedIndex = 0;
            if(cmbNhanVien.Items.Count > 0) cmbNhanVien.SelectedIndex = 0;
            numHocKy.Value = 1;
            txtNamHoc.Text = DateTime.Now.Year.ToString();
            dtpNgayDK.Value = DateTime.Now;
            numThoiHan.Value = 5;
            txtMaPDK.Enabled = true;
        }

        // ================= EVENTS =================
        private void dgvPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvPhieuDK.Rows[e.RowIndex];
                txtMaPDK.Text = row.Cells["MaPDK"].Value?.ToString();
                
                if (row.Cells["MSSV"].Value != null)
                    cmbSinhVien.SelectedValue = row.Cells["MSSV"].Value.ToString();
                
                if (row.Cells["MaPhong"].Value != null)
                    cmbPhong.SelectedValue = row.Cells["MaPhong"].Value.ToString();

                if (row.Cells["MaNV"].Value != null)
                    cmbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();

                if (row.Cells["HocKy"].Value != null && int.TryParse(row.Cells["HocKy"].Value.ToString(), out int hk))
                    numHocKy.Value = hk;

                txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();

                if (row.Cells["NgayGioDK"].Value != null)
                    dtpNgayDK.Value = (DateTime)row.Cells["NgayGioDK"].Value;
                
                if (row.Cells["ThoiHan"].Value != null && int.TryParse(row.Cells["ThoiHan"].Value.ToString(), out int th))
                    numThoiHan.Value = th;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaPDK.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPDK.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần sửa!");
                return;
            }
            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaPDK.Enabled = false; // PK
            cmbSinhVien.Enabled = false; // Usually don't allow changing SV/Room in Edit, only dates, but let's allow Room change maybe? Service limits it.
            // Service says: "Không cho đổi sinh viên & phòng" in Update method. 
            // So disable them.
            cmbPhong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPDK.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa!");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn xóa phiếu {txtMaPDK.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(txtMaPDK.Text))
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
            if (string.IsNullOrWhiteSpace(txtMaPDK.Text))
            {
                MessageBox.Show("Chưa nhập Mã Phiếu!");
                return;
            }
            if (cmbSinhVien.SelectedValue == null || cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn Sinh viên hoặc Phòng!");
                return;
            }

            // Constraint: 1 SV / 1 Phong / Info
            // Only check on Insert
            string mssv = cmbSinhVien.SelectedValue.ToString();
            int hk = (int)numHocKy.Value;
            string nam = txtNamHoc.Text.Trim();

            if (_isAdding)
            {
                if (_service.DaDangKyPhong(mssv, hk, nam))
                {
                    MessageBox.Show($"Sinh viên {mssv} đã đăng ký phòng trong HK {hk} Năm {nam} rồi! Vui lòng kiểm tra lại.");
                    return;
                }
            }

            PHIEUDK pdk = new PHIEUDK
            {
                MaPDK = txtMaPDK.Text.Trim(),
                MSSV = mssv,
                MaPhong = cmbPhong.SelectedValue.ToString(),
                MaNV = cmbNhanVien.SelectedValue?.ToString(),
                HocKy = hk,
                NamHoc = nam,
                NgayGioDK = dtpNgayDK.Value,
                ThoiHan = (int)numThoiHan.Value,
                NgayBD = dtpNgayDK.Value // Default Start Date = Reg Date
            };

            bool result;
            if (_isAdding)
                result = _service.Insert(pdk);
            else
                result = _service.Update(pdk);

            if (result)
            {
                MessageBox.Show(_isAdding ? "Đăng ký thành công!" : "Cập nhật thành công!");
                LoadData();
                SetButtonState(true);
                SetInputState(false);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại! Có thể trùng mã hoặc lỗi dữ liệu.");
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
            string keyword = txtTimKiem.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }
            var list = _service.GetAll().Where(x => 
                x.MaPDK.ToLower().Contains(keyword) || 
                (x.MSSV != null && x.MSSV.ToLower().Contains(keyword))
            ).ToList();
            BindGrid(list);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
