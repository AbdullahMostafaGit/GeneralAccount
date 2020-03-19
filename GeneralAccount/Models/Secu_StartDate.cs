namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Secu_StartDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(10)]
        public string Schemew { get; set; }

        [StringLength(10)]
        public string Security_id { get; set; }

        public DateTime? Start_date { get; set; }
    }
}
