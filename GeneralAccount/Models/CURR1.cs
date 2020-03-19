namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CURR1
    {
        public int? CODE { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        public short? UNITS { get; set; }

        public double? RATE { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public DateTime? rate_date { get; set; }

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(30)]
        public string NAME1 { get; set; }

        public int? Plan_ID { get; set; }
    }
}
