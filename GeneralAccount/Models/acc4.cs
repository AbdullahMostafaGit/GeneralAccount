namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc4
    {
        [StringLength(12)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string acc1 { get; set; }

        [StringLength(50)]
        public string acc1_name { get; set; }

        [StringLength(10)]
        public string acc2 { get; set; }

        [StringLength(50)]
        public string acc2_name { get; set; }

        [StringLength(10)]
        public string acc3 { get; set; }

        [StringLength(50)]
        public string acc3_name { get; set; }

        public double? balance { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal test4 { get; set; }

        public int ID { get; set; }
    }
}
