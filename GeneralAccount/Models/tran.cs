namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tran
    {
        [StringLength(30)]
        public string secu_type { get; set; }

        [StringLength(10)]
        public string security_id { get; set; }

        [StringLength(60)]
        public string security { get; set; }

        [Column(TypeName = "numeric")]
        public decimal quantity { get; set; }

        public float per_from_all { get; set; }

        [Column(TypeName = "numeric")]
        public decimal book_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal average_cost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? market_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal market_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bookvalue_local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal exchange_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal market_value_local { get; set; }

        public double apprec_deprec { get; set; }

        [StringLength(30)]
        public string curr { get; set; }

        [StringLength(60)]
        public string broker { get; set; }

        [StringLength(15)]
        public string dip_dis_no { get; set; }

        [StringLength(10)]
        public string invoice_no { get; set; }

        public DateTime? value_date { get; set; }

        public DateTime? delivery_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qty_delivered { get; set; }

        public float out_qty { get; set; }

        public float out_amt { get; set; }

        [StringLength(15)]
        public string receipt_id { get; set; }

        public int? pur_sal { get; set; }

        [StringLength(30)]
        public string industry { get; set; }

        [StringLength(10)]
        public string deal_ref { get; set; }

        public int? schemeW { get; set; }

        [StringLength(30)]
        public string tra_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pur_sal_price { get; set; }

        public double PROFIT_LOSS { get; set; }

        public short file_code { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(15)]
        public string co_id { get; set; }

        public short auth { get; set; }

        [StringLength(15)]
        public string auther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SELLING_VALUE { get; set; }

        [StringLength(10)]
        public string CUSTODIAN { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public DateTime? set_date { get; set; }

        public int? TR_ID { get; set; }

        [StringLength(50)]
        public string symbol { get; set; }

        public int? invest_Type { get; set; }

        public int? set_flag { get; set; }

        public short? tra_type_id { get; set; }

        public int? core_sent { get; set; }

        public int? core_res { get; set; }

        public int? swift_sent { get; set; }

        public int? swift_res { get; set; }

        public int? IndentifierKey { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_Int { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tax_Amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fees_amt { get; set; }
    }
}
