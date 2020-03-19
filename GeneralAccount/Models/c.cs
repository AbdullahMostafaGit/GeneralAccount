namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cs")]
    public partial class c
    {
        public int code { get; set; }

        [StringLength(15)]
        public string cs_1 { get; set; }

        [StringLength(15)]
        public string cs_2 { get; set; }

        [StringLength(20)]
        public string Desc_s { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flag_s { get; set; }

        public int ID { get; set; }
    }
}
