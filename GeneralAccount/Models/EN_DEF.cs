namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EN_DEF
    {
        public int? SERIAL { get; set; }

        [StringLength(16)]
        public string AC_DEBIT { get; set; }

        [StringLength(16)]
        public string AC_CREDIT { get; set; }

        [StringLength(40)]
        public string AC_DESC { get; set; }

        [StringLength(10)]
        public string DBCR { get; set; }

        [StringLength(50)]
        public string NARRATION { get; set; }

        [StringLength(20)]
        public string schemeW { get; set; }

        [StringLength(50)]
        public string tra_type { get; set; }

        [Column("ref")]
        [StringLength(20)]
        public string _ref { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? RPT { get; set; }

        [Key]
        public int iden { get; set; }

        public short LIQ_DR { get; set; }

        public short LIQ_CR { get; set; }

        public short BIC { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal S_TYPE { get; set; }

        public int? acc_ref { get; set; }

        public short? core_flag { get; set; }
    }
}
