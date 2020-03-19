namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class liq_daily
    {
        public DateTime? work_date { get; set; }

        [StringLength(15)]
        public string schemew { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LIQ { get; set; }

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }
    }
}
