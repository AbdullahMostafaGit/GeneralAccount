namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CURR3
    {
        public int CODE { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        public double? RATE { get; set; }

        [StringLength(30)]
        public string NAME1 { get; set; }

        public short? UNITS { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public DateTime? RATE_DATE { get; set; }

        [Key]
        public int IDEN { get; set; }

        public int FLAG_TR { get; set; }

        public int? Plan_ID { get; set; }
    }
}
