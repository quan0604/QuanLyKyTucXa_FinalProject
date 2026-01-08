
using Lab.BUS;
using Lab.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.GUI
{
    public partial class FrmSuDungDichVu : Form
    {
        private readonly SddvService _service = new SddvService();
        private readonly HoaDonService _hdService = new HoaDonService();
        private readonly DichVuService _dvService = new DichVuService();

        private bool _isAdding = false;

        public FrmSuDungDichVu()
        {
            InitializeComponent();
        }

        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            SetButtonState(true);
            SetInputState(false);
            
            // Initial Load: If Invoice selected, load its data
            if (cmbHoaDon.Items.Count > 0)
            {
                cmbHoaDon.SelectedIndex = 0;
                LoadDataByHoaDon(cmbHoaDon.SelectedValue.ToString());
            }
        }

        // ================= LOADING DATA =================
        private void LoadComboboxes()
        {
            try
            {
                // Hoa Don
                var listHD = _hdService.GetAll();
                cmbHoaDon.DataSource = listHD;
                cmbHoaDon.DisplayMember = "MaHD"; // Can customize to show more info if Entity.ToString() is overridden
                cmbHoaDon.ValueMember = "MaHD";

                // Dich Vu
                var listDV = _dvService.GetAll();
                cmbDichVu.DataSource = listDV;
                cmbDichVu.DisplayMember = "TenDV";
                cmbDichVu.ValueMember = "MaDV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu combobox: " + ex.Message);
            }
        }

        private void LoadDataByHoaDon(string maHD)
        {
            try
            {
                var list = _service.GetByMaHD(maHD);
                BindGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message);
            }
        }

        private void BindGrid(List<SDDV> list)
        {
            dgvSDDV.DataSource = null;
            // Use Client-side projection to flatten data for display
            var displayList = list.Select(x => new 
            {
                x.MaHD,
                x.MaDV,
                TenDV = x.DICHVU != null ? x.DICHVU.TenDV : "N/A",
                Gia = x.DICHVU != null ? x.DICHVU.GiaDV : 0,
                x.SoLuong,
                ThanhTien = (x.SoLuong ?? 0) * (x.DICHVU != null ? x.DICHVU.GiaDV : 0)
            }).ToList();

            dgvSDDV.DataSource = displayList;

            // Headers
            if (dgvSDDV.Columns["MaHD"] != null) dgvSDDV.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            if (dgvSDDV.Columns["MaDV"] != null) dgvSDDV.Columns["MaDV"].Visible = false; // Hide ID, show Name
            if (dgvSDDV.Columns["TenDV"] != null) dgvSDDV.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
            if (dgvSDDV.Columns["Gia"] != null) dgvSDDV.Columns["Gia"].HeaderText = "Đơn Giá";
            if (dgvSDDV.Columns["SoLuong"] != null) dgvSDDV.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (dgvSDDV.Columns["ThanhTien"] != null) dgvSDDV.Columns["ThanhTien"].HeaderText = "Thành Tiền";
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
            
            // Only allow changing Invoice Selection when NOT editing
            cmbHoaDon.Enabled = isEditing; 
        }

        private void SetInputState(bool enable)
        {
            // Invoice is master filter, usually locked during Add/Edit item for THAT invoice
            // But if Adding, we might want to let user select Invoice? 
            // Let's assume we are adding to CURRENTLY SELECTED Invoice to keep it simple.
            // So cmbHoaDon is LOCKED during Edit/Add to prevent context switch.
            
            cmbDichVu.Enabled = enable;
            numSoLuong.Enabled = enable;
        }

        private void ClearInputs()
        {
            if (cmbDichVu.Items.Count > 0) cmbDichVu.SelectedIndex = 0;
            numSoLuong.Value = 1;
        }

        // ================= EVENTS =================
        private void cmbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHoaDon.SelectedValue != null)
            {
                LoadDataByHoaDon(cmbHoaDon.SelectedValue.ToString());
            }
        }

        private void dgvSDDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnThem.Enabled) // Only load when not editing
            {
                // Because we used projection (Anonymous Type), we can't cast to SDDV directly.
                // We access cells by Name.
                var row = dgvSDDV.Rows[e.RowIndex];
                
                string maHD = row.Cells["MaHD"].Value?.ToString();
                string maDV = row.Cells["MaDV"].Value?.ToString();
                
                if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maDV)) return;
                
                cmbHoaDon.SelectedValue = maHD;
                cmbDichVu.SelectedValue = maDV;
                
                if (row.Cells["SoLuong"].Value != null)
                    numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbHoaDon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn trước!");
                return;
            }

            _isAdding = true;
            SetButtonState(false);
            SetInputState(true);
            ClearInputs();
            cmbDichVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbDichVu.SelectedValue == null) // Implies selection not made or grid empty
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!");
                return;
            }

            _isAdding = false;
            SetButtonState(false);
            SetInputState(true);
            cmbDichVu.Enabled = false; // Primary Key Part 2 (Part 1 is MaHD, locked)
            numSoLuong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cmbHoaDon.SelectedValue == null || cmbDichVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!");
                return;
            }

            string maHD = cmbHoaDon.SelectedValue.ToString();
            string maDV = cmbDichVu.SelectedValue.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa dịch vụ khỏi hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_service.Delete(maHD, maDV))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDataByHoaDon(maHD);
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
            if (cmbHoaDon.SelectedValue == null || cmbDichVu.SelectedValue == null)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            string maHD = cmbHoaDon.SelectedValue.ToString();
            string maDV = cmbDichVu.SelectedValue.ToString();
            int soLuong = (int)numSoLuong.Value;

            SDDV sddv = new SDDV
            {
                MaHD = maHD,
                MaDV = maDV,
                SoLuong = soLuong
            };

            bool result;
            if (_isAdding)
            {
                // Check if exists
                var exists = _service.GetById(maHD, maDV);
                if (exists != null)
                {
                     MessageBox.Show("Dịch vụ này đã có trong hóa đơn! Vui lòng chọn Sửa (hoặc dịch vụ khác).");
                     return;
                }
                result = _service.Insert(sddv);
            }
            else
            {
                result = _service.Update(sddv);
            }

            if (result)
            {
                MessageBox.Show(_isAdding ? "Thêm thành công!" : "Cập nhật thành công!");
                LoadDataByHoaDon(maHD);
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
            if(cmbHoaDon.SelectedValue != null)
                LoadDataByHoaDon(cmbHoaDon.SelectedValue.ToString()); // Reload original state
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
