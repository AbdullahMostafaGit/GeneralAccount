namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EOD_Logtrans
    {
        [StringLength(50)]
        public string schemew { get; set; }

        [StringLength(50)]
        public string security_id { get; set; }

        public int count { get; set; }

        public DateTime? entry_date { get; set; }

        public DateTime? FUND_DATE { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        public int ID { get; set; }
    }
}
