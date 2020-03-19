namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_max
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(50)]
        public string bank { get; set; }

        public int? max_limit { get; set; }

        public int? schemew { get; set; }

        public int? flag_tr { get; set; }
    }
}
