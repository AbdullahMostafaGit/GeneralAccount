namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LIBOR")]
    public partial class LIBOR
    {
        [Key]
        public int IDEN { get; set; }

        [Column("LIBOR")]
        public float? LIBOR1 { get; set; }

        public DateTime? LIBOR_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RATE { get; set; }
    }
}
