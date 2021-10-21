namespace CFwithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            DEPTs = new HashSet<DEPT>();
            STUDENT1 = new HashSet<STUDENT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STDID { get; set; }

        public int? STDROLLNO { get; set; }

        [Required]
        [StringLength(75)]
        public string STDNAME { get; set; }

        [StringLength(10)]
        public string STDCLASS { get; set; }

        [StringLength(10)]
        public string STDRESULT { get; set; }

        public int? STDDATE { get; set; }

        public decimal? Amount { get; set; }

        public int? MNGRID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPT> DEPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENT1 { get; set; }

        public virtual STUDENT STUDENT2 { get; set; }
    }
}
