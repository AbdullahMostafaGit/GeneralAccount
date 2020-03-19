namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees_Calc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        public int? Fees_Id { get; set; }

        [StringLength(50)]
        public string Schemew { get; set; }

        public DateTime? Value_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Nav { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fees_Amount { get; set; }
    }
}
