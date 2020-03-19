namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_1997
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
        public decimal? S_TYPE { get; set; }
    }
}
