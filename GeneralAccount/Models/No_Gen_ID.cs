namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class No_Gen_ID
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LastNo { get; set; }
    }
}
