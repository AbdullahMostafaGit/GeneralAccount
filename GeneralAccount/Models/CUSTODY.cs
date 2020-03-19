namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTODY")]
    public partial class CUSTODY
    {
        [StringLength(10)]
        public string SCHEMEW { get; set; }

        [StringLength(10)]
        public string SECURITY_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTY_REC { get; set; }

        [StringLength(20)]
        public string CUST_ID { get; set; }

        [Key]
        public int IDEN { get; set; }

        public int FLAG_TR { get; set; }
    }
}
