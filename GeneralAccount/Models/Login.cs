namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        public int C1 { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(50)]
        public string MAC { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string PCName { get; set; }
    }
}
