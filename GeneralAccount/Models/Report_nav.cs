namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report_nav
    {
        public int? Code { get; set; }

        public int? Report_ID { get; set; }

        [StringLength(10)]
        public string Acc_Code { get; set; }

        public int ID { get; set; }
    }
}
