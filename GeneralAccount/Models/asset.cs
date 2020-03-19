namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asset")]
    public partial class asset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short code { get; set; }

        [StringLength(40)]
        public string name { get; set; }

        [Column("short")]
        [StringLength(20)]
        public string _short { get; set; }

        [StringLength(2)]
        public string instrument { get; set; }

        [StringLength(2)]
        public string interest { get; set; }

        [StringLength(2)]
        public string redem { get; set; }

        [StringLength(2)]
        public string divid { get; set; }

        [StringLength(2)]
        public string bonus { get; set; }

        [StringLength(2)]
        public string rights { get; set; }

        [StringLength(2)]
        public string zero_rate { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? auth { get; set; }

        [StringLength(12)]
        public string acc_code { get; set; }

        [StringLength(12)]
        public string acc_code_un { get; set; }

        [StringLength(2)]
        public string VAR_RATE { get; set; }

        [StringLength(2)]
        public string COUPON { get; set; }

        [StringLength(40)]
        public string NAME_ARB { get; set; }

        public int FLAG_TR { get; set; }

        public short PRICE_FLAG { get; set; }

        public short PER_FLAG { get; set; }

        public short REQUIRE_FLAG { get; set; }

        [StringLength(40)]
        public string ASSET_TYPE { get; set; }

        [StringLength(40)]
        public string ACC_CODE_INT { get; set; }

        public short? RPT_FLAG { get; set; }

        public short? ACT_AUTO { get; set; }

        [StringLength(2)]
        public string discounted { get; set; }

        public short? DIS_DEAL { get; set; }

        public int? INT_DAY_BASIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TAX { get; set; }

        [StringLength(40)]
        public string TAX_CODE { get; set; }

        public DateTime? TAX_DATE { get; set; }

        [StringLength(50)]
        public string acc_int_Pl { get; set; }

        public int? acc_int_unreal { get; set; }

        [StringLength(50)]
        public string Acc_real_pl { get; set; }

        [StringLength(50)]
        public string account_coupon { get; set; }

        [StringLength(50)]
        public string coupon_acc { get; set; }

        [StringLength(2)]
        public string HOLD_STOCKS { get; set; }

        public int? Inv_Allocate { get; set; }

        [StringLength(50)]
        public string Loss_acc { get; set; }

        [StringLength(2)]
        public string M_TO_M { get; set; }

        public int? mtm { get; set; }

        public int? Pro_ID { get; set; }

        [StringLength(50)]
        public string Prof_acc { get; set; }

        public int? pur_sal { get; set; }

        public int? sel_sal { get; set; }

        public int? Tax_pre { get; set; }

        public int? Show_On_Liq { get; set; }

        public int? pl_tax { get; set; }

        public int? flag { get; set; }

        [StringLength(40)]
        public string acc_income { get; set; }

        [Column("SAA Weight")]
        public double? SAA_Weight { get; set; }
    }
}
