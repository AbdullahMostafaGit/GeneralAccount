namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC_ALL
    {
        [Key]
        [StringLength(12)]
        public string CODE { get; set; }

        public string NAME { get; set; }

        [StringLength(15)]
        public string BSPL { get; set; }

        [StringLength(15)]
        public string TYPE { get; set; }

        public double? BALANCE { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        public short? level_s { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public string NAME_ARB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal liq_bal { get; set; }

        public string name_eng { get; set; }

        public short LIQ_DR { get; set; }

        public short LIQ_CR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SORTBY { get; set; }

        public int FLAG_TR { get; set; }

        public short FL { get; set; }

        [StringLength(30)]
        public string CURR { get; set; }

        [StringLength(60)]
        public string ACCHEAD { get; set; }

        [StringLength(60)]
        public string ACCTYPE { get; set; }

        [StringLength(50)]
        public string reportname { get; set; }

        public bool CHK_NAV { get; set; }

        [StringLength(30)]
        public string CATE { get; set; }

        public int? bank_flag { get; set; }

        [StringLength(15)]
        public string cs_1 { get; set; }

        [StringLength(15)]
        public string cs_2 { get; set; }

        [StringLength(2)]
        public string drcr { get; set; }

        public int? pr { get; set; }

        [Column("s_type     ", TypeName = "numeric")]
        public decimal s_type_____ { get; set; }

        [StringLength(50)]
        public string Swift_Code { get; set; }

        public string BANK_REUTER_CODE { get; set; }

        public string BANK_CORESPONDENE_NAME { get; set; }

        public string BANK_CORESPONDENE_BIC_CODE_SWIFT { get; set; }

        public string ACCOUNT_NUM_OF_BANK_AT_CORESPONDENE { get; set; }

        public string BANK_INTERMEDIARY_NAME { get; set; }

        public string BANK_INTERMEDIARY_BIC_CODE_SWIFT { get; set; }

        public string ACCOUNT_NUM { get; set; }

        public int? GENERAL_SUB_LEGER_ACC_NUM { get; set; }

        public int? Uid { get; set; }

        public int? Sector { get; set; }

        public int? Refrence { get; set; }
    }
}
