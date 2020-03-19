namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientSlip
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TransCode { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(60)]
        public string SchemewId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string Security { get; set; }

        public DateTime TransDate { get; set; }

        [StringLength(10)]
        public string Inputer { get; set; }

        public int Flag_Tr { get; set; }
    }
}
