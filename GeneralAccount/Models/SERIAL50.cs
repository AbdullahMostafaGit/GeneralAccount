namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERIAL50
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERIAL { get; set; }

        public int FLAG_TR { get; set; }
    }
}
