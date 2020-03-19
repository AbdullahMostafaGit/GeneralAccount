namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("temp")]
    public partial class temp
    {
        public bool? w_add { get; set; }

        public bool? w_update { get; set; }

        public bool? w_delete { get; set; }

        public bool? checker { get; set; }

        public bool? auther { get; set; }

        public bool? nonebtn { get; set; }

        public int? form_id { get; set; }

        [Column("readonly")]
        public bool? _readonly { get; set; }

        public bool? ForceSave { get; set; }

        public bool? w_auth { get; set; }

        public bool? w_unauth { get; set; }

        public int ID { get; set; }
    }
}
