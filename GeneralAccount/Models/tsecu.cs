namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tsecu")]
    public partial class tsecu
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(30)]
        public string asset_type { get; set; }

        [StringLength(30)]
        public string currency { get; set; }

        [StringLength(30)]
        public string discounted { get; set; }

        [StringLength(30)]
        public string exch { get; set; }

        [StringLength(2)]
        public string group_s { get; set; }

        public float? face_value { get; set; }

        public float? interest { get; set; }

        public float? interest_1 { get; set; }

        public float? int_day_basis { get; set; }

        public DateTime? prv_int_date { get; set; }

        public float? int_day_freq { get; set; }

        public DateTime? next_int_date { get; set; }

        public DateTime? allot_date { get; set; }

        public DateTime? mat_date { get; set; }

        public float? yield { get; set; }

        public float? yield_mat { get; set; }

        public float? market_price { get; set; }

        public DateTime? mp_as_on { get; set; }

        public float? app_amt { get; set; }

        public float? allot_amt { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string inputer { get; set; }

        public int? code { get; set; }

        [StringLength(60)]
        public string security { get; set; }

        [StringLength(10)]
        public string co_id { get; set; }

        public float? price { get; set; }

        public DateTime? secu_date { get; set; }

        public short? mat_ended { get; set; }

        [StringLength(10)]
        public string coupon { get; set; }

        [StringLength(10)]
        public string name_arb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? no_of_shares { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bonus_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? split_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? div_rate { get; set; }

        public int? flag_tr { get; set; }

        [StringLength(30)]
        public string reuter_code { get; set; }

        [StringLength(10)]
        public string secu_liq { get; set; }

        public bool? price_flag { get; set; }

        public bool? per_flag { get; set; }

        public bool? rpt_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fix_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? group_flag { get; set; }

        [StringLength(30)]
        public string group_name { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
