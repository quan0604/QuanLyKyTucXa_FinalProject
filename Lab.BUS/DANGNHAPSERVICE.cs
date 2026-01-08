using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class DangNhapService : QLKTXService
    {
        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        public NHANVIEN KiemTraDangNhap(string tenDN, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau))
                return null;

            var dangNhap = _context.DANGNHAP
                                   .FirstOrDefault(x => x.TenDN == tenDN
                                                     && x.MatKhau == matKhau);

            if (dangNhap == null)
                return null;

            return _context.NHANVIEN
                           .FirstOrDefault(nv => nv.MaNV == dangNhap.MaNV);
        }

        public bool TonTaiTenDangNhap(string tenDN)
        {
            return _context.DANGNHAP.Any(x => x.TenDN == tenDN);
        }

        public bool ThemTaiKhoan(string tenDN, string matKhau, string maNV)
        {
            if (TonTaiTenDangNhap(tenDN))
                return false;

            _context.DANGNHAP.Add(new DANGNHAP
            {
                TenDN = tenDN,
                MatKhau = matKhau,
                MaNV = maNV
            });

            return Save();
        }

        public bool DoiMatKhau(string tenDN, string matKhauCu, string matKhauMoi)
        {
            var dn = _context.DANGNHAP
                             .FirstOrDefault(x => x.TenDN == tenDN
                                               && x.MatKhau == matKhauCu);

            if (dn == null)
                return false;

            dn.MatKhau = matKhauMoi;
            return Save();
        }

        public bool XoaTaiKhoan(string tenDN)
        {
            var dn = _context.DANGNHAP.FirstOrDefault(x => x.TenDN == tenDN);
            if (dn == null)
                return false;

            _context.DANGNHAP.Remove(dn);
            return Save();
        }

        public System.Collections.Generic.List<DANGNHAP> GetAll()
        {
            return _context.DANGNHAP.Include("NHANVIEN").ToList();
        }

        public bool UpdatePasswordAdmin(string tenDN, string newPass)
        {
             var dn = _context.DANGNHAP.FirstOrDefault(x => x.TenDN == tenDN);
             if (dn == null) return false;
             dn.MatKhau = newPass;
             return Save();
        }
    }
}
