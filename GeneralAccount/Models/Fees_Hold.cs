namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees_Hold
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        public int? Fees_ID { get; set; }

        public int? S_type { get; set; }

        public int? inputer { get; set; }

        public int? Auth { get; set; }

        public int? Auther { get; set; }
    }
}
