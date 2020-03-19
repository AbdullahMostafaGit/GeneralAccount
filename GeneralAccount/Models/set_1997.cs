namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class set_1997
    {
        [StringLength(30)]
        public string secu_type { get; set; }

        [StringLength(10)]
        public string security_id { get; set; }

        [StringLength(70)]
        public string security { get; set; }

        public double? quantity { get; set; }

        [StringLength(30)]
        public string curr { get; set; }

        [StringLength(60)]
        public string broker { get; set; }

        [StringLength(15)]
        public string dip_dis_no { get; set; }

        [StringLength(50)]
        public string invoice_no { get; set; }

        public DateTime? value_date { get; set; }

        public DateTime? contract_date { get; set; }

        public double? qty_rec { get; set; }

        public double? bal_qty_due { get; set; }

        public double? amt_due { get; set; }

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

        public double? pur_sal_price { get; set; }

        [StringLength(50)]
        public string custodian { get; set; }

        public double? amt_due_l { get; set; }

        public double? bal_due { get; set; }

        public double? bal_due_l { get; set; }

        public double? amt_bepaid { get; set; }

        public double? amt_bepaid_l { get; set; }

        public short? file_code { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        public float? exch_rate { get; set; }

        [StringLength(12)]
        public string broker_acc { get; set; }

        public DateTime? FUND_DATE { get; set; }

        [StringLength(30)]
        public string bank_ac { get; set; }

        [StringLength(16)]
        public string acc_code { get; set; }

        public float? rate_1 { get; set; }

        public float? rate_2 { get; set; }

        public float? rate_3 { get; set; }

        [StringLength(10)]
        public string DEAL_REF { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [StringLength(16)]
        public string check_no { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        public short dea_red { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TAX_AMOUNT { get; set; }

        public int? F_Add { get; set; }

        public int? F_Auth { get; set; }

        public int? TR_ID { get; set; }
    }
}
