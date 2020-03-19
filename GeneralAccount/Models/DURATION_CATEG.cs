namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DURATION_CATEG
    {
        [Column(TypeName = "numeric")]
        public decimal? CODE { get; set; }

        [StringLength(30)]
        public string CATEG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Current_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Market_rate { get; set; }

        [Key]
        public int IDEN { get; set; }
    }
}
