namespace Lab.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            SINHVIEN = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(10)]
        public string MaLop { get; set; }

        [StringLength(50)]
        public string KhoaHoc { get; set; }

        [StringLength(100)]
        public string KhoaQL { get; set; }

        [StringLength(100)]
        public string Nganh { get; set; }

        public int? SiSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIEN { get; set; }
    }
}
