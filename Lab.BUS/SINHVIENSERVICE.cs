using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class SinhVienService : QLKTXService
    {
        // =========================
        // LẤY DANH SÁCH SINH VIÊN
        // =========================
        public List<SINHVIEN> GetAll()
        {
            return _context.SINHVIEN
                           .Include(s => s.LOP) // Load thông tin lớp
                           .ToList();
        }

        // =========================
        // LẤY SINH VIÊN THEO MSSV
        // =========================
        public SINHVIEN GetById(string mssv)
        {
            return _context.SINHVIEN
                           .Include(s => s.LOP)
                           .FirstOrDefault(s => s.MSSV == mssv);
        }

        // =========================
        // LẤY DANH SÁCH THEO LỚP
        // =========================
        public List<SINHVIEN> GetByLop(string maLop)
        {
            return _context.SINHVIEN
                           .Where(s => s.MaLop == maLop)
                           .Include(s => s.LOP)
                           .ToList();
        }

        // =========================
        // THÊM SINH VIÊN
        // =========================
        public bool Insert(SINHVIEN sv)
        {
            if (sv == null || string.IsNullOrEmpty(sv.MSSV))
                return false;

            if (_context.SINHVIEN.Any(s => s.MSSV == sv.MSSV))
                return false;

            _context.SINHVIEN.Add(sv);
            return Save();
        }

        // =========================
        // CẬP NHẬT SINH VIÊN
        // =========================
        public bool Update(SINHVIEN sv)
        {
            var existing = GetById(sv.MSSV);
            if (existing == null) return false;

            existing.HoTen = sv.HoTen;
            existing.MaLop = sv.MaLop;
            existing.Phai = sv.Phai;
            existing.NgSinh = sv.NgSinh;
            existing.CMND = sv.CMND;
            existing.SDT = sv.SDT;
            existing.Email = sv.Email;
            existing.QueQuan = sv.QueQuan;
            existing.DienSV = sv.DienSV;
            existing.BHYT = sv.BHYT;
            existing.AnhChanDung = sv.AnhChanDung;

            return Save();
        }

        // =========================
        // XÓA SINH VIÊN
        // =========================
        public bool Delete(string mssv)
        {
            var sv = GetById(mssv);
            if (sv == null) return false;

            // Kiểm tra ràng buộc trước khi xóa
            if (sv.PHIEUDK.Any() || sv.NGUOITHAN.Any())
                return false;

            _context.SINHVIEN.Remove(sv);
            return Save();
        }
    }
}
