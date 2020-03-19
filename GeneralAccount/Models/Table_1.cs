namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [StringLength(150)]
        public string Test { get; set; }

        public int ID { get; set; }
    }
}
