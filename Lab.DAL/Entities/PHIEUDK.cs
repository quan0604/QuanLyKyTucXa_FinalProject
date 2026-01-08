namespace Lab.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDK")]
    public partial class PHIEUDK
    {
        [Key]
        [StringLength(10)]
        public string MaPDK { get; set; }

        [StringLength(10)]
        public string MSSV { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        public int? HocKy { get; set; }

        [StringLength(20)]
        public string NamHoc { get; set; }

        public DateTime? NgayGioDK { get; set; }

        public int? ThoiHan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
