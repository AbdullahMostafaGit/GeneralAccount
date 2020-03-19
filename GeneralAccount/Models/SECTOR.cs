namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECTOR")]
    public partial class SECTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        public bool AUTH { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(50)]
        public string name_ARB { get; set; }
    }
}
