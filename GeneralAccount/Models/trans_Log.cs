namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trans_Log
    {
        [StringLength(10)]
        public string security_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal book_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal average_cost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? market_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal market_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bookvalue_local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal exchange_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal market_value_local { get; set; }

        public DateTime? value_date { get; set; }

        public DateTime? delivery_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qty_delivered { get; set; }

        [StringLength(3)]
        public string pur_sal { get; set; }

        [StringLength(10)]
        public string deal_ref { get; set; }

        [StringLength(15)]
        public string schemeW { get; set; }

        [StringLength(30)]
        public string tra_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pur_sal_price { get; set; }

        public double PROFIT_LOSS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SELLING_VALUE { get; set; }

        public int code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public DateTime? Log_Date { get; set; }

        [StringLength(50)]
        public string Log_User { get; set; }

        [Key]
        public int Trans_Log_ID { get; set; }

        public int? Trans_Log_Flag { get; set; }
    }
}
