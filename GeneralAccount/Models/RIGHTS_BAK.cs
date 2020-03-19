namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RIGHTS_BAK
    {
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string id { get; set; }

        [StringLength(50)]
        public string DESC_S { get; set; }

        public short? level_S { get; set; }

        [StringLength(50)]
        public string form_menu { get; set; }

        [StringLength(50)]
        public string form_name { get; set; }

        [StringLength(50)]
        public string menu_name { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(50)]
        public string INPUTER { get; set; }

        public int iden { get; set; }

        [StringLength(50)]
        public string USER_TYPE { get; set; }

        public int FLAG_TR { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
