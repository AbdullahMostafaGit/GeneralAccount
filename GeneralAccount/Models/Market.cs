namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Market")]
    public partial class Market
    {
        [StringLength(10)]
        public string Security_ID { get; set; }

        [StringLength(60)]
        public string Security { get; set; }

        public double? price { get; set; }

        public DateTime? price_date { get; set; }

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }

        public double? CAPTURED_PRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TEMP_CODE { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(50)]
        public string inputer { get; set; }
    }
}
