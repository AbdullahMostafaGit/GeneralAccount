namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("company")]
    public partial class company
    {
        public int? code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(40)]
        public string industry { get; set; }

        [StringLength(40)]
        public string sector { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string person { get; set; }

        [StringLength(15)]
        public string tel1 { get; set; }

        [StringLength(15)]
        public string tel2 { get; set; }

        [StringLength(15)]
        public string fax { get; set; }

        public double? capital { get; set; }

        public DateTime? DATE_END { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(15)]
        public string id { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(30)]
        public string BANK_AC { get; set; }

        [StringLength(16)]
        public string ACC_CODE { get; set; }
    }
}
