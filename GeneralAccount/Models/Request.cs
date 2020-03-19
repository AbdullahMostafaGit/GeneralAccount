namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        public int RequestID { get; set; }

        public int? client_ID { get; set; }

        [StringLength(50)]
        public string Acc_No { get; set; }

        public int? Tra_Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Issue_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Settlement_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Yield { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Face_Value { get; set; }

        [StringLength(50)]
        public string Sector_Name { get; set; }

        [StringLength(50)]
        public string Branch { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Maturity_date { get; set; }

        [StringLength(50)]
        public string Term { get; set; }

        public int? Request_type { get; set; }

        public int? Flag { get; set; }

        public int? auth { get; set; }

        public int? Branch_stl { get; set; }

        [StringLength(50)]
        public string Sub_Gl { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Purchase_Settlement_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Purchase_Yield { get; set; }

        [StringLength(50)]
        public string secu_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }
    }
}
