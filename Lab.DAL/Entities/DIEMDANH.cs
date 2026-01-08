namespace Lab.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEMDANH")]
    public partial class DIEMDANH
    {
        [Key]
        public int MaDiemDanh { get; set; }

        [Required]
        [StringLength(10)]
        public string MSSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDiemDanh { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
