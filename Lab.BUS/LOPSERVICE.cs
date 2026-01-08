using System;
using System.Collections.Generic;
using System.Linq;
using Lab.DAL;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class LopService : QLKTXService
    {
        private readonly QLKTXContext _context;

        public LopService()
        {
            _context = new QLKTXContext();
        }

        // =========================
        // LẤY DANH SÁCH LỚP
        // =========================
        public List<LOP> GetAll()
        {
            return _context.LOP
                           .Include("SINHVIEN")
                           .ToList();
        }

        // =========================
        // LẤY LỚP THEO MÃ
        // =========================
        public LOP GetById(string maLop)
        {
            return _context.LOP
                           .Include("SINHVIEN")
                           .FirstOrDefault(l => l.MaLop == maLop);
        }

        // =========================
        // THÊM LỚP
        // =========================
        public bool Add(LOP lop)
        {
            if (lop == null) return false;

            if (_context.LOP.Any(l => l.MaLop == lop.MaLop))
                return false;

            _context.LOP.Add(lop);
            _context.SaveChanges();
            return true;
        }

        // =========================
        // CẬP NHẬT LỚP
        // =========================
        public bool Update(LOP lop)
        {
            if (lop == null) return false;

            var existing = _context.LOP.Find(lop.MaLop);
            if (existing == null) return false;

            existing.KhoaHoc = lop.KhoaHoc;
            existing.KhoaQL = lop.KhoaQL;
            existing.Nganh = lop.Nganh;
            existing.SiSo = lop.SiSo;

            _context.SaveChanges();
            return true;
        }

        // =========================
        // XÓA LỚP
        // =========================
        public bool Delete(string maLop)
        {
            var lop = _context.LOP.Find(maLop);
            if (lop == null) return false;

            // Không cho xóa nếu lớp còn sinh viên
            if (lop.SINHVIEN != null && lop.SINHVIEN.Any())
                return false;

            _context.LOP.Remove(lop);
            _context.SaveChanges();
            return true;
        }

        // =========================
        // LẤY LỚP THEO KHOA QUẢN LÝ
        // =========================
        public List<LOP> GetByKhoaQL(string khoaQL)
        {
            return _context.LOP
                           .Where(l => l.KhoaQL == khoaQL)
                           .ToList();
        }

        // =========================
        // LẤY LỚP THEO NGÀNH
        // =========================
        public List<LOP> GetByNganh(string nganh)
        {
            return _context.LOP
                           .Where(l => l.Nganh == nganh)
                           .ToList();
        }
    }
}
