namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("secub")]
    public partial class secub
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string schemew { get; set; }

        [StringLength(60)]
        public string security { get; set; }

        public float? interest_1 { get; set; }

        public float? int_day_basis { get; set; }

        public DateTime? prv_int_date { get; set; }

        public float? int_day_freq { get; set; }

        public DateTime? next_int_date { get; set; }

        public DateTime? allot_date { get; set; }

        public DateTime? mat_date { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(30)]
        public string ASSET_TYPE { get; set; }

        public int? code { get; set; }

        public int RED_ENDED { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EX_DAYS { get; set; }

        public DateTime? PREVIOUS_COP_DATE { get; set; }

        public DateTime? LAST_TRADE_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal COUNT_BASIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal COUNT_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal REMAIN_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RUNNING_DISCOUNT { get; set; }

        [StringLength(15)]
        public string FREQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CHK_ACT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SECU_TYPE { get; set; }

        [Key]
        public int IDEN { get; set; }

        public float? face_value { get; set; }

        [StringLength(50)]
        public string isin_code { get; set; }

        public DateTime? Issue_date { get; set; }
    }
}
