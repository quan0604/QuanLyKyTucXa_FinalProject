using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class DoanhThuDTO
    {
        public string MaHD { get; set; }
        public DateTime? NgayHD { get; set; }
        public string MaPhong { get; set; }
        public decimal TienPhong { get; set; }
        public decimal TienDichVu { get; set; }
        public decimal TongTien { get; set; }
    }

    public class TinhTrangPhongDTO
    {
        public string MaPhong { get; set; }
        public string TenLoaiPhong { get; set; } // Assuming MaLoaiPhong maps to a name or just use ID
        public int SucChua { get; set; }
        public int DangO { get; set; }
        public string TrangThai { get; set; }
    }

    public class ThongKeService : QLKTXService
    {
        // =========================
        // THỐNG KÊ DOANH THU
        // =========================
        public List<DoanhThuDTO> GetDoanhThu(int thang, int nam)
        {
            var listHD = _context.HOADON
                                 .Where(h => h.NgayHD.HasValue && h.NgayHD.Value.Month == thang && h.NgayHD.Value.Year == nam)
                                 .Include(h => h.PHONG.LOAIPHONG)
                                 .Include(h => h.SDDV.Select(s => s.DICHVU))
                                 .ToList();

            var result = new List<DoanhThuDTO>();

            foreach (var hd in listHD)
            {
                decimal tienPhong = 0;
                if (hd.PHONG != null && hd.PHONG.LOAIPHONG != null && hd.PHONG.LOAIPHONG.DonGia.HasValue)
                {
                    tienPhong = hd.PHONG.LOAIPHONG.DonGia.Value;
                }

                decimal tienDichVu = 0;
                if (hd.SDDV != null)
                {
                    foreach (var sd in hd.SDDV)
                    {
                        if (sd.SoLuong.HasValue && sd.DICHVU != null && sd.DICHVU.GiaDV.HasValue)
                        {
                            tienDichVu += sd.SoLuong.Value * sd.DICHVU.GiaDV.Value;
                        }
                    }
                }

                result.Add(new DoanhThuDTO
                {
                    MaHD = hd.MaHD,
                    NgayHD = hd.NgayHD,
                    MaPhong = hd.MaPhong,
                    TienPhong = tienPhong,
                    TienDichVu = tienDichVu,
                    TongTien = tienPhong + tienDichVu
                });
            }

            return result;
        }

        // =========================
        // THỐNG KÊ TÌNH TRẠNG PHÒNG
        // =========================
        public List<TinhTrangPhongDTO> GetTinhTrangPhong()
        {
            var listPhong = _context.PHONG
                                    .Include(p => p.LOAIPHONG)
                                    .Include(p => p.PHIEUDK)
                                    .ToList();
            
            var result = new List<TinhTrangPhongDTO>();
            DateTime now = DateTime.Now;

            foreach (var p in listPhong)
            {
                int sucChua = (p.LOAIPHONG != null && p.LOAIPHONG.SoSV.HasValue) ? p.LOAIPHONG.SoSV.Value : 0;
                
                // Đếm số phiếu đăng ký còn hiệu lực
                int dangO = p.PHIEUDK.Count(dk => 
                    dk.NgayBD.HasValue && 
                    dk.ThoiHan.HasValue && 
                    dk.NgayBD.Value <= now && 
                    dk.NgayBD.Value.AddMonths(dk.ThoiHan.Value) >= now
                );

                string trangThai = "Trống";
                if (dangO >= sucChua) trangThai = "Đầy";
                else if (dangO > 0) trangThai = "Có người";

                result.Add(new TinhTrangPhongDTO
                {
                    MaPhong = p.MaPhong,
                    TenLoaiPhong = p.LOAIPHONG != null ? p.LOAIPHONG.MaLoaiPhong : "",
                    SucChua = sucChua,
                    DangO = dangO,
                    TrangThai = trangThai
                });
            }

            return result;
        }
    }
}
