namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbfkacc_all
    {
        public int id { get; set; }

        public int? acc_code { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? client { get; set; }
    }
}
