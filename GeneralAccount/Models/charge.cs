namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("charge")]
    public partial class charge
    {
        public int code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(30)]
        public string id { get; set; }

        public double? p1 { get; set; }

        public double? p2 { get; set; }

        public double? p3 { get; set; }

        public float? p4 { get; set; }

        public double? amt1 { get; set; }

        public double? amt2 { get; set; }

        public double? amt3 { get; set; }

        public double? amt4 { get; set; }

        public double? rest { get; set; }

        public double? rest_am1 { get; set; }

        public double? min_fee { get; set; }

        public double? max_fee { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }
    }
}
