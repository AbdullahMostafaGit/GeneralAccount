namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class state_1
    {
        [StringLength(50)]
        public string schemeW { get; set; }

        [StringLength(15)]
        public string state { get; set; }

        [StringLength(10)]
        public string serial { get; set; }

        [StringLength(50)]
        public string legend1 { get; set; }

        [StringLength(4)]
        public string st1 { get; set; }

        [StringLength(4)]
        public string gt1 { get; set; }

        [StringLength(4)]
        public string r1 { get; set; }

        [StringLength(12)]
        public string acc_no1 { get; set; }

        [StringLength(12)]
        public string acc_no2 { get; set; }

        [StringLength(50)]
        public string legend2 { get; set; }

        [StringLength(4)]
        public string st2 { get; set; }

        [StringLength(4)]
        public string gt2 { get; set; }

        [StringLength(4)]
        public string r2 { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        public int ID { get; set; }
    }
}
