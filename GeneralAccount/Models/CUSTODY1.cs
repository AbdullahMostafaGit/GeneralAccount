namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUSTODY1
    {
        [StringLength(50)]
        public string SCHEMEW { get; set; }

        [StringLength(50)]
        public string SECURITY_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTY_REC { get; set; }

        [StringLength(50)]
        public string CUST_ID { get; set; }

        public int? CODE { get; set; }

        public int ID { get; set; }
    }
}
