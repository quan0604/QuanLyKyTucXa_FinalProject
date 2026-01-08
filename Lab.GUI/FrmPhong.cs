
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmPhong : Form
    {
        private readonly PhongService _service = new PhongService();
        private readonly LoaiPhongService _loaiPhongService = new LoaiPhongService();
        private bool _isAdding = false;

        public FrmPhong()
        {
            InitializeComponent();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        // ================= DATA LOADING =================
        private void LoadComboBoxes()
        {
            try
            {
                var listLoai = _loaiPhongService.GetAll();
                cmbLoaiPhong.DataSource = listLoai;
                cmbLoaiPhong.DisplayMember = "MaLoaiPhong"; 
                cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại phòng: " + ex.Message);
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
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
        }

        private void BindGrid(List<PHONG> list)
        {
            dgvPhong.DataSource = null;
            dgvPhong.DataSource = list;

            // Hide navigation properties
            if (dgvPhong.Columns["LOAIPHONG"] != null) dgvPhong.Columns["LOAIPHONG"].Visible = false;
            if (dgvPhong.Columns["SINHVIENs"] != null) dgvPhong.Columns["SINHVIENs"].Visible = false;
            if (dgvPhong.Columns["HOADONDIENNUOCs"] != null) dgvPhong.Columns["HOADONDIENNUOCs"].Visible = false;

            // Header mapping
            if (dgvPhong.Columns["MaPhong"] != null) dgvPhong.Columns["MaPhong"].HeaderText = "Mã Phòng";
            if (dgvPhong.Columns["Khu"] != null) dgvPhong.Columns["Khu"].HeaderText = "Tên Phòng / Khu";
            if (dgvPhong.Columns["MaLoaiPhong"] != null) dgvPhong.Columns["MaLoaiPhong"].HeaderText = "Loại Phòng";
            if (dgvPhong.Columns["TinhTrang"] != null) dgvPhong.Columns["TinhTrang"].HeaderText = "Tình Trạng";
        }

        // ================= UI MANAGEMENT =================
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
            txtMaPhong.Enabled = enable;
            txtTenPhong.Enabled = enable;
            cmbLoaiPhong.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            if (cmbLoaiPhong.Items.Count > 0) cmbLoaiPhong.SelectedIndex = 0;
            txtMaPhong.Enabled = true;
        }

        // ================= EVENTS =================
        // Important: Designer has CellClick event wired to dgvPhong_CellClick.
        // We ensure case sensitivity matches if needed, but in C# standard event is capitalized.
        // Designer wires: this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString();
                txtTenPhong.Text = row.Cells["Khu"].Value?.ToString();
                if (row.Cells["MaLoaiPhong"].Value != null)
                {
                    cmbLoaiPhong.SelectedValue = row.Cells["MaLoaiPhong"].Value?.ToString();
                }
            }
        }
        
        // This method was added in Designer as Click event too, keeping it empty or redirecting to CellClick if needed.
        private void DgvPhong_CellClick(object sender, EventArgs e) 
        {
            // Empty, standard CellClick above handles logic.
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }
            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaPhong.Enabled = false; 
            txtTenPhong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng {txtMaPhong.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(txtMaPhong.Text))
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
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng!");
                return;
            }
            if (cmbLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại phòng!");
                return;
            }

            PHONG p = new PHONG
            {
                MaPhong = txtMaPhong.Text.Trim(),
                Khu = txtTenPhong.Text.Trim(),
                MaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString()
            };

            bool result;
            if (_isAdding)
                result = _service.Add(p);
            else
                result = _service.Update(p);

            if (result)
            {
                MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!");
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
            string keyword = txtTimKiem.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }
            var list = _service.GetAll().Where(p => 
                p.MaPhong.ToLower().Contains(keyword) || 
                (p.Khu != null && p.Khu.ToLower().Contains(keyword))
            ).ToList();
            BindGrid(list);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
