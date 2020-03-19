namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T25
    {
        public int? c1 { get; set; }

        public int? LU { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Rn { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
