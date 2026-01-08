using System;
using System.Collections.Generic;
using System.Linq;
using Lab.DAL;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class PhieuDKService : QLKTXService
    {
        // =========================
        // LẤY DANH SÁCH
        // =========================
        public List<PHIEUDK> GetAll()
        {
            return _context.PHIEUDK.ToList();
        }

        public PHIEUDK GetById(string maPDK)
        {
            return _context.PHIEUDK.FirstOrDefault(x => x.MaPDK == maPDK);
        }

        public List<PHIEUDK> GetBySinhVien(string mssv)
        {
            return _context.PHIEUDK
                           .Where(x => x.MSSV == mssv)
                           .ToList();
        }

        // =========================
        // THÊM MỚI
        // =========================
        public bool Insert(PHIEUDK pdk)
        {
            if (pdk == null || string.IsNullOrEmpty(pdk.MaPDK))
                return false;

            if (_context.PHIEUDK.Any(x => x.MaPDK == pdk.MaPDK))
                return false;

            if (!_context.SINHVIEN.Any(x => x.MSSV == pdk.MSSV))
                return false;

            if (!_context.NHANVIEN.Any(x => x.MaNV == pdk.MaNV))
                return false;

            if (!_context.PHONG.Any(x => x.MaPhong == pdk.MaPhong))
                return false;

            if (!pdk.ThoiHan.HasValue || pdk.ThoiHan <= 0)
                return false;

            if (!pdk.NgayGioDK.HasValue)
                pdk.NgayGioDK = DateTime.Now;

            if (!pdk.NgayBD.HasValue)
                pdk.NgayBD = DateTime.Today;

            _context.PHIEUDK.Add(pdk);
            _context.SaveChanges();
            return true;
        }

        // =========================
        // CẬP NHẬT
        // =========================
        public bool Update(PHIEUDK pdk)
        {
            var db = GetById(pdk.MaPDK);
            if (db == null) return false;

            // Không cho đổi sinh viên & phòng
            db.HocKy = pdk.HocKy;
            db.NamHoc = pdk.NamHoc;
            db.ThoiHan = pdk.ThoiHan;
            db.NgayBD = pdk.NgayBD;

            _context.SaveChanges();
            return true;
        }

        // =========================
        // XÓA
        // =========================
        public bool Delete(string maPDK)
        {
            var pdk = GetById(maPDK);
            if (pdk == null) return false;

            _context.PHIEUDK.Remove(pdk);
            _context.SaveChanges();
            return true;
        }

        // =========================
        // NGHIỆP VỤ
        // =========================

        /// <summary>
        /// Kiểm tra sinh viên đã đăng ký phòng trong cùng học kỳ & năm học chưa
        /// </summary>
        public bool DaDangKyPhong(string mssv, int hocKy, string namHoc)
        {
            return _context.PHIEUDK.Any(x =>
                x.MSSV == mssv &&
                x.HocKy == hocKy &&
                x.NamHoc == namHoc);
        }

        /// <summary>
        /// Lấy danh sách phiếu còn hiệu lực
        /// </summary>
        public List<PHIEUDK> GetPhieuConHieuLuc()
        {
            return _context.PHIEUDK
                .Where(x =>
                    x.NgayBD.HasValue &&
                    x.ThoiHan.HasValue &&
                    DateTime.Now <= x.NgayBD.Value.AddMonths(x.ThoiHan.Value))
                .ToList();
        }
    }
}
