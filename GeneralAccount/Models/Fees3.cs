namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees3
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Tra_type { get; set; }

        [StringLength(10)]
        public string Schemew { get; set; }

        public int? No_Of_Days { get; set; }

        public int? Option { get; set; }

        public int? Method { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Percentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        public int? inputer { get; set; }

        public int? Auth { get; set; }

        public int? Auther { get; set; }

        public DateTime? Value_Date { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
