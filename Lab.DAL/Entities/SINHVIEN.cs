namespace Lab.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            NGUOITHAN = new HashSet<NGUOITHAN>();
            PHIEUDK = new HashSet<PHIEUDK>();
        }

        [Key]
        [StringLength(10)]
        public string MSSV { get; set; }

        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string Phai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgSinh { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(200)]
        public string QueQuan { get; set; }

        [StringLength(50)]
        public string DienSV { get; set; }

        [StringLength(20)]
        public string BHYT { get; set; }

        public byte[] AnhChanDung { get; set; }

        public virtual LOP LOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOITHAN> NGUOITHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDK> PHIEUDK { get; set; }
    }
}
