namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASSET_CLASS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public bool AUTH { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(50)]
        public string NAME_ARB { get; set; }
    }
}
