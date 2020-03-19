namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_num
    {
        public int? code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? flag { get; set; }

        public int ID { get; set; }
    }
}
