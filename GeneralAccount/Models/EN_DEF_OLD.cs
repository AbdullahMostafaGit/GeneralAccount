namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EN_DEF_OLD
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

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }
    }
}
