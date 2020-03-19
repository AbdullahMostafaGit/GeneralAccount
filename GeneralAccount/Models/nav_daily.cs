namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nav_daily
    {
        public DateTime? work_date { get; set; }

        [StringLength(15)]
        public string schemew { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nav { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? no_of_cert { get; set; }

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bench_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bench_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? net_capital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Balance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weighted_Balance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? P_L { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Benchmark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit_Over_Benchmark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pref_Fess { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Nav_Fees { get; set; }
    }
}
