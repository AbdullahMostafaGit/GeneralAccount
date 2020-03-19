namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string PrfID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Tra_type { get; set; }

        [StringLength(10)]
        public string Schemew { get; set; }

        public int? No_Of_Days { get; set; }

        public int? Option { get; set; }

        public int? Method { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Percentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        public int? inputer { get; set; }

        public int? Auth { get; set; }

        public int? Auther { get; set; }

        public DateTime? Value_Date { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        public int? chk_MinMax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Min_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Max_fees { get; set; }

        public int? mon { get; set; }

        public DateTime? PrvDate { get; set; }

        public DateTime? NxtDate { get; set; }

        public int? Chk_PFees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bench_Prec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Capital_1 { get; set; }

        public int? bench_optin { get; set; }

        public int flag { get; set; }

        public int? fees_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fixed_Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? swift_fees { get; set; }

        [StringLength(50)]
        public string tra_fees { get; set; }

        public int? SecuType { get; set; }

        public int? Curr { get; set; }
    }
}
