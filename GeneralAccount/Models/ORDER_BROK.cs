namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDER_BROK
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
        public decimal? BROKER_COMM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRICE { get; set; }

        public DateTime? ORDER_DATE { get; set; }

        public DateTime? VALID_DATE { get; set; }

        [StringLength(5)]
        public string COUPON { get; set; }

        [StringLength(3)]
        public string CUMM_INT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOT_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTY_OUTSTANDING { get; set; }

        [Column(TypeName = "text")]
        public string REMARKS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_UPDATED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTY_SET { get; set; }

        [Column(TypeName = "numeric")]
        public decimal rate { get; set; }

        [StringLength(20)]
        public string time_stamp { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        public int FLAG_TR { get; set; }

        [Column("AMOUNT     ", TypeName = "numeric")]
        public decimal AMOUNT_____ { get; set; }

        [Column("BOOK_KEEPING     ", TypeName = "numeric")]
        public decimal BOOK_KEEPING_____ { get; set; }

        [Column("BROKER_FEES     ", TypeName = "numeric")]
        public decimal BROKER_FEES_____ { get; set; }

        [StringLength(5)]
        public string BUY_SELL { get; set; }

        [Column("CLEAR_FEES     ", TypeName = "numeric")]
        public decimal CLEAR_FEES_____ { get; set; }

        [Column("CMA_FEES     ", TypeName = "numeric")]
        public decimal CMA_FEES_____ { get; set; }

        [StringLength(5)]
        public string CURR_CODE { get; set; }

        [StringLength(20)]
        public string CUSTODIAN { get; set; }

        public int? F_Add { get; set; }

        public int? F_Auth { get; set; }

        [Column("INS_FEES     ", TypeName = "numeric")]
        public decimal INS_FEES_____ { get; set; }

        [StringLength(50)]
        public string INVOICE_NO { get; set; }

        [StringLength(25)]
        public string ISIN_CODE { get; set; }

        [Column("QUANTITY_DISK     ", TypeName = "numeric")]
        public decimal QUANTITY_DISK_____ { get; set; }

        [Column("STAMP_FEES     ", TypeName = "numeric")]
        public decimal STAMP_FEES_____ { get; set; }

        [Column("STOCK_FEES     ", TypeName = "numeric")]
        public decimal STOCK_FEES_____ { get; set; }

        public int? TR_ID { get; set; }

        [StringLength(25)]
        public string UNI_CODE { get; set; }

        public DateTime? VALUE_date { get; set; }

        public int? IndentifierKey { get; set; }
    }
}
