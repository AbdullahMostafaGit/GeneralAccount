namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EOD_APP_DEP
    {
        [StringLength(10)]
        public string SCHEMEW { get; set; }

        [StringLength(12)]
        public string ACC_NO { get; set; }

        [StringLength(30)]
        public string SECU_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [StringLength(60)]
        public string ACC_DESC { get; set; }

        [Key]
        public int IDEN { get; set; }

        public int FLAG_TR { get; set; }
    }
}
