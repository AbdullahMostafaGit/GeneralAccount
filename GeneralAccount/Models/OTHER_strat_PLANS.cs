namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OTHER_strat_PLANS
    {
        public int code { get; set; }

        [StringLength(40)]
        public string name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal per_from_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amount_asset { get; set; }

        [StringLength(10)]
        public string schemew { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [Key]
        public int iden { get; set; }

        [StringLength(40)]
        public string asset_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EST_PRICE { get; set; }

        [StringLength(20)]
        public string PLAN_ID { get; set; }

        public int FLAG_TR { get; set; }
    }
}
