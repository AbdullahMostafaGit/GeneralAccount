namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("psecu")]
    public partial class psecu
    {
        [StringLength(10)]
        public string deal_no { get; set; }

        public DateTime? tr_date { get; set; }

        [StringLength(30)]
        public string order_type { get; set; }

        [StringLength(30)]
        public string iss_type { get; set; }

        public DateTime? iss_date { get; set; }

        public DateTime? mat_date { get; set; }

        public int? days_mat { get; set; }

        public int? no_of_unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unit_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? yield { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? face_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presint_val { get; set; }

        public DateTime? set_date { get; set; }

        public int? schemew { get; set; }

        [StringLength(50)]
        public string account_1 { get; set; }

        public int? secu_id { get; set; }

        [StringLength(50)]
        public string secu_name { get; set; }

        public int ID { get; set; }
    }
}
