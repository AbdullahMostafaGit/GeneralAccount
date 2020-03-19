namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CODLog")]
    public partial class CODLog
    {
        public int id { get; set; }

        [StringLength(10)]
        public string Schemew { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [StringLength(10)]
        public string inputer { get; set; }

        public DateTime? EntryDate { get; set; }
    }
}
