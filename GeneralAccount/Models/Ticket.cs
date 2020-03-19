namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [Required]
        [StringLength(10)]
        public string deal_no { get; set; }

        public DateTime? tr_date { get; set; }

        [StringLength(4)]
        public string order_type { get; set; }

        public int? iss_type { get; set; }

        public DateTime? iss_date { get; set; }

        public DateTime? mat_date { get; set; }

        public int days_mat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no_of_unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unit_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? yield { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? face_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presint_val { get; set; }

        public DateTime? set_date { get; set; }

        public int? schemew { get; set; }

        [StringLength(50)]
        public string account_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iden { get; set; }

        public int? flag_tr { get; set; }

        [StringLength(50)]
        public string Inputer { get; set; }

        public DateTime? Entry_date { get; set; }

        public short? auth { get; set; }

        [StringLength(10)]
        public string auther { get; set; }

        [StringLength(10)]
        public string secu_id { get; set; }

        [StringLength(60)]
        public string secu_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORDER_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EX_ID { get; set; }

        [StringLength(15)]
        public string ACC_CODE1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public int? TR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_int { get; set; }

        [StringLength(10)]
        public string Tra_Type { get; set; }

        [StringLength(50)]
        public string isin_code { get; set; }

        [StringLength(50)]
        public string common_ref { get; set; }

        public int? IndentifierKey { get; set; }

        [StringLength(30)]
        public string AccountNo { get; set; }

        public int? Branch { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bank_acc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cust_id { get; set; }

        public int? core_sent { get; set; }

        public int? core_res { get; set; }

        public int? swift_sent { get; set; }

        public int? swift_res { get; set; }

        public int? bal_status { get; set; }

        public int? branch_req { get; set; }

        public int? req_id { get; set; }

        [StringLength(50)]
        public string Swift_generatedtime { get; set; }

        public int? swift_cancel { get; set; }

        [StringLength(50)]
        public string Swift_canceledtime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tot_accrued { get; set; }

        public int? opno { get; set; }

        [StringLength(50)]
        public string busdate { get; set; }

        public DateTime? sysdate { get; set; }
    }
}
