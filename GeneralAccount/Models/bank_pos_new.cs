namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_pos_new
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(255)]
        public string SORT { get; set; }

        [StringLength(255)]
        public string CURENCY { get; set; }

        [StringLength(255)]
        public string MARKET { get; set; }

        [StringLength(50)]
        public string Seller { get; set; }

        [StringLength(255)]
        public string isin_code { get; set; }

        public double? sector { get; set; }

        public DateTime? issue_Date { get; set; }

        public double? yield { get; set; }

        public DateTime? Purchase_Date { get; set; }

        public DateTime? Due_Date { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        public double? PRICE_Purchase { get; set; }

        public double? PV_Purchase { get; set; }

        public double? premium_discount { get; set; }

        public double? num_of_days { get; set; }

        public double? accrued_interest_per_day { get; set; }

        public double? Realized_interst_till_today { get; set; }

        public double? UnRealized_interst { get; set; }

        public double? Present_value_today { get; set; }

        public double? HOLDING_BANK { get; set; }

        public double? Branch { get; set; }

        public double? GL { get; set; }

        public double? ID { get; set; }

        public double? SubNO { get; set; }

        public int? IndentifierKey { get; set; }

        [StringLength(50)]
        public string Tra_Type { get; set; }
    }
}
