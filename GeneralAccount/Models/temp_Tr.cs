namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_Tr
    {
        public bool? w_preview { get; set; }

        public int? report_id { get; set; }

        public int ID { get; set; }
    }
}
