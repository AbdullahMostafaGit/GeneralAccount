namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SECU_strat_PLANS
    {
        public int code { get; set; }

        [StringLength(50)]
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

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(40)]
        public string ASSET_TYPE { get; set; }

        [StringLength(40)]
        public string SECTOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SECTOR_TOT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ASSET_TOT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTY_SHARES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal act_amount { get; set; }

        public double market_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? est_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal act_shares { get; set; }

        [StringLength(20)]
        public string PLAN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACT_AMOUNT_LOCAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EXCHANGE_RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AMOUNT_ASSET_LOCAL { get; set; }

        [StringLength(30)]
        public string CURRENCY { get; set; }

        public int FLAG_TR { get; set; }
    }
}
