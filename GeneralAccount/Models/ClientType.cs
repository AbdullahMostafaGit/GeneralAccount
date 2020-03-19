namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientType")]
    public partial class ClientType
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string ClientType_Name { get; set; }
    }
}
