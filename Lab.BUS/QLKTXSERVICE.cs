using System;
using System.Data.Entity;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class QLKTXService : IDisposable
    {
        protected QLKTXContext _context;

        public QLKTXService()
        {
            _context = new QLKTXContext();
        }

        // =========================
        // KIỂM TRA KẾT NỐI DATABASE
        // =========================
        public bool CheckConnection()
        {
            try
            {
                return _context.Database.Exists();
            }
            catch
            {
                return false;
            }
        }

        // =========================
        // LƯU THAY ĐỔI
        // =========================
        protected bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // =========================
        // GIẢI PHÓNG TÀI NGUYÊN
        // =========================
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
