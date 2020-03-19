namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("secu")]
    public partial class secu
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(30)]
        public string asset_type { get; set; }

        [StringLength(30)]
        public string currency { get; set; }

        [StringLength(2)]
        public string discounted { get; set; }

        [StringLength(30)]
        public string exch { get; set; }

        [StringLength(2)]
        public string group_s { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? face_value { get; set; }

        public float? interest { get; set; }

        public float? interest_1 { get; set; }

        public float? int_day_basis { get; set; }

        public DateTime? prv_int_date { get; set; }

        public float? int_day_freq { get; set; }

        public DateTime? next_int_date { get; set; }

        public DateTime? allot_date { get; set; }

        public DateTime? mat_date { get; set; }

        public float? YIELD { get; set; }

        public float? YIELD_MAT { get; set; }

        public double? MARKET_PRICE { get; set; }

        public DateTime? MP_AS_ON { get; set; }

        public double? APP_AMT { get; set; }

        public double? ALLOT_AMT { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int? code { get; set; }

        [StringLength(200)]
        public string security { get; set; }

        [StringLength(200)]
        public string CO_ID { get; set; }

        public double? price { get; set; }

        public DateTime? secu_date { get; set; }

        public short MAT_ENDED { get; set; }

        [StringLength(4)]
        public string coupon { get; set; }

        [StringLength(50)]
        public string NAME_ARB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NO_OF_SHARES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BONUS_RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SPLIT_RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DIV_RATE { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(30)]
        public string reuter_code { get; set; }

        [Required]
        [StringLength(3)]
        public string secu_liq { get; set; }

        public bool price_flag { get; set; }

        public bool per_flag { get; set; }

        public bool RPT_FLAG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FIX_PRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal group_flag { get; set; }

        [StringLength(60)]
        public string group_name { get; set; }

        [StringLength(15)]
        public string TELE_CODE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SECU_TYPE { get; set; }

        [StringLength(20)]
        public string isin_code { get; set; }

        public short taxable { get; set; }

        [Column("egx20     ", TypeName = "numeric")]
        public decimal egx20_____ { get; set; }

        [Column("egx30     ", TypeName = "numeric")]
        public decimal? egx30_____ { get; set; }

        public int? industry { get; set; }

        [StringLength(35)]
        public string NAME1 { get; set; }

        [Column("tax_rate     ", TypeName = "numeric")]
        public decimal tax_rate_____ { get; set; }

        public int? gics_id { get; set; }
    }
}
