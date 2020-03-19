namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TALKON")]
    public partial class TALKON
    {
        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(15)]
        public string SCHEMEW { get; set; }

        public DateTime? tra_date { get; set; }

        [Key]
        public int IDEN { get; set; }

        [StringLength(15)]
        public string SECURITY_ID { get; set; }

        public int CODE { get; set; }
    }
}
