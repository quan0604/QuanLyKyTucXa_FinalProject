
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmLop : Form
    {
        private readonly LopService _service = new LopService();
        private bool _isAdding = false;
        private List<LOP> _originalList = new List<LOP>(); // Cache

        public FrmLop()
        {
            InitializeComponent();
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        private void LoadData()
        {
            try
            {
                _originalList = _service.GetAll();
                BindGrid(_originalList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void BindGrid(List<LOP> list)
        {
            dgvLop.DataSource = null;
            dgvLop.DataSource = list;

            // Hide navigation properties
            if (dgvLop.Columns["SINHVIEN"] != null) dgvLop.Columns["SINHVIEN"].Visible = false;

            // Headers
            if (dgvLop.Columns["MaLop"] != null) dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
            if (dgvLop.Columns["KhoaHoc"] != null) dgvLop.Columns["KhoaHoc"].HeaderText = "Khóa Học";
            if (dgvLop.Columns["KhoaQL"] != null) dgvLop.Columns["KhoaQL"].HeaderText = "Khoa Quản Lý";
            if (dgvLop.Columns["Nganh"] != null) dgvLop.Columns["Nganh"].HeaderText = "Ngành";
            if (dgvLop.Columns["SiSo"] != null) dgvLop.Columns["SiSo"].HeaderText = "Sĩ Số";
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
            txtMaLop.Enabled = enable;
            txtKhoaHoc.Enabled = enable;
            txtKhoaQL.Enabled = enable;
            txtNganh.Enabled = enable;
            numSiSo.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaLop.Clear();
            txtKhoaHoc.Clear();
            txtKhoaQL.Clear();
            txtNganh.Clear();
            numSiSo.Value = 0;
            txtMaLop.Enabled = true;
        }

        // ================= EVENTS =================
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString();
                txtKhoaQL.Text = row.Cells["KhoaQL"].Value?.ToString();
                txtNganh.Text = row.Cells["Nganh"].Value?.ToString();
                
                if (row.Cells["SiSo"].Value != null)
                    numSiSo.Value = Convert.ToDecimal(row.Cells["SiSo"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaLop.Enabled = false; // PK
            txtKhoaHoc.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa lớp {txtMaLop.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(txtMaLop.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Có thể lớp đang có sinh viên.");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp!");
                return;
            }

            LOP lop = new LOP
            {
                MaLop = txtMaLop.Text.Trim(),
                KhoaHoc = txtKhoaHoc.Text.Trim(),
                KhoaQL = txtKhoaQL.Text.Trim(),
                Nganh = txtNganh.Text.Trim(),
                SiSo = (int)numSiSo.Value
            };

            bool result;
            if (_isAdding)
                result = _service.Add(lop);
            else
                result = _service.Update(lop);

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
            if (_originalList == null) return;

            string keyword = txtTimKiem.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_originalList);
                return;
            }

            var filteredList = _originalList.Where(l => 
                (l.MaLop != null && l.MaLop.ToLower().Contains(keyword)) || 
                (l.KhoaQL != null && l.KhoaQL.ToLower().Contains(keyword)) ||
                (l.Nganh != null && l.Nganh.ToLower().Contains(keyword))
            ).ToList();
            
            BindGrid(filteredList);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
