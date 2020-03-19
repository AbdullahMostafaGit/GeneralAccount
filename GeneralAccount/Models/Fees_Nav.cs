namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees_Nav
    {
        public int? Code { get; set; }

        public int? Fees_ID { get; set; }

        [StringLength(50)]
        public string Acc_Code { get; set; }

        [StringLength(50)]
        public string inputer { get; set; }

        public int? Auth { get; set; }

        [StringLength(50)]
        public string Auther { get; set; }

        public int ID { get; set; }
    }
}
