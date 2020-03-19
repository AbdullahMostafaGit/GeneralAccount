namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENT1_Entry
    {
        [Key]
        [Column(Order = 0)]
        public int IDEN { get; set; }

        public string Name_DRCR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Tra_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DRCR { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string Branch { get; set; }

        [StringLength(6)]
        public string GL { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string Sub_Gl { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(9)]
        public string ACC_NO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string Sub_NO { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string Curr { get; set; }

        [Column("ref")]
        public string _ref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT_3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOCAL_AMT1 { get; set; }

        public int? serial { get; set; }

        public int? core_sent { get; set; }

        public int? core_res { get; set; }

        public int? swift_sent { get; set; }

        public int? swift_res { get; set; }

        public int? Narration_Code { get; set; }

        public string Refrence { get; set; }

        [StringLength(16)]
        public string acc_fund { get; set; }
    }
}
