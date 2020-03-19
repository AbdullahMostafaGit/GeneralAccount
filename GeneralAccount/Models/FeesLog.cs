namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeesLog")]
    public partial class FeesLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Security_id { get; set; }

        public int? Schemew { get; set; }

        public DateTime? Value_date { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        public DateTime? System_Date { get; set; }

        public int? No_Of_Days { get; set; }

        public int? Flag { get; set; }
    }
}
