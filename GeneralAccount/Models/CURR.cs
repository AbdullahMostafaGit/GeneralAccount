namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURR")]
    public partial class CURR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        public short? UNITS { get; set; }

        public double? RATE { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public DateTime? rate_date { get; set; }

        [StringLength(30)]
        public string NAME_ARB { get; set; }

        public int FLAG_TR { get; set; }

        [Column("CURR")]
        [StringLength(30)]
        public string CURR1 { get; set; }
    }
}
