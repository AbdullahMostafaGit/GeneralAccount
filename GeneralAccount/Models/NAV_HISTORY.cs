namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NAV_HISTORY
    {
        public DateTime? DOC_DATE { get; set; }

        public int? DOC_PRICE { get; set; }

        [Key]
        public int IDEN { get; set; }

        public int FLAG_TR { get; set; }
    }
}
