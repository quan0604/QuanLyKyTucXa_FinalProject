
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmLoaiPhong : Form
    {
        private readonly LoaiPhongService _service = new LoaiPhongService();
        private bool _isAdding = false;

        public FrmLoaiPhong()
        {
            InitializeComponent();
        }

        private void FrmLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(true);
            SetInputState(false);
        }

        // ================= LOADING DATA =================
        private void LoadData()
        {
            try
            {
                var list = _service.GetAll();
                BindGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<LOAIPHONG> list)
        {
            dgvLoaiPhong.DataSource = null;
            dgvLoaiPhong.DataSource = list;

            // Hide navigation properties
            if (dgvLoaiPhong.Columns["PHONG"] != null) dgvLoaiPhong.Columns["PHONG"].Visible = false;

            // Format columns
            if (dgvLoaiPhong.Columns["MaLoaiPhong"] != null) dgvLoaiPhong.Columns["MaLoaiPhong"].HeaderText = "Mã Loại";
            if (dgvLoaiPhong.Columns["SoSV"] != null) dgvLoaiPhong.Columns["SoSV"].HeaderText = "Số SV Tối Đa";
            if (dgvLoaiPhong.Columns["DienTich"] != null) dgvLoaiPhong.Columns["DienTich"].HeaderText = "Diện Tích (m²)";
            if (dgvLoaiPhong.Columns["DonGia"] != null)
            {
                dgvLoaiPhong.Columns["DonGia"].HeaderText = "Đơn Giá";
                dgvLoaiPhong.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
        }

        // ================= UI STATE MANAGEMENT =================
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
            txtMaLoai.Enabled = enable;
            txtSoSV.Enabled = enable;
            txtDienTich.Enabled = enable;
            txtDonGia.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaLoai.Clear();
            txtSoSV.Clear();
            txtDienTich.Clear();
            txtDonGia.Clear();
            txtMaLoai.Enabled = true;
        }

        // ================= EVENTS =================
        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled) // Only fill if not adding/editing
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoaiPhong"].Value?.ToString();
                txtSoSV.Text = row.Cells["SoSV"].Value?.ToString();
                txtDienTich.Text = row.Cells["DienTich"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa!");
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaLoai.Enabled = false; // Primary Key cannot be changed
            txtSoSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa loại phòng {txtMaLoai.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(txtMaLoai.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Loại phòng đang được sử dụng.");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtSoSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã loại phòng và Số SV!");
                return;
            }

            if (!int.TryParse(txtSoSV.Text, out int soSV) || soSV <= 0)
            {
                MessageBox.Show("Số SV phải là số nguyên dương!");
                return;
            }

            double dienTich = 0;
            if (!string.IsNullOrWhiteSpace(txtDienTich.Text) && !double.TryParse(txtDienTich.Text, out dienTich))
            {
                MessageBox.Show("Diện tích phải là số!");
                return;
            }

            decimal donGia = 0;
            if (!string.IsNullOrWhiteSpace(txtDonGia.Text) && !decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                return;
            }

            LOAIPHONG lp = new LOAIPHONG
            {
                MaLoaiPhong = txtMaLoai.Text.Trim(),
                SoSV = soSV,
                DienTich = dienTich,
                DonGia = donGia
            };

            bool result;
            if (_isAdding)
                result = _service.Insert(lp);
            else
                result = _service.Update(lp);

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

            var list = _service.GetAll().Where(l => 
                l.MaLoaiPhong.ToLower().Contains(keyword)
            ).ToList();
            BindGrid(list);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
