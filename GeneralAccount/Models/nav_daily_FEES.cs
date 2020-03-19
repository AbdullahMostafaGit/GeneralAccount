namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nav_daily_FEES
    {
        public DateTime? WORK_DATE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NAV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MARK_FEES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MANG_FEES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CUST_FEES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? secu_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? admin_fees { get; set; }

        [Key]
        public int IDEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal service_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal adv_fees { get; set; }
    }
}
