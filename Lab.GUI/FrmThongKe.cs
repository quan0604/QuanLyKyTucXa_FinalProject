using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab.BUS;

namespace Lab.GUI
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService _thongKeService;

        public FrmThongKe()
        {
            InitializeComponent();
            _thongKeService = new ThongKeService();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dtpThangNam.Value = DateTime.Now;
            LoadDoanhThu();
            LoadTinhTrangPhong();
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void LoadDoanhThu()
        {
            try
            {
                int thang = dtpThangNam.Value.Month;
                int nam = dtpThangNam.Value.Year;

                var data = _thongKeService.GetDoanhThu(thang, nam);

                dgvDoanhThu.DataSource = data;
                
                // Format columns
                if (dgvDoanhThu.Columns["TienPhong"] != null) dgvDoanhThu.Columns["TienPhong"].DefaultCellStyle.Format = "N0";
                if (dgvDoanhThu.Columns["TienDichVu"] != null) dgvDoanhThu.Columns["TienDichVu"].DefaultCellStyle.Format = "N0";
                if (dgvDoanhThu.Columns["TongTien"] != null) dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                if (dgvDoanhThu.Columns["NgayHD"] != null) dgvDoanhThu.Columns["NgayHD"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Calculate total
                decimal tong = data.Sum(x => x.TongTien);
                lblTongTien.Text = string.Format("Tổng cộng: {0:N0} VNĐ", tong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTinhTrangPhong();
        }

        private void LoadTinhTrangPhong()
        {
            try
            {
                var data = _thongKeService.GetTinhTrangPhong();
                dgvTinhTrang.DataSource = data;

                // Summary
                int totalRooms = data.Count;
                int fullRooms = data.Count(x => x.TrangThai == "Đầy");
                int emptyRooms = data.Count(x => x.TrangThai == "Trống");
                int occupiedRooms = data.Count(x => x.TrangThai == "Có người");

                lblTongPhong.Text = string.Format("Tổng: {0} phòng | Trống: {1} | Có người: {2} | Đầy: {3}", 
                    totalRooms, emptyRooms, occupiedRooms, fullRooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
