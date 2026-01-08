using System.Collections.Generic;
using System.Linq;
using Lab.DAL;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class LoaiPhongService
    {
        private readonly QLKTXContext _context = new QLKTXContext();

        public List<LOAIPHONG> GetAll()
        {
            return _context.LOAIPHONG.ToList();
        }

        public LOAIPHONG GetById(string maLoai)
        {
            return _context.LOAIPHONG.FirstOrDefault(x => x.MaLoaiPhong == maLoai);
        }

        public bool Insert(LOAIPHONG lp)
        {
            if (_context.LOAIPHONG.Any(x => x.MaLoaiPhong == lp.MaLoaiPhong))
                return false;

            _context.LOAIPHONG.Add(lp);
            _context.SaveChanges();
            return true;
        }

        public bool Update(LOAIPHONG lp)
        {
            var existing = GetById(lp.MaLoaiPhong);
            if (existing == null) return false;

            existing.SoSV = lp.SoSV;
            existing.DienTich = lp.DienTich;
            existing.DonGia = lp.DonGia;

            _context.SaveChanges();
            return true;
        }

        public bool Delete(string maLoai)
        {
            var lp = GetById(maLoai);
            if (lp == null) return false;

            _context.LOAIPHONG.Remove(lp);
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Lấy số sinh viên tối đa theo loại phòng
        /// </summary>
        public int GetSoSVToiDa(string maLoai)
        {
            var lp = GetById(maLoai);
            return lp?.SoSV ?? 0;
        }
    }
}
