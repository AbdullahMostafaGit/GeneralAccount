namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActivityLog")]
    public partial class UserActivityLog
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? FlagName { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(500)]
        public string schemew { get; set; }

        [StringLength(10)]
        public string username { get; set; }

        [StringLength(200)]
        public string clientname { get; set; }
    }
}
