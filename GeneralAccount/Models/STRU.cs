namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STRU")]
    public partial class STRU
    {
        [Key]
        public int IDEN { get; set; }

        public int? CODE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal YEAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIBOR { get; set; }
    }
}
