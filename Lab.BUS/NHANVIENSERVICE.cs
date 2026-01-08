using System.Collections.Generic;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class NhanVienService : QLKTXService
    {
        public List<NHANVIEN> GetAll()
        {
            return _context.NHANVIEN.ToList();
        }

        public NHANVIEN GetById(string maNV)
        {
            return _context.NHANVIEN.FirstOrDefault(x => x.MaNV == maNV);
        }

        public bool Insert(NHANVIEN nv)
        {
            if (nv == null || string.IsNullOrEmpty(nv.MaNV))
                return false;

            if (_context.NHANVIEN.Any(x => x.MaNV == nv.MaNV))
                return false;

            _context.NHANVIEN.Add(nv);
            return Save();
        }

        public bool Update(NHANVIEN nv)
        {
            var db = GetById(nv.MaNV);
            if (db == null) return false;

            db.HoTen = nv.HoTen;
            db.CMND = nv.CMND;
            db.SDT = nv.SDT;
            db.Email = nv.Email;
            db.DiaChi = nv.DiaChi;
            db.Luong = nv.Luong;
            db.MaNQL = nv.MaNQL;
            db.AnhChanDung = nv.AnhChanDung;

            return Save();
        }

        public bool Delete(string maNV)
        {
            var nv = GetById(maNV);
            if (nv == null) return false;

            if (nv.HOADON.Any() || nv.PHIEUDK.Any())
                return false;

            _context.NHANVIEN.Remove(nv);
            return Save();
        }
    }
}
