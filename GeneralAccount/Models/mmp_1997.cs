namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mmp_1997
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
        public decimal int_amt { get; set; }

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

        [StringLength(10)]
        public string m_deal_no { get; set; }

        public DateTime? prem_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal act_int_rec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal local_int_rec { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [StringLength(50)]
        public string tra_desc { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DEP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
