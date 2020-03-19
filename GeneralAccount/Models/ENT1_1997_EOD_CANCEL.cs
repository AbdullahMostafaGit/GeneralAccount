namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENT1_1997_EOD_CANCEL
    {
        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? FUND_DATE { get; set; }

        [StringLength(50)]
        public string ACCOUNT_1 { get; set; }

        [StringLength(50)]
        public string ACCOUNT_2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOCAL_AMT { get; set; }

        public float? RATE_1 { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(500)]
        public string DESC_1 { get; set; }

        [StringLength(15)]
        public string CHECK_NO { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(30)]
        public string TRA_TYPE { get; set; }

        [StringLength(12)]
        public string ACC_CODE { get; set; }

        [StringLength(2)]
        public string ACC_STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT_3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOCAL_AMT1 { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string serial { get; set; }

        public int? CODE { get; set; }

        [StringLength(50)]
        public string ACC_DESC { get; set; }

        [StringLength(16)]
        public string ACC_DR { get; set; }

        [StringLength(16)]
        public string ACC_CR { get; set; }

        public short? file_code { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? auth { get; set; }

        public short RPT { get; set; }

        [Key]
        public int iden { get; set; }

        public short LIQ_DR { get; set; }

        public short LIQ_CR { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(10)]
        public string SECURITY_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public int? TR_ID { get; set; }
    }
}
