namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MANFEES1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? valuE_DATE { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [StringLength(15)]
        public string tra_type { get; set; }

        public double FEES { get; set; }

        public double FEES_l { get; set; }

        public double exch_rate { get; set; }

        public short? file_code { get; set; }

        public short auth { get; set; }

        [StringLength(15)]
        public string auther { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        public DateTime? FROMDATE { get; set; }

        public DateTime? AsOfDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_AMT { get; set; }

        [StringLength(20)]
        public string CHECK_NO { get; set; }

        [StringLength(12)]
        public string acc_code { get; set; }

        [StringLength(50)]
        public string bank_ac { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(8)]
        public string MAN_PERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }
    }
}
