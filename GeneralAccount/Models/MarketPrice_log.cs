
namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MarketPrice_log
    {
        [Key]
        public int code { get; set; }

        [StringLength(50)]
        public string inputer { get; set; }

        public DateTime? closing_date { get; set; }

        public int? security_id { get; set; }

        public double? price_before { get; set; }

        public double? price_after { get; set; }

        public DateTime? entry_date { get; set; }
    }
}
