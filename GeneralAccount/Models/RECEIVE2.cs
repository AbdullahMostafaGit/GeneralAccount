namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECEIVE2
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

        [StringLength(10)]
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

        [StringLength(10)]
        public string custodian { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [StringLength(15)]
        public string tra_type { get; set; }

        [StringLength(60)]
        public string bank_ac { get; set; }

        public double tot_div { get; set; }

        public double tot_div_loc { get; set; }

        public double exch_rate { get; set; }

        [StringLength(10)]
        public string DEAL_REF { get; set; }

        [StringLength(20)]
        public string acc_code { get; set; }

        public short? file_code { get; set; }

        [StringLength(10)]
        public string tra_ch { get; set; }

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

        [StringLength(20)]
        public string CHECK_NO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        [Column("TAXAMOUNT     ", TypeName = "numeric")]
        public decimal TAXAMOUNT_____ { get; set; }
    }
}
