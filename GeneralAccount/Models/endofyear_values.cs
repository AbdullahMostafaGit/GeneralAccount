namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class endofyear_values
    {
        [StringLength(10)]
        public string schemew { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nav { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(50)]
        public string inputer { get; set; }

        [Key]
        public int iden { get; set; }

        public DateTime? M_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BASE_AMOUNT { get; set; }
    }
}
