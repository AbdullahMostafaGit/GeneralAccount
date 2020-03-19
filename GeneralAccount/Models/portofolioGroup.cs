namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("portofolioGroup")]
    public partial class portofolioGroup
    {
        [Key]
        public int C1 { get; set; }

        public int? PC1 { get; set; }

        public int? GC1 { get; set; }

        public int? FE { get; set; }

        public int? FD { get; set; }

        public int? U1 { get; set; }

        public DateTime? SD { get; set; }

        public int? CK0 { get; set; }

        [StringLength(50)]
        public string CK1 { get; set; }

        public int? A0 { get; set; }

        [StringLength(50)]
        public string A1 { get; set; }

        [StringLength(50)]
        public string I1 { get; set; }
    }
}
