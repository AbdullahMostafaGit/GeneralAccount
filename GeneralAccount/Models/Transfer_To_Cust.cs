namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transfer_To_Cust
    {
        public int id { get; set; }

        public int Schemew_Id { get; set; }

        public int? Security_id { get; set; }

        public int Cust { get; set; }

        public int Quantity { get; set; }

        public DateTime? date { get; set; }

        public int flag { get; set; }

        public int transaction_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime value_date { get; set; }

        public int inputer { get; set; }
    }
}
