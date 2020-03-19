namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC_PP
    {
        [Column(TypeName = "numeric")]
        public decimal? code { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string ACC_NO { get; set; }

        [StringLength(3)]
        public string desc_s { get; set; }

        [Key]
        public int flag_s { get; set; }
    }
}
