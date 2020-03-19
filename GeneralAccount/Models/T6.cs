namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T6
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C1 { get; set; }

        public bool? VB { get; set; }

        public int? FID { get; set; }

        public int? G1 { get; set; }

        public int? FE { get; set; }

        public int? FD { get; set; }

        [StringLength(50)]
        public string U1 { get; set; }

        public DateTime? SD { get; set; }

        [StringLength(50)]
        public string I1 { get; set; }

        public int? CK0 { get; set; }

        [StringLength(50)]
        public string CK1 { get; set; }

        public int? A0 { get; set; }

        [StringLength(50)]
        public string A1 { get; set; }
    }
}
