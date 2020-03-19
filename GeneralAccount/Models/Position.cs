namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C1 { get; set; }

        [StringLength(50)]
        public string N1 { get; set; }
    }
}
