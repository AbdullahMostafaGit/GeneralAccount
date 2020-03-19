namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_CLIENT
    {
        [StringLength(50)]
        public string USERS { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(60)]
        public string NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACT { get; set; }

        [Key]
        public long IDEN { get; set; }
    }
}
