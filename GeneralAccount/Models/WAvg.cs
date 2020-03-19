namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WAvg")]
    public partial class WAvg
    {
        public DateTime? First_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Starting_Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        public DateTime? Second_Date { get; set; }

        public int? No_Of_Days { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit_Loss { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Per { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weighted { get; set; }

        [StringLength(60)]
        public string Schemew { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tot { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Nav { get; set; }

        public int Flag_Tr { get; set; }

        public int ID { get; set; }
    }
}
