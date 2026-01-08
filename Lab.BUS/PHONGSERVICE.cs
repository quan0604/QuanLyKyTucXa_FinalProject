using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class PhongService : QLKTXService
    {
        // ❌ KHÔNG KHAI BÁO _context LẠI
        // ❌ KHÔNG new DbContext

        // =========================
        // LẤY DANH SÁCH PHÒNG
        // =========================
        public List<PHONG> GetAll()
        {
            return _context.PHONG
                           .Include(p => p.LOAIPHONG)
                           .ToList();
        }

        // =========================
        // LẤY PHÒNG THEO MÃ
        // =========================
        public PHONG GetById(string maPhong)
        {
            return _context.PHONG
                           .Include(p => p.LOAIPHONG)
                           .FirstOrDefault(p => p.MaPhong == maPhong);
        }

        // =========================
        // THÊM PHÒNG
        // =========================
        public bool Add(PHONG phong)
        {
            if (phong == null) return false;

            if (_context.PHONG.Any(p => p.MaPhong == phong.MaPhong))
                return false;

            _context.PHONG.Add(phong);
            return Save();
        }

        // =========================
        // CẬP NHẬT PHÒNG
        // =========================
        public bool Update(PHONG phong)
        {
            var existing = _context.PHONG.Find(phong.MaPhong);
            if (existing == null) return false;

            existing.Khu = phong.Khu;
            existing.MaLoaiPhong = phong.MaLoaiPhong;

            return Save();
        }

        // =========================
        // XÓA PHÒNG
        // =========================
        public bool Delete(string maPhong)
        {
            var phong = _context.PHONG
                                .Include(p => p.HOADON)
                                .Include(p => p.PHIEUDK)
                                .FirstOrDefault(p => p.MaPhong == maPhong);

            if (phong == null) return false;

            if (phong.HOADON.Any() || phong.PHIEUDK.Any())
                return false;

            _context.PHONG.Remove(phong);
            return Save();
        }

        // =========================
        // LẤY PHÒNG THEO KHU
        // =========================
        public List<PHONG> GetByKhu(string khu)
        {
            return _context.PHONG
                           .Where(p => p.Khu == khu)
                           .ToList();
        }

        // =========================
        // LẤY PHÒNG THEO LOẠI
        // =========================
        public List<PHONG> GetByLoaiPhong(string maLoaiPhong)
        {
            return _context.PHONG
                           .Where(p => p.MaLoaiPhong == maLoaiPhong)
                           .ToList();
        }
    }
}
