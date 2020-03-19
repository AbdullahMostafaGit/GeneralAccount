namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("redemp")]
    public partial class redemp
    {
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOCAL_AMT { get; set; }

        public double? RATE_1 { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(50)]
        public string DESC_1 { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(15)]
        public string TRA_TYPE { get; set; }

        public short? FILE_CODE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short AUTH { get; set; }

        [StringLength(10)]
        public string AUTHER { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? quantity { get; set; }

        [StringLength(50)]
        public string ACCOUNT_1 { get; set; }

        [StringLength(12)]
        public string acc_code1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ic_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal red_fee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fee_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fee_amt_local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(60)]
        public string marketing { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
