namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class adj_cost
    {
        [StringLength(30)]
        public string secu_type { get; set; }

        [StringLength(10)]
        public string security_id { get; set; }

        [StringLength(60)]
        public string security { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? book_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? average_cost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? market_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? market_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bookvalue_local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXCHANGE_RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? market_value_local { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [StringLength(60)]
        public string broker { get; set; }

        public DateTime? value_date { get; set; }

        public DateTime? DELIVERY_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PUR_SAL_PRICE { get; set; }

        [StringLength(30)]
        public string INDUSTRY { get; set; }

        [StringLength(3)]
        public string pur_sal { get; set; }

        [StringLength(10)]
        public string deal_ref { get; set; }

        [StringLength(30)]
        public string tra_type { get; set; }

        public short? file_code { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(15)]
        public string co_id { get; set; }

        public short? auth { get; set; }

        [StringLength(15)]
        public string auther { get; set; }

        [StringLength(15)]
        public string schemeW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SELLING_value { get; set; }

        public int? code { get; set; }

        public int ID { get; set; }
    }
}
