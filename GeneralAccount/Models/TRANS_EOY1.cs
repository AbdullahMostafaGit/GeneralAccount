namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANS_EOY1
    {
        [StringLength(30)]
        public string secu_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? book_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bookvalue_local { get; set; }

        [StringLength(15)]
        public string schemeW { get; set; }

        [StringLength(12)]
        public string ACC_CODE { get; set; }

        [Key]
        public int IDEN { get; set; }
    }
}
