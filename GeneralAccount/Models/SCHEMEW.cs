namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHEMEW")]
    public partial class SCHEMEW
    {
        public int? CODE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(250)]
        public string NAME { get; set; }

        [StringLength(25)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string NAT { get; set; }

        [StringLength(12)]
        public string HOME_1 { get; set; }

        [StringLength(12)]
        public string HOME_2 { get; set; }

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

        public DateTime? START_DATE { get; set; }

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

        [StringLength(250)]
        public string NAME_ARB { get; set; }

        [StringLength(60)]
        public string POSIT { get; set; }

        [StringLength(30)]
        public string ID_DESC { get; set; }

        [StringLength(15)]
        public string ID_NO { get; set; }

        [StringLength(30)]
        public string ISSUE_FROM { get; set; }

        public DateTime? ID_DATE { get; set; }

        [StringLength(60)]
        public string ACC_CODE { get; set; }

        [StringLength(60)]
        public string ACC_DESC { get; set; }

        [StringLength(60)]
        public string BANK_1 { get; set; }

        [StringLength(60)]
        public string BANK_2 { get; set; }

        [StringLength(20)]
        public string LE_1 { get; set; }

        [StringLength(20)]
        public string LE_2 { get; set; }

        [StringLength(20)]
        public string US_1 { get; set; }

        [StringLength(20)]
        public string US_2 { get; set; }

        [StringLength(20)]
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

        [StringLength(60)]
        public string title_arb { get; set; }

        [StringLength(60)]
        public string mail_1e { get; set; }

        [StringLength(60)]
        public string mail_2e { get; set; }

        [StringLength(60)]
        public string mail_3e { get; set; }

        [StringLength(60)]
        public string mail_4E { get; set; }

        [StringLength(60)]
        public string KIND_ARB { get; set; }

        [StringLength(30)]
        public string KIND { get; set; }

        public short div { get; set; }

        [StringLength(15)]
        public string div_acc { get; set; }

        public short act { get; set; }

        [StringLength(60)]
        public string non_op1 { get; set; }

        [StringLength(60)]
        public string non_op2 { get; set; }

        [StringLength(60)]
        public string non_op3 { get; set; }

        [StringLength(60)]
        public string non_op4 { get; set; }

        public int? non_op5 { get; set; }

        [StringLength(60)]
        public string non_op6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amt_1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amt_2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amt_3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amt_4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amt_5 { get; set; }

        public int amt_6 { get; set; }

        public int FLAG_TR { get; set; }

        public DateTime? NEW_START_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OLD_RESIDUAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FIRST_CAPITAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_LE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQ_US { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BAR_VALUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SUB_FEE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RED_FEE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal STARTUP_CAPITAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal cust_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mang_fees_1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amtmanfees_1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amtmanfees_2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mark_fees { get; set; }

        public bool nav_yesterday { get; set; }

        [StringLength(15)]
        public string CURR { get; set; }

        [StringLength(50)]
        public string CUSTODIAN { get; set; }

        public short? AUTO_CON { get; set; }

        public short? AUTO_SET { get; set; }

        public short? AUTO_LIQ_CAP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? admin_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? scust_fees { get; set; }

        public short auto_cust { get; set; }

        [Column(TypeName = "numeric")]
        public decimal service_fees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ADV_FEES { get; set; }

        public short? daily_pfees { get; set; }

        public short? bench_pfees { get; set; }

        public DateTime? pfees1_date { get; set; }

        public DateTime? pfees2_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? startup_perf_capital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? startup_perf_pl { get; set; }

        public DateTime? pcapital_date { get; set; }

        [StringLength(25)]
        public string unified_code { get; set; }

        [StringLength(25)]
        public string unified_code1 { get; set; }

        [StringLength(5)]
        public string portf_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? daysfees { get; set; }

        public int? Auto1 { get; set; }

        public int? Auto2 { get; set; }

        public int? Auto3 { get; set; }

        public int? Auto4 { get; set; }

        public int? Auto5 { get; set; }

        public int? Auto6 { get; set; }

        public int bench_code { get; set; }

        [Column("Brok_Com     ", TypeName = "numeric")]
        public decimal Brok_Com_____ { get; set; }

        [Column("BROKER_FEES     ", TypeName = "numeric")]
        public decimal BROKER_FEES_____ { get; set; }

        public bool Cal_Un { get; set; }

        [Column("CHK_CONV     ", TypeName = "numeric")]
        public decimal CHK_CONV_____ { get; set; }

        [Column("CHK_SET     ", TypeName = "numeric")]
        public decimal CHK_SET_____ { get; set; }

        [StringLength(20)]
        public string client_type { get; set; }

        [Column("DEAL_FEES     ", TypeName = "numeric")]
        public decimal DEAL_FEES_____ { get; set; }

        [Column("IF_PER     ", TypeName = "numeric")]
        public decimal IF_PER_____ { get; set; }

        [StringLength(30)]
        public string issue_Frm { get; set; }

        [Column("mang_amt_L1     ", TypeName = "numeric")]
        public decimal mang_amt_L1_____ { get; set; }

        [Column("mang_amt_L2     ", TypeName = "numeric")]
        public decimal mang_amt_L2_____ { get; set; }

        [Column("mang_amt_L3     ", TypeName = "numeric")]
        public decimal mang_amt_L3_____ { get; set; }

        [Column("mang_amt_L4     ", TypeName = "numeric")]
        public decimal mang_amt_L4_____ { get; set; }

        [Column("mang_amt_L5     ", TypeName = "numeric")]
        public decimal mang_amt_L5_____ { get; set; }

        [Column("mang_amt_L6     ", TypeName = "numeric")]
        public decimal mang_amt_L6_____ { get; set; }

        [Column("mang_fees_L1     ", TypeName = "numeric")]
        public decimal mang_fees_L1_____ { get; set; }

        [Column("mang_fees_L2     ", TypeName = "numeric")]
        public decimal mang_fees_L2_____ { get; set; }

        [Column("mang_fees_L3     ", TypeName = "numeric")]
        public decimal mang_fees_L3_____ { get; set; }

        [Column("mang_fees_L4     ", TypeName = "numeric")]
        public decimal mang_fees_L4_____ { get; set; }

        [Column("mang_fees_L5     ", TypeName = "numeric")]
        public decimal mang_fees_L5_____ { get; set; }

        [Column("mang_fees_L6     ", TypeName = "numeric")]
        public decimal mang_fees_L6_____ { get; set; }

        public int mang_flag { get; set; }

        [StringLength(50)]
        public string NAME_ARB2 { get; set; }

        public int? no_dig { get; set; }

        [Column("NO_OF_DEC     ", TypeName = "numeric")]
        public decimal NO_OF_DEC_____ { get; set; }

        [Column("PERF_DAYS     ", TypeName = "numeric")]
        public decimal PERF_DAYS_____ { get; set; }

        [Column("perf_plan     ", TypeName = "numeric")]
        public decimal perf_plan_____ { get; set; }

        public DateTime? PFEES_DATE { get; set; }

        [StringLength(50)]
        public string plan_currency { get; set; }

        public int? Prv { get; set; }

        [Column("start_ic     ", TypeName = "numeric")]
        public decimal start_ic_____ { get; set; }

        [Column("start_nav     ", TypeName = "numeric")]
        public decimal start_nav_____ { get; set; }

        public bool T_Value { get; set; }

        public short Bond_t_0 { get; set; }

        public short Adjust_check { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bro_Fees_B { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bro_Fees_s { get; set; }

        public int? EffRate { get; set; }

        public int? Deposite_t_0 { get; set; }

        public int? Cal_Ex { get; set; }

        public int? f_apt { get; set; }

        public int? NVWF { get; set; }

        public int? pl_tax { get; set; }

        public DateTime? SC_DATE { get; set; }

        public DateTime? EC_DATE { get; set; }

        public int? Chk_CustodySett { get; set; }

        public int? Force_EOY { get; set; }

        public int? keep_flag { get; set; }

        public decimal? keep_max { get; set; }

        public decimal? keep_min { get; set; }

        public decimal? keep_precentage { get; set; }

        public int recived { get; set; }

        public int recivable { get; set; }

        public int? attribution_flag { get; set; }

        public int? flag_tbill_tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tbill_tax_prec { get; set; }

        [StringLength(60)]
        public string Foriegn_Bank { get; set; }

        public int? branch { get; set; }

        public int? Industry_ID { get; set; }
    }
}
