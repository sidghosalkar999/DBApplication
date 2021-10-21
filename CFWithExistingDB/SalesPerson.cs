namespace CFWithExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesPerson")]
    public partial class SalesPerson
    {
        public int? Order_Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_Num { get; set; }

        public int? Person_Id { get; set; }
    }
}
