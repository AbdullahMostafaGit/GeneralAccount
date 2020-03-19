namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbillrate")]
    public partial class tbillrate
    {
        public int code { get; set; }

        public DateTime? value_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal rate { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(30)]
        public string inputer { get; set; }

        [Key]
        public int iden { get; set; }

        public int flag_tr { get; set; }

        public int bench_code { get; set; }
    }
}
