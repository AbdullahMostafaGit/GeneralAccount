namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dea_1997
    {
        [StringLength(30)]
        public string secu_type { get; set; }

        [StringLength(10)]
        public string security_id { get; set; }

        [StringLength(60)]
        public string security { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? average_cost { get; set; }

        [StringLength(30)]
        public string curr { get; set; }

        [StringLength(60)]
        public string broker { get; set; }

        [StringLength(15)]
        public string dip_dis_no { get; set; }

        [StringLength(50)]
        public string invoice_no { get; set; }

        public DateTime? value_date { get; set; }

        public DateTime? delivery_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qty_delivered { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? out_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? out_amt { get; set; }

        [StringLength(15)]
        public string receipt_id { get; set; }

        [StringLength(3)]
        public string pur_sal { get; set; }

        [StringLength(30)]
        public string industry { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(15)]
        public string schemeW { get; set; }

        [StringLength(30)]
        public string tra_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pur_sal_price { get; set; }

        [StringLength(20)]
        public string man_ref { get; set; }

        [StringLength(50)]
        public string custodian { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? custodian_charges { get; set; }

        [StringLength(10)]
        public string cum_int { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? broker_comm_Per { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tot_inv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? broker_comm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_charges { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? clear_comm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? net_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? int_days { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? accruD_int { get; set; }

        public DateTime? mat_date { get; set; }

        [StringLength(60)]
        public string desc_1 { get; set; }

        public short? file_code { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tot_inv_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? broker_comm_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stamp_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_charges_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? clear_comm_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? net_value_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? exch_rate { get; set; }

        [StringLength(50)]
        public string tra_ch { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? profit_loss { get; set; }

        [StringLength(12)]
        public string broker_acc { get; set; }

        public DateTime? FUND_DATE { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [StringLength(10)]
        public string co_id { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        public short? ended { get; set; }

        public short? PAY_ENDED { get; set; }

        [StringLength(10)]
        public string deal_ref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BKEEPING { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BKEEPING_l { get; set; }

        [StringLength(10)]
        public string ORDER_BROK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AVG_PRICE_ORDER { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DAILY_INT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public DateTime? set_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_fees_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cma { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cma_l { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TAX_AMOUNT { get; set; }

        public int? F_Add { get; set; }

        public int? F_Auth { get; set; }

        [Column("SPONSOR_FEES     ", TypeName = "numeric")]
        public decimal SPONSOR_FEES_____ { get; set; }

        public int? TR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pl_tax_amount { get; set; }

        public int? pl_tax_flag { get; set; }

        public int? IndentifierKey { get; set; }
    }
}
