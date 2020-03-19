namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECEIVE1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? en_DATE { get; set; }

        public DateTime? valuE_DATE { get; set; }

        [StringLength(60)]
        public string SECURITY { get; set; }

        [StringLength(15)]
        public string SECURITY_ID { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(30)]
        public string secu_type { get; set; }

        [StringLength(30)]
        public string industry { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public double shares_holding { get; set; }

        public double div_per_share { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [StringLength(15)]
        public string tra_type { get; set; }

        public short? let_cust { get; set; }

        public double tot_div { get; set; }

        public double tot_div_loc { get; set; }

        public double exch_rate { get; set; }

        [StringLength(10)]
        public string DEAL_REF { get; set; }

        public double SHARES_AFTER { get; set; }

        public short? file_code { get; set; }

        public short auth { get; set; }

        [StringLength(15)]
        public string auther { get; set; }

        public DateTime? fund_DATE { get; set; }

        [StringLength(10)]
        public string CO_ID { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        public short ended { get; set; }

        [StringLength(10)]
        public string cbo_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OUTSTANDING { get; set; }

        [StringLength(20)]
        public string CHECK_NO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        public DateTime? holding_date { get; set; }

        public int FLAG_TR { get; set; }

        public DateTime? REC_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [Column("TAXAMOUNT     ", TypeName = "numeric")]
        public decimal TAXAMOUNT_____ { get; set; }
    }
}
