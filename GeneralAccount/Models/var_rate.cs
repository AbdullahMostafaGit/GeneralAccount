namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class var_rate
    {
        [StringLength(15)]
        public string schemew { get; set; }

        [StringLength(50)]
        public string Trans_id { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [Column("Var_rate", TypeName = "numeric")]
        public decimal Var_rate1 { get; set; }

        [Key]
        public int iden { get; set; }
    }
}
