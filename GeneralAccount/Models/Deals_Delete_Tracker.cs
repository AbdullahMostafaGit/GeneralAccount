namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deals_Delete_Tracker
    {
        [Key]
        public int Code { get; set; }

        [StringLength(50)]
        public string Transation_ID { get; set; }

        [StringLength(10)]
        public string Inputer { get; set; }

        public DateTime? Date { get; set; }
    }
}
