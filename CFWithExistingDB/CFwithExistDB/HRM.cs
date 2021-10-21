namespace CFwithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HRMS")]
    public partial class HRM
    {
        public int? EMPID { get; set; }

        public long? EMPPHONENO { get; set; }

        [Key]
        [StringLength(75)]
        public string EMPNAME { get; set; }

        public int? EMPSALARY { get; set; }

        [StringLength(10)]
        public string EMPROLE { get; set; }

        [StringLength(10)]
        public string EMPADDR { get; set; }

        [StringLength(75)]
        public string EMAILID { get; set; }
    }
}
