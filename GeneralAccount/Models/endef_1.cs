namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class endef_1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(15)]
        public string schemeW { get; set; }

        [StringLength(30)]
        public string tra_type { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }
    }
}
