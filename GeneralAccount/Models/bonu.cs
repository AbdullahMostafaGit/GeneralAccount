namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bonu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

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

        public double shares_bonus { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [StringLength(15)]
        public string tra_type { get; set; }

        [StringLength(1)]
        public string let_cust { get; set; }

        [StringLength(10)]
        public string CO_ID { get; set; }

        [StringLength(10)]
        public string custodian { get; set; }

        [StringLength(50)]
        public string TRA_DESC { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        public DateTime? fund_date { get; set; }

        public short ended { get; set; }

        public DateTime? HOLDING_DATE { get; set; }

        public int FLAG_TR { get; set; }
    }
}
