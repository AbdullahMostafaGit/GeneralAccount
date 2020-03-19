namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NAV")]
    public partial class NAV
    {
        [Column("Nav", TypeName = "numeric")]
        public decimal? Nav1 { get; set; }

        public DateTime? WORK_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Hrms { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EFG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IFCI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PIMA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RelHrms { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RelPIMA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RelIFCI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RelNav { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Relative { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RelEFG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLAG_TR { get; set; }

        [StringLength(50)]
        public string SCHEMEW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IDEN { get; set; }

        public int ID { get; set; }
    }
}
