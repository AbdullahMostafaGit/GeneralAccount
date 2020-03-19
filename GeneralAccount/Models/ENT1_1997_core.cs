namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENT1_1997_core
    {
        public int? SCHEMEW { get; set; }

        public DateTime? FUND_DATE { get; set; }

        public float? RATE_1 { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        [StringLength(500)]
        public string DESC_1 { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(30)]
        public string TRA_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT_3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOCAL_AMT1 { get; set; }

        [StringLength(30)]
        public string ID { get; set; }

        [StringLength(10)]
        public string serial { get; set; }

        public int? CODE { get; set; }

        [StringLength(50)]
        public string ACC_DESC { get; set; }

        public int? DRCR { get; set; }

        [StringLength(3)]
        public string Branch { get; set; }

        [StringLength(6)]
        public string GL { get; set; }

        [StringLength(9)]
        public string Sub_Gl { get; set; }

        [StringLength(9)]
        public string ACC_NO { get; set; }

        [StringLength(2)]
        public string Sub_NO { get; set; }

        [StringLength(2)]
        public string curr { get; set; }

        public short? file_code { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        public short? auth { get; set; }

        public short RPT { get; set; }

        [Key]
        public int iden { get; set; }

        public int FLAG_TR { get; set; }

        [StringLength(20)]
        public string SECURITY_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_TYPE { get; set; }

        public int? TR_ID { get; set; }

        public short? tra_type_id { get; set; }

        public short? pur_sal { get; set; }

        public int? core_sent { get; set; }

        public int? core_res { get; set; }

        public int? swift_sent { get; set; }

        public int? swift_res { get; set; }

        public int? IndentifierKey { get; set; }

        public int? narration_code { get; set; }

        public int? iden_entry { get; set; }

        public int? group_id { get; set; }

        [StringLength(16)]
        public string acc_fund { get; set; }

        public int? opno { get; set; }

        [StringLength(50)]
        public string Refrence { get; set; }

        [StringLength(10)]
        public string del_rev { get; set; }

        public DateTime? busdate { get; set; }

        public int? jou_currency { get; set; }
    }
}
