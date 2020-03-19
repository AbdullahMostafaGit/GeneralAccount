namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mmd_1997
    {
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? FUND_DATE { get; set; }

        [StringLength(50)]
        public string ACCOUNT_1 { get; set; }

        [StringLength(50)]
        public string ACCOUNT_2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AMOUNT { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LOCAL_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RATE_1 { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(50)]
        public string DESC_1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal int_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no_of_days { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(1)]
        public string rev { get; set; }

        public DateTime? rev_date { get; set; }

        [StringLength(10)]
        public string acc_code1 { get; set; }

        [StringLength(10)]
        public string acc_code2 { get; set; }

        [StringLength(15)]
        public string tra_type { get; set; }

        [StringLength(50)]
        public string ACC_DESC { get; set; }

        public short? file_code { get; set; }

        public DateTime? mat_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? int_amt { get; set; }

        [StringLength(15)]
        public string AMO_FREQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal local_int_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EX_INST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EX_AMT { get; set; }

        public DateTime? LAST_EX_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AMT_DIFF { get; set; }

        [StringLength(50)]
        public string coun_party { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(2)]
        public string basis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal day_basis { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AMT_POSTED { get; set; }

        [StringLength(50)]
        public string tra_desc { get; set; }

        public short dep_ended { get; set; }

        public short FLAG_S { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DEP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [StringLength(2)]
        public string VAR_RATE { get; set; }

        public short LIBOR { get; set; }

        [StringLength(2)]
        public string COUPON { get; set; }

        public DateTime? PREV_INT_DATE { get; set; }

        [StringLength(50)]
        public string FREQ { get; set; }

        public DateTime? NEXT_INT_DATE { get; set; }

        public int? G_EOD { get; set; }

        [Key]
        public int IDPK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? int_amt_Freq_CD { get; set; }

        public int? int_days_Freq_CD { get; set; }
    }
}
