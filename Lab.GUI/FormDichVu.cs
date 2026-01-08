
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FormDichVu : Form
    {
        private DichVuService _service = new DichVuService();
        private bool _isAdding = false;

        public FormDichVu()
        {
            InitializeComponent();
            this.Load += FormDichVu_Load;
            
            // Event Binding
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += BtnThoat_Click;
            dgvDichVu.CellClick += DgvDichVu_CellClick;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(true);
            SetInputState(false);
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
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<DICHVU> list)
        {
            dgvDichVu.DataSource = list.Select(d => new
            {
                d.MaDV,
                d.TenDV,
                d.DonViTinh,
                d.GiaDV
            }).ToList();

            dgvDichVu.Columns["MaDV"].HeaderText = "Mã DV";
            dgvDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns["DonViTinh"].HeaderText = "Đơn Vị";
            dgvDichVu.Columns["GiaDV"].HeaderText = "Giá";
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
            txtMaDV.Enabled = enable;
            txtTenDV.Enabled = enable;
            txtDonVi.Enabled = enable;
            txtGiaDV.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonVi.Clear();
            txtGiaDV.Clear();
        }

        private void DgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled) // Only fill when not in add/edit mode
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells["MaDV"].Value.ToString();
                txtTenDV.Text = row.Cells["TenDV"].Value.ToString();
                txtDonVi.Text = row.Cells["DonViTinh"].Value.ToString();
                txtGiaDV.Text = row.Cells["GiaDV"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            txtMaDV.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            txtMaDV.Enabled = false; // Primary key cannot be changed
            txtTenDV.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa dịch vụ {txtTenDV.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (_service.Delete(txtMaDV.Text))
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
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || string.IsNullOrWhiteSpace(txtTenDV.Text) || string.IsNullOrWhiteSpace(txtGiaDV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiaDV.Text, out decimal gia))
            {
                MessageBox.Show("Giá dịch vụ phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DICHVU dv = new DICHVU
            {
                MaDV = txtMaDV.Text.Trim(),
                TenDV = txtTenDV.Text.Trim(),
                DonViTinh = txtDonVi.Text.Trim(),
                GiaDV = gia
            };

            try
            {
                bool result;
                if (_isAdding)
                {
                    result = _service.Insert(dv);
                    if (!result) MessageBox.Show("Mã dịch vụ đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = _service.Update(dv);
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
            dgvDichVu.ClearSelection();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var list = _service.GetAll().Where(d => 
                d.MaDV.ToLower().Contains(keyword) || 
                d.TenDV.ToLower().Contains(keyword)).ToList();
            
            BindGrid(list);
        }
    }
}
