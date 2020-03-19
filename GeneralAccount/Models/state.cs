namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("state")]
    public partial class state
    {
        public int? code { get; set; }

        [StringLength(10)]
        public string schemeW { get; set; }

        [Column("state")]
        [StringLength(15)]
        public string state1 { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        public int ID { get; set; }
    }
}
