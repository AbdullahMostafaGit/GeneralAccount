namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("brokerSetup")]
    public partial class brokerSetup
    {
        public int code { get; set; }

        [StringLength(40)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(15)]
        public string tel1 { get; set; }

        [StringLength(15)]
        public string tel2 { get; set; }

        [StringLength(15)]
        public string fax { get; set; }

        [StringLength(30)]
        public string stock { get; set; }

        public double? capital { get; set; }

        [Column(TypeName = "text")]
        public string remarks { get; set; }

        [StringLength(50)]
        public string acc_desc { get; set; }

        [StringLength(12)]
        public string acc_code { get; set; }

        public DateTime? entry_date { get; set; }

        [StringLength(10)]
        public string INPUTER { get; set; }

        [StringLength(15)]
        public string id { get; set; }

        [StringLength(12)]
        public string acc_code1 { get; set; }

        [StringLength(50)]
        public string acc_desc1 { get; set; }

        [StringLength(50)]
        public string acc_desc2 { get; set; }

        [StringLength(12)]
        public string acc_code2 { get; set; }

        [StringLength(50)]
        public string acc_desc3 { get; set; }

        [StringLength(12)]
        public string acc_code3 { get; set; }

        [StringLength(50)]
        public string acct { get; set; }

        [StringLength(50)]
        public string trader { get; set; }

        [StringLength(50)]
        public string floor { get; set; }

        [StringLength(50)]
        public string research { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(15)]
        public string phone1 { get; set; }

        [StringLength(15)]
        public string phone2 { get; set; }

        [StringLength(15)]
        public string phone3 { get; set; }

        [StringLength(15)]
        public string hot { get; set; }

        [StringLength(15)]
        public string hot1 { get; set; }

        [StringLength(15)]
        public string hot2 { get; set; }

        [StringLength(15)]
        public string hot3 { get; set; }

        [StringLength(15)]
        public string mobil { get; set; }

        [StringLength(15)]
        public string mobil1 { get; set; }

        [StringLength(15)]
        public string mobil2 { get; set; }

        [StringLength(15)]
        public string mobil3 { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(30)]
        public string email1 { get; set; }

        [StringLength(30)]
        public string email2 { get; set; }

        [StringLength(30)]
        public string email3 { get; set; }

        public int FLAG_TR { get; set; }

        public short? AMT { get; set; }

        public short? book_keep { get; set; }

        public short? Brok_Fees { get; set; }

        public short? clear { get; set; }

        public short? client_code { get; set; }

        public short? CMA { get; set; }

        public short? curr_code { get; set; }

        public short? Cust { get; set; }

        public short? Insurance { get; set; }

        public short? Inv_NO { get; set; }

        public short? isin_code { get; set; }

        public int? news { get; set; }

        public short? QTY { get; set; }

        public short? stamp { get; set; }

        public short? stock_fees { get; set; }

        public short? trans_type { get; set; }

        public short? Uni_Code { get; set; }

        public short? value_dte { get; set; }

        [StringLength(50)]
        public string Swift { get; set; }

        public int? AccNo { get; set; }

        [StringLength(50)]
        public string Bank_Name { get; set; }

        [StringLength(50)]
        public string Bank_Swift { get; set; }

        public int? Leger_AccNo { get; set; }

        public int? CO_Transaction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Percentage_Trans { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? min_Trans { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? max_Trans { get; set; }

        public int? CO_Swift { get; set; }

        public int? Percentage_Swift { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? min_Swift { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? max_Swift { get; set; }

        [StringLength(50)]
        public string CounterParty_Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fixed_Trans { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fixed_Swift { get; set; }

        public int? FP_Transaction { get; set; }

        public int? FP_Swift { get; set; }

        [StringLength(50)]
        public string BrokerName { get; set; }

        [StringLength(50)]
        public string SwiftCode { get; set; }

        [StringLength(50)]
        public string ACCOUNT_NUM { get; set; }

        public int? Large_AccNo { get; set; }

        public double? rin { get; set; }

        [StringLength(50)]
        public string Mail1 { get; set; }

        [StringLength(50)]
        public string Mail2 { get; set; }

        [StringLength(50)]
        public string Contact_Name_1 { get; set; }

        [StringLength(50)]
        public string Contact_Name_2 { get; set; }
    }
}
