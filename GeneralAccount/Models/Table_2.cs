namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_2
    {
        [StringLength(10)]
        public string id { get; set; }

        public DateTime? prv_int_date { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
