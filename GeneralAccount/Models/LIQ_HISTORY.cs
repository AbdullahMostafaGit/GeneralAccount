namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIQ_HISTORY
    {
        [StringLength(16)]
        public string ACC_NO { get; set; }

        [StringLength(60)]
        public string ACC_DESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BALANCE { get; set; }

        [StringLength(10)]
        public string SCHEMEW { get; set; }

        public DateTime? DATE_BAL { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LINE_OR { get; set; }

        [StringLength(3)]
        public string DESC_1 { get; set; }

        [Key]
        public int IDEN { get; set; }

        public int FLAG_TR { get; set; }
    }
}
