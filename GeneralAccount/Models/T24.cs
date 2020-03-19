namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T24
    {
        public int? NT { get; set; }

        public int? ET { get; set; }

        [StringLength(50)]
        public string C1 { get; set; }

        public int? UL { get; set; }

        public int? SL { get; set; }

        public int ID { get; set; }
    }
}
