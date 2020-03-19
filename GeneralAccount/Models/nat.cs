namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nat")]
    public partial class nat
    {
        [StringLength(25)]
        public string name { get; set; }

        public int FLAG_TR { get; set; }

        [Key]
        public int code { get; set; }
    }
}
