namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coupon")]
    public partial class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(10)]
        public string Schemew { get; set; }

        [StringLength(10)]
        public string Security_Id { get; set; }

        public int? int_day_basis { get; set; }

        public DateTime? nxt_int_date { get; set; }

        public DateTime? prv_int_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string S_type { get; set; }

        public DateTime? Fund_date { get; set; }

        public int? Rec { get; set; }

        public DateTime? Rec_date { get; set; }

        public int? Collect { get; set; }

        public DateTime? Collect_Date { get; set; }

        public int? AutoEod { get; set; }

        [StringLength(10)]
        public string bank_acc { get; set; }
    }
}
