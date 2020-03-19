namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("custSetup")]
    public partial class custSetup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(15)]
        public string tel1 { get; set; }

        [StringLength(15)]
        public string tel2 { get; set; }

        [StringLength(15)]
        public string fax1 { get; set; }

        [StringLength(30)]
        public string tra_ch { get; set; }

        [StringLength(30)]
        public string nav_ch { get; set; }

        [Required]
        [StringLength(3)]
        public string nav_frq { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [Column(TypeName = "text")]
        public string REMARKS { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(20)]
        public string ID_BROK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fixed_flat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? percentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? m_min { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? m_max { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Swift_FixedFlat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Swift_percentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Swift_Min { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Swift_Max { get; set; }

        public int? Secu_Type { get; set; }

        public int? Curr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PercTxt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Swift_PercTxt { get; set; }

        public int? AccNo { get; set; }

        [StringLength(50)]
        public string Mail1 { get; set; }

        [StringLength(50)]
        public string Mail2 { get; set; }

        [StringLength(50)]
        public string Contact_Name_1 { get; set; }

        [StringLength(50)]
        public string Contact_Name_2 { get; set; }

        [StringLength(50)]
        public string engname { get; set; }
    }
}
