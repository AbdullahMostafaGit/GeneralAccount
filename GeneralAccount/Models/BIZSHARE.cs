namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIZSHARE")]
    public partial class BIZSHARE
    {
        public DateTime? SYSTEMDATE { get; set; }

        [StringLength(4)]
        public string CURR_YEAR { get; set; }

        [StringLength(30)]
        public string curr { get; set; }

        public float? broker_comm { get; set; }

        public float? stamp { get; set; }

        [StringLength(50)]
        public string curr_diff { get; set; }

        [StringLength(12)]
        public string curr_diff_code { get; set; }

        public short? no_of_connection { get; set; }

        [StringLength(30)]
        public string dbpath { get; set; }

        public int FLAG_TR { get; set; }

        public DateTime? LIQ_DATE { get; set; }

        [StringLength(255)]
        public string ExeclSheetPath { get; set; }

        [StringLength(50)]
        public string SheetName { get; set; }

        public int pass_days { get; set; }

        [StringLength(20)]
        public string EXCEL_VER { get; set; }

        public bool? chk_bill { get; set; }

        public int ID { get; set; }
    }
}
