namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATE")]
    public partial class CATE
    {
        public int CODE { get; set; }

        [StringLength(250)]
        public string NAME { get; set; }

        public bool AUTH { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(250)]
        public string Name_Arb { get; set; }

        public int ID { get; set; }
    }
}
