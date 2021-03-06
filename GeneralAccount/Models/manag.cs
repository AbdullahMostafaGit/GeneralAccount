namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("manag")]
    public partial class manag
    {
        public int code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(30)]
        public string city { get; set; }

        [StringLength(30)]
        public string country { get; set; }

        [StringLength(15)]
        public string tel1 { get; set; }

        [StringLength(15)]
        public string tel2 { get; set; }

        [StringLength(15)]
        public string fax1 { get; set; }

        public DateTime? contract_date { get; set; }

        public float? fixed_fees { get; set; }

        public float? perf_fees { get; set; }

        [StringLength(50)]
        public string contact { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        public int ID { get; set; }
    }
}
