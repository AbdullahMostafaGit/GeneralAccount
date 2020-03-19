namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trans_history
    {
        public int id { get; set; }

        public int schemw { get; set; }

        public int secu_id { get; set; }

        public DateTime prev_date { get; set; }

        public DateTime next_date { get; set; }

        public int int_day_freq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal interest { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal face_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total_amount { get; set; }
    }
}
