namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Freeze")]
    public partial class Freeze
    {
        [Key]
        public int Code { get; set; }

        public int Schemew { get; set; }

        [Required]
        [StringLength(20)]
        public string Isin_Code { get; set; }

        [Required]
        [StringLength(10)]
        public string Security_ID { get; set; }

        public short Pur_Sal { get; set; }

        [Column(TypeName = "date")]
        public DateTime Value_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime entry_Date { get; set; }

        public int qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Amt { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public short Auth { get; set; }

        public int inputer { get; set; }

        public int Auther { get; set; }

        [Required]
        [StringLength(200)]
        public string security { get; set; }
    }
}
