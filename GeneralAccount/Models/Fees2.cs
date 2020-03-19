namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees2
    {
        [StringLength(128)]
        public string TABLE_CATALOG { get; set; }

        [StringLength(128)]
        public string TABLE_SCHEMA { get; set; }

        [Required]
        [StringLength(128)]
        public string TABLE_NAME { get; set; }

        [StringLength(10)]
        public string TABLE_TYPE { get; set; }

        public int ID { get; set; }
    }
}
