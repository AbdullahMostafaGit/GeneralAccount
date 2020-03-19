namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usermain")]
    public partial class usermain
    {
        [StringLength(20)]
        public string name { get; set; }

        [StringLength(40)]
        public string lastin { get; set; }

        [StringLength(40)]
        public string lastout { get; set; }

        public DateTime? datecreated { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? level_s { get; set; }

        [StringLength(60)]
        public string desc_s { get; set; }

        public short? USER_ONOFF { get; set; }

        [Key]
        public int IDEN { get; set; }

        [StringLength(30)]
        public string USER_TYPE { get; set; }

        public DateTime? date_till { get; set; }

        public short suspended { get; set; }

        public short deleted { get; set; }

        public short expired { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(30)]
        public string nt_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flag_count { get; set; }

        public bool? locked { get; set; }

        [StringLength(20)]
        public string password1 { get; set; }
    }
}
