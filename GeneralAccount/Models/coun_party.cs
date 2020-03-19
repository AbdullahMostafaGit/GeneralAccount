namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class coun_party
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(15)]
        public string tel1 { get; set; }

        [StringLength(15)]
        public string tel2 { get; set; }

        [StringLength(15)]
        public string fax { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }
    }
}
