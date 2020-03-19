namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees_client
    {
        public int id { get; set; }

        public int? ClientID { get; set; }

        public int? FessID { get; set; }
    }
}
