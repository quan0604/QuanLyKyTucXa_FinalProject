using System.Collections.Generic;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class DichVuService : QLKTXService
    {
        public List<DICHVU> GetAll()
        {
            return _context.DICHVU.ToList();
        }

        public DICHVU GetById(string maDV)
        {
            return _context.DICHVU.FirstOrDefault(x => x.MaDV == maDV);
        }

        public bool Insert(DICHVU dv)
        {
            if (_context.DICHVU.Any(x => x.MaDV == dv.MaDV))
                return false;

            _context.DICHVU.Add(dv);
            return Save();
        }

        public bool Update(DICHVU dv)
        {
            var existing = GetById(dv.MaDV);
            if (existing == null) return false;

            existing.TenDV = dv.TenDV;
            existing.DonViTinh = dv.DonViTinh;
            existing.GiaDV = dv.GiaDV;

            return Save();
        }

        public bool Delete(string maDV)
        {
            var dv = GetById(maDV);
            if (dv == null) return false;

            _context.DICHVU.Remove(dv);
            return Save();
        }
    }
}
