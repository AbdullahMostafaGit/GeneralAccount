namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AMO_1997
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? FUND_DATE { get; set; }

        [StringLength(50)]
        public string ACCOUNT_1 { get; set; }

        [StringLength(50)]
        public string ACCOUNT_2 { get; set; }

        public double? AMOUNT { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        public double? LOCAL_AMT { get; set; }

        public float? RATE_1 { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(50)]
        public string DESC_1 { get; set; }

        [StringLength(15)]
        public string CHECK_NO { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

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

        public DateTime? START_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        [StringLength(15)]
        public string AMO_FREQ { get; set; }

        public float? NO_INST { get; set; }

        public double? INST_AMT { get; set; }

        public float? EX_INST { get; set; }

        public double? EX_AMT { get; set; }

        public DateTime? LAST_EX_DATE { get; set; }

        public float? AMT_DIFF { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        public double? AMT_POSTED { get; set; }

        public float? REST_INST { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        public int FLAG_TR { get; set; }

        public bool CHK_ACT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [StringLength(15)]
        public string security_id { get; set; }

        public int Frequency { get; set; }
    }
}
