namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SECUB_ADD
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        [StringLength(50)]
        public string SECURITY { get; set; }

        public float? INTEREST_1 { get; set; }

        public float? INT_DAY_BASIS { get; set; }

        public DateTime? PRV_INT_DATE { get; set; }

        public float? INT_DAY_FREQ { get; set; }

        public DateTime? NEXT_INT_DATE { get; set; }

        public DateTime? ALLOT_DATE { get; set; }

        public DateTime? MAT_DATE { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(30)]
        public string ASSET_TYPE { get; set; }

        public int? CODE { get; set; }

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
        public decimal SECU_TYPE { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
