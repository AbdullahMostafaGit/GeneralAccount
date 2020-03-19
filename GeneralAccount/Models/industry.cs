namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("industry")]
    public partial class industry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public bool? auth { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(100)]
        public string name_arb { get; set; }

        public int FLAG_TR { get; set; }

        public int? NAME1 { get; set; }

        [StringLength(50)]
        public string swift_no { get; set; }
    }
}
