namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cust_fees_secu
    {
        [Required]
        [StringLength(15)]
        public string schemew { get; set; }

        [Column(TypeName = "numeric")]
        public decimal s_type { get; set; }

        [Key]
        public int IDEN { get; set; }
    }
}
