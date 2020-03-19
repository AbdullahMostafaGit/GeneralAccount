namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REMINDER")]
    public partial class REMINDER
    {
        public int? CODE { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string NAME_ARB { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(50)]
        public string INPUTER { get; set; }

        public int? FLAG_TR { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [Key]
        public int IDEN { get; set; }
    }
}
