namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C1 { get; set; }

        [StringLength(50)]
        public string CS1 { get; set; }

        [StringLength(50)]
        public string N1 { get; set; }

        public DateTime? ED { get; set; }

        public int? G1 { get; set; }

        public int? P1 { get; set; }

        public DateTime? CD { get; set; }

        public int? FE { get; set; }

        public int? FD { get; set; }

        [StringLength(50)]
        public string PS1 { get; set; }

        public int? L1 { get; set; }

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

        [StringLength(50)]
        public string EM { get; set; }

        [StringLength(500)]
        public string LR { get; set; }

        public int? Prv { get; set; }

        public int? Prv_Jornal { get; set; }

        public int? branch { get; set; }

        public int? CHK_admin { get; set; }
    }
}
