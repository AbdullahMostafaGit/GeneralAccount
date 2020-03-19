namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc2
    {
        [StringLength(12)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string acc1 { get; set; }

        public double? balance { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        [StringLength(50)]
        public string acc1_name { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(50)]
        public string NAME_ARB { get; set; }

        public bool CHK_LIQ { get; set; }

        [StringLength(50)]
        public string name_eng { get; set; }

        public short LIQ_DR { get; set; }

        public short LIQ_CR { get; set; }

        public int FLAG_TR { get; set; }

        public short FL { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [StringLength(60)]
        public string ACCHEAD { get; set; }

        [StringLength(60)]
        public string ACCTYPE { get; set; }

        [StringLength(50)]
        public string reportname { get; set; }

        public bool CHK_NAV { get; set; }

        [StringLength(30)]
        public string CATE { get; set; }

        [StringLength(15)]
        public string cs_1 { get; set; }

        [StringLength(15)]
        public string cs_2 { get; set; }

        [StringLength(2)]
        public string drcr { get; set; }

        [Column("s_type     ", TypeName = "numeric")]
        public decimal s_type_____ { get; set; }

        public int ID { get; set; }
    }
}
