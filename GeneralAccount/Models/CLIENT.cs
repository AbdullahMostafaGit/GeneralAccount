namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTS")]
    public partial class CLIENT
    {
        public int? CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(60)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string NAT { get; set; }

        [StringLength(12)]
        public string HOME_1 { get; set; }

        [StringLength(12)]
        public string HOME_2 { get; set; }

        [Required]
        [StringLength(12)]
        public string HOME_3 { get; set; }

        [StringLength(12)]
        public string FAX_1 { get; set; }

        [StringLength(12)]
        public string FAX_2 { get; set; }

        [StringLength(12)]
        public string FAX_3 { get; set; }

        [StringLength(12)]
        public string WORK_1 { get; set; }

        [StringLength(12)]
        public string WORK_2 { get; set; }

        [StringLength(12)]
        public string WORK_3 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_DATE { get; set; }

        [StringLength(10)]
        public string PORT_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CAPITAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CAPITAL_SHARE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERF_FEES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MANG_FEES { get; set; }

        [StringLength(60)]
        public string NAME_1 { get; set; }

        [StringLength(60)]
        public string NAME_2 { get; set; }

        [StringLength(60)]
        public string NAME_3 { get; set; }

        [StringLength(60)]
        public string NAME_4 { get; set; }

        [StringLength(10)]
        public string ID_1 { get; set; }

        [StringLength(10)]
        public string ID_2 { get; set; }

        [StringLength(10)]
        public string ID_3 { get; set; }

        [StringLength(10)]
        public string ID_4 { get; set; }

        [StringLength(60)]
        public string ADDRESS_1 { get; set; }

        [StringLength(60)]
        public string ADDRESS_2 { get; set; }

        [StringLength(60)]
        public string MAIL_1 { get; set; }

        [StringLength(60)]
        public string MAIL_2 { get; set; }

        [StringLength(60)]
        public string MAIL_3 { get; set; }

        [StringLength(60)]
        public string MAIL_4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OPEN_BAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_OPERAT { get; set; }

        [StringLength(60)]
        public string NAME_ARB { get; set; }

        [StringLength(60)]
        public string POSIT { get; set; }

        [StringLength(30)]
        public string ID_DESC { get; set; }

        [StringLength(15)]
        public string ID_NO { get; set; }

        [StringLength(30)]
        public string ISSUE_FROM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ID_DATE { get; set; }

        [StringLength(9)]
        public string ACC_CODE { get; set; }

        [StringLength(60)]
        public string ACC_DESC { get; set; }

        [StringLength(60)]
        public string BANK_1 { get; set; }

        [StringLength(60)]
        public string BANK_2 { get; set; }

        [StringLength(15)]
        public string LE_1 { get; set; }

        [StringLength(15)]
        public string LE_2 { get; set; }

        [StringLength(15)]
        public string US_1 { get; set; }

        [StringLength(15)]
        public string US_2 { get; set; }

        [StringLength(15)]
        public string INPUTER { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OPEN_BAL_T { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_OPERAT_T { get; set; }

        [Column(TypeName = "numeric")]
        public decimal APP_DEP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NAV { get; set; }

        [StringLength(20)]
        public string strat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal residual { get; set; }

        public DateTime? SYSTEMDATE { get; set; }

        [StringLength(50)]
        public string title_arb { get; set; }

        [StringLength(50)]
        public string mail_1e { get; set; }

        [StringLength(50)]
        public string mail_2e { get; set; }

        [StringLength(50)]
        public string mail_3e { get; set; }

        [StringLength(50)]
        public string mail_4E { get; set; }

        [StringLength(50)]
        public string KIND_ARB { get; set; }

        [StringLength(30)]
        public string KIND { get; set; }

        public int FLAG_TR { get; set; }

        [Key]
        public int IDPK { get; set; }
    }
}
