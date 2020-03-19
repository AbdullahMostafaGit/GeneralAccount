namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_max1
    {
        public int? code { get; set; }

        public int? schemew { get; set; }

        [StringLength(50)]
        public string acc_no { get; set; }

        [StringLength(50)]
        public string acc_desc { get; set; }

        [Key]
        public int iden { get; set; }
    }
}
