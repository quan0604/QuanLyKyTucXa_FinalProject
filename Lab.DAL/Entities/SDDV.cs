namespace Lab.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDDV")]
    public partial class SDDV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDV { get; set; }

        public int? SoLuong { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
