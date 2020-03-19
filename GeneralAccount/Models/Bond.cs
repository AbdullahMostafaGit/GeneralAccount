namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bond")]
    public partial class Bond
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [Required]
        [StringLength(10)]
        public string deal_no { get; set; }

        public DateTime? tr_date { get; set; }

        [StringLength(4)]
        public string order_type { get; set; }

        [StringLength(50)]
        public string isin_code { get; set; }

        public int? inv_type { get; set; }

        public int? curr { get; set; }

        public int? days { get; set; }

        [Column(TypeName = "numeric")]
        public decimal invoice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amortization { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YTM { get; set; }

        public int? Quantity { get; set; }

        [StringLength(10)]
        public string cust { get; set; }

        public string narration { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        //[StringLength(10)]
        //public string bank { get; set; }

        [StringLength(10)]
        public string schemew { get; set; }

        [StringLength(50)]
        public string account_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iden { get; set; }

        public int? flag_tr { get; set; }

        [StringLength(50)]
        public string Inputer { get; set; }

        public DateTime? Entry_date { get; set; }

        public short? auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [StringLength(10)]
        public string secu_id { get; set; }

        [StringLength(60)]
        public string secu_name { get; set; }

        [Required]
        [StringLength(50)]
        public string ORDER_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EX_ID { get; set; }

        [StringLength(15)]
        public string ACC_CODE1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public int? TR_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? set_date { get; set; }

        public double? net_value { get; set; }

        public double? clean_price { get; set; }

        public double? acc_int { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? invoice_coupon { get; set; }

        [StringLength(10)]
        public string Tra_Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? face_val { get; set; }

        public int? set_bank { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Coupon_Rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fees { get; set; }

        public int? Days_to_Maturity { get; set; }
    }
}
