using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Lab.DAL.Entities;

namespace Lab.BUS
{
    public class DiemDanhService : QLKTXService
    {
        // View Model for Attendance List
        public class AttendanceDTO
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string MaPhong { get; set; }
            public bool CoMat { get; set; }
            public string GhiChu { get; set; }
            public int? MaDiemDanh { get; set; } // Null if not yet marked
        }

        public List<AttendanceDTO> GetAttendanceList(DateTime date, string maPhong)
        {
            // 1. Get all students currently in the room (via PHIEUDK or SINHVIEN mapping)
            // Assuming SINHVIEN.PHIEUDK link to PHONG or just checking active allocation.
            // Let's rely on PHIEUDK to find active students in room.
            // Or simpler: SINHVIEN doesn't have MaPhong directly usually? 
            // Wait, looking at SINHVIEN entity earlier, it has MaLop, MSSV... no MaPhong.
            // PHIEUDK has MaPhong and MSSV.
            
            var studentsInRoom = _context.PHIEUDK
                .Where(p => p.MaPhong == maPhong 
                            && p.NgayBD.HasValue 
                            && p.ThoiHan.HasValue
                            && p.NgayBD <= date 
                            && DbFunctions.AddMonths(p.NgayBD, p.ThoiHan) >= date) 
                .Select(p => p.SINHVIEN)
                .Distinct()
                .ToList();
                
            // Note: PHIEUDK might have multiple entries. We need active ones. 
            // If logic is simpler (SINHVIEN has no direct room), we use PHIEUDK.
            // Let's assume standard logic: Get students who have valid registration for this room.

            // 2. Get existing attendance records for this date
            var attendanceRecords = _context.DIEMDANH
                .Where(d => d.NgayDiemDanh == date)
                .ToList();

            // 3. Merge
            var result = new List<AttendanceDTO>();
            foreach (var sv in studentsInRoom)
            {
                var record = attendanceRecords.FirstOrDefault(r => r.MSSV == sv.MSSV);
                result.Add(new AttendanceDTO
                {
                    MSSV = sv.MSSV,
                    HoTen = sv.HoTen,
                    MaPhong = maPhong,
                    CoMat = record != null ? (record.TrangThai ?? false) : true, // Default to Present (true) if no record
                    GhiChu = record?.GhiChu ?? "",
                    MaDiemDanh = record?.MaDiemDanh
                });
            }
            return result;
        }

        public void SaveAttendance(List<AttendanceDTO> list, DateTime date)
        {
            foreach (var item in list)
            {
                var record = _context.DIEMDANH.FirstOrDefault(d => d.MSSV == item.MSSV && d.NgayDiemDanh == date);
                if (record == null)
                {
                    // New
                    record = new DIEMDANH
                    {
                        MSSV = item.MSSV,
                        NgayDiemDanh = date,
                        TrangThai = item.CoMat,
                        GhiChu = item.GhiChu
                    };
                    _context.DIEMDANH.Add(record);
                }
                else
                {
                    // Update
                    record.TrangThai = item.CoMat;
                    record.GhiChu = item.GhiChu;
                }
            }
            _context.SaveChanges();
        }
        public class CheckInResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public string StudentName { get; set; }
        }

        public CheckInResult CheckInSingle(string mssv, string maPhong, DateTime date)
        {
            // 1. Data Validation
            if (string.IsNullOrEmpty(mssv)) return new CheckInResult { Success = false, Message = "Vui lòng nhập MSSV" };

            // 2. Verify Student belongs to Room & Contract is Valid
            var student = _context.PHIEUDK
                 .Where(p => p.MaPhong == maPhong
                            && p.MSSV == mssv
                            && p.NgayBD.HasValue
                            && p.ThoiHan.HasValue
                            && p.NgayBD <= date
                            && DbFunctions.AddMonths(p.NgayBD, p.ThoiHan) >= date)
                 .Select(p => p.SINHVIEN)
                 .FirstOrDefault();

            if (student == null)
            {
                // Check if student exists at all to give better error
                var svExists = _context.SINHVIEN.Any(s => s.MSSV == mssv);
                if (!svExists) return new CheckInResult { Success = false, Message = "MSSV không tồn tại trong hệ thống" };
                return new CheckInResult { Success = false, Message = $"Sinh viên không thuộc phòng {maPhong} hoặc hết hạn hợp đồng" };
            }

            // 3. Check if already checked in
            var existingRecord = _context.DIEMDANH.FirstOrDefault(d => d.MSSV == mssv && d.NgayDiemDanh == date);
            if (existingRecord != null)
            {
                if (existingRecord.TrangThai == true)
                    return new CheckInResult { Success = true, Message = "Sinh viên đã điểm danh rồi", StudentName = student.HoTen };
                
                // If exists but was False (Absent), update to True
                existingRecord.TrangThai = true;
                existingRecord.GhiChu = "Điểm danh Kiosk";
                _context.SaveChanges();
                return new CheckInResult { Success = true, Message = "Điểm danh thành công!", StudentName = student.HoTen };
            }

            // 4. Create new Record
            var newRecord = new DIEMDANH
            {
                MSSV = mssv,
                NgayDiemDanh = date,
                TrangThai = true,
                GhiChu = "Điểm danh Kiosk"
            };
            _context.DIEMDANH.Add(newRecord);
            _context.SaveChanges();

            return new CheckInResult { Success = true, Message = "Điểm danh thành công!", StudentName = student.HoTen };
        }
    }
}
