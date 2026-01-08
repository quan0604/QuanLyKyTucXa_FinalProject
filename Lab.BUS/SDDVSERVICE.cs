using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class SddvService : QLKTXService
    {
        // =========================
        // LẤY TẤT CẢ SDDV
        // =========================
        public List<SDDV> GetAll()
        {
            return _context.SDDV
                           .Include("DICHVU")
                           .Include("HOADON")
                           .ToList();
        }

        // =========================
        // LẤY SDDV THEO MÃ HÓA ĐƠN
        // =========================
        public List<SDDV> GetByMaHD(string maHD)
        {
            return _context.SDDV
                           .Where(x => x.MaHD == maHD)
                           .Include("DICHVU")
                           .ToList();
        }

        // =========================
        // LẤY SDDV THEO ID (MaHD, MaDV)
        // =========================
        public SDDV GetById(string maHD, string maDV)
        {
            return _context.SDDV.FirstOrDefault(x => x.MaHD == maHD && x.MaDV == maDV);
        }

        // =========================
        // THÊM MỚI
        // =========================
        public bool Insert(SDDV sddv)
        {
            if (sddv == null || string.IsNullOrEmpty(sddv.MaHD) || string.IsNullOrEmpty(sddv.MaDV))
                return false;

            // Kiểm tra trùng
            if (_context.SDDV.Any(x => x.MaHD == sddv.MaHD && x.MaDV == sddv.MaDV))
                return false;

            // Kiểm tra tồn tại MaHD và MaDV
            if (!_context.HOADON.Any(h => h.MaHD == sddv.MaHD) || !_context.DICHVU.Any(d => d.MaDV == sddv.MaDV))
                 return false;

            _context.SDDV.Add(sddv);
            return Save();
        }

        // =========================
        // CẬP NHẬT
        // =========================
        public bool Update(SDDV sddv)
        {
            var db = GetById(sddv.MaHD, sddv.MaDV);
            if (db == null) return false;

            db.SoLuong = sddv.SoLuong;
            // Key không được sửa, nếu muốn đổi key thì phải xóa đi tạo lại

            return Save();
        }

        // =========================
        // XÓA
        // =========================
        public bool Delete(string maHD, string maDV)
        {
            var db = GetById(maHD, maDV);
            if (db == null) return false;

            _context.SDDV.Remove(db);
            return Save();
        }
    }
}
