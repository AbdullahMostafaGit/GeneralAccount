namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorLog")]
    public partial class ErrorLog
    {
        public long ID { get; set; }

        public int? UserId { get; set; }

        public int? ScreenID { get; set; }

        [StringLength(50)]
        public string ErrorCode { get; set; }

        [StringLength(500)]
        public string ErrorDescription { get; set; }

        public DateTime? LogDate { get; set; }

        [StringLength(500)]
        public string Parameters { get; set; }
    }
}
