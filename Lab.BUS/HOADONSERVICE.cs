using System.Collections.Generic;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class HoaDonService : QLKTXService
    {
        public List<HOADON> GetAll()
        {
            return _context.HOADON.ToList();
        }

        public HOADON GetById(string maHD)
        {
            return _context.HOADON.FirstOrDefault(x => x.MaHD == maHD);
        }

        public bool Insert(HOADON hd)
        {
            if (_context.HOADON.Any(x => x.MaHD == hd.MaHD))
                return false;

            _context.HOADON.Add(hd);
            return Save();
        }

        public bool Update(HOADON hd)
        {
            var existing = GetById(hd.MaHD);
            if (existing == null) return false;

            existing.NgayHD = hd.NgayHD;
            existing.MaNV = hd.MaNV;
            existing.MaPhong = hd.MaPhong;

            return Save();
        }

        public bool Delete(string maHD)
        {
            var hd = GetById(maHD);
            if (hd == null) return false;

            var chiTiet = _context.SDDV.Where(x => x.MaHD == maHD).ToList();
            _context.SDDV.RemoveRange(chiTiet);

            _context.HOADON.Remove(hd);
            return Save();
        }

        // ================= NGHIỆP VỤ =================

        public bool ThemDichVu(string maHD, string maDV, int soLuong)
        {
            if (soLuong <= 0) return false;

            var ct = _context.SDDV
                             .FirstOrDefault(x => x.MaHD == maHD && x.MaDV == maDV);

            if (ct != null)
                ct.SoLuong += soLuong;
            else
                _context.SDDV.Add(new SDDV
                {
                    MaHD = maHD,
                    MaDV = maDV,
                    SoLuong = soLuong
                });

            return Save();
        }

        public decimal TinhTongTien(string maHD)
        {
            return (from ct in _context.SDDV
                    join dv in _context.DICHVU on ct.MaDV equals dv.MaDV
                    where ct.MaHD == maHD
                    select (decimal)(ct.SoLuong * dv.GiaDV))
                   .DefaultIfEmpty(0)
                   .Sum();
        }
    }
}
