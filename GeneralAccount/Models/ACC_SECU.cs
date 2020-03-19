namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC_SECU
    {
        public int? CODE { get; set; }

        public int? SCHEMEW { get; set; }

        [Column("ACC_SECU")]
        public int? ACC_SECU1 { get; set; }

        [Key]
        public int IDEN { get; set; }
    }
}
