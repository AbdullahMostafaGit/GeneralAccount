namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adjust_Security_Cost
    {
        public int secu_id { get; set; }

        public int file_code { get; set; }

        public DateTime? value_date { get; set; }

        public decimal new_face_value { get; set; }

        public decimal face_value { get; set; }

        [Required]
        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string schemew { get; set; }

        [Key]
        public int code { get; set; }
    }
}
