namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(50)]
        public string Name_arb { get; set; }
    }
}
