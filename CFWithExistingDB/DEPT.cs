namespace CFWithExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPT")]
    public partial class DEPT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEPTID { get; set; }

        [Required]
        [StringLength(75)]
        public string DEPTNAME { get; set; }

        public int? SID { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
