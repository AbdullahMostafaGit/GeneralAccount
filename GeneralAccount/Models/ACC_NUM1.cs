namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC_NUM1
    {
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public int? FLAG { get; set; }

        public int? CODE_1 { get; set; }

        public int ID { get; set; }
    }
}
