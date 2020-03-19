namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tra_type
    {
        public int? code { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column("tra_type")]
        [StringLength(30)]
        public string tra_type1 { get; set; }

        [StringLength(30)]
        public string market { get; set; }

        [StringLength(30)]
        public string prefix { get; set; }

        [StringLength(3)]
        public string discounted { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        public short SYS_USER { get; set; }

        public short? EOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public int? acc_ref { get; set; }

        public int? curr { get; set; }

        [StringLength(250)]
        public string narration { get; set; }

        public int? Tra_market { get; set; }

        [Key]
        public int IDPK { get; set; }

        public short? Client_Type { get; set; }
    }
}
