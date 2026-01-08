using System.Collections.Generic;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class NguoiThanService : QLKTXService
    {
        public List<NGUOITHAN> GetAll()
        {
            return _context.NGUOITHAN.ToList();
        }

        public List<NGUOITHAN> GetByMSSV(string mssv)
        {
            return _context.NGUOITHAN
                           .Where(x => x.MSSV == mssv)
                           .ToList();
        }

        public NGUOITHAN GetById(string mssv, string sdt)
        {
            return _context.NGUOITHAN
                           .FirstOrDefault(x => x.MSSV == mssv && x.SDT == sdt);
        }

        public bool Insert(NGUOITHAN nt)
        {
            if (nt == null || string.IsNullOrEmpty(nt.MSSV) || string.IsNullOrEmpty(nt.SDT))
                return false;

            if (_context.NGUOITHAN.Any(x => x.MSSV == nt.MSSV && x.SDT == nt.SDT))
                return false;

            if (!_context.SINHVIEN.Any(x => x.MSSV == nt.MSSV))
                return false;

            _context.NGUOITHAN.Add(nt);
            return Save();
        }

        public bool Update(NGUOITHAN nt)
        {
            var db = GetById(nt.MSSV, nt.SDT);
            if (db == null) return false;

            db.HoTen = nt.HoTen;
            db.Email = nt.Email;
            db.DiaChi = nt.DiaChi;

            return Save();
        }

        public bool Delete(string mssv, string sdt)
        {
            var nt = GetById(mssv, sdt);
            if (nt == null) return false;

            _context.NGUOITHAN.Remove(nt);
            return Save();
        }
    }
}
