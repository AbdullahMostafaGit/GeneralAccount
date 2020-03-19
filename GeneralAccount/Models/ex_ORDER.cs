namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ex_ORDER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(10)]
        public string schemew { get; set; }

        [StringLength(60)]
        public string SECURITY { get; set; }

        [StringLength(10)]
        public string SECURITY_ID { get; set; }

        [StringLength(10)]
        public string ORDER_ID { get; set; }

        [StringLength(10)]
        public string ref_ORDER_ID { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(12)]
        public string ORDER_TYPE { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [StringLength(60)]
        public string BROKER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BROKER_COMM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ex_QUANTITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PRICE { get; set; }

        public DateTime? ORDER_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOT_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTY_OUTSTANDING { get; set; }

        [Column(TypeName = "text")]
        public string REMARKS { get; set; }

        public DateTime? ex_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tot_amt_L { get; set; }

        public float rate_1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTY_SET { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT_ORDER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT_EX { get; set; }

        public int FLAG_TR { get; set; }

        public int? F_Add { get; set; }

        public int? F_Auth { get; set; }

        public int? TR_ID { get; set; }

        public int? IndentifierKey { get; set; }
    }
}
