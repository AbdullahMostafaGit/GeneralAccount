namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EOD_Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? Value_Date { get; set; }

        public int? Schemew { get; set; }

        public int? Total { get; set; }

        public int? IsTax { get; set; }

        public int? S_type { get; set; }

        public DateTime? entry_date { get; set; }

        public int? inputer { get; set; }
    }
}
