namespace GeneralAccount.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<ACC_ALL> ACC_ALL { get; set; }

        public virtual DbSet<ACC_ALL2> ACC_ALL2 { get; set; }

        public virtual DbSet<acc_num> acc_num { get; set; }
        public virtual DbSet<ACC_NUM1> ACC_NUM1 { get; set; }
        public virtual DbSet<ACC_P> ACC_P { get; set; }
        public virtual DbSet<ACC_PP> ACC_PP { get; set; }
        public virtual DbSet<ACC_SECU> ACC_SECU { get; set; }
        public virtual DbSet<acc1> acc1 { get; set; }
        public virtual DbSet<acc2> acc2 { get; set; }
        public virtual DbSet<acc3> acc3 { get; set; }
        public virtual DbSet<acc4> acc4 { get; set; }
        public virtual DbSet<adj_cost> adj_cost { get; set; }
        public virtual DbSet<Adjust_Security_Cost> Adjust_Security_Cost { get; set; }
        public virtual DbSet<AMO_1997> AMO_1997 { get; set; }
        public virtual DbSet<asset> assets { get; set; }
        public virtual DbSet<ASSET_CLASS> ASSET_CLASS { get; set; }
        public virtual DbSet<asset_strat> asset_strat { get; set; }
        public virtual DbSet<asset_strat_PLANS> asset_strat_PLANS { get; set; }
        public virtual DbSet<asset_strat1> asset_strat1 { get; set; }
        public virtual DbSet<bank_ass> bank_ass { get; set; }
        public virtual DbSet<bank_max> bank_max { get; set; }
        public virtual DbSet<bank_max1> bank_max1 { get; set; }
        public virtual DbSet<bank_pos> bank_pos { get; set; }
        public virtual DbSet<bank_pos_new> bank_pos_new { get; set; }
        public virtual DbSet<BIZSHARE> BIZSHAREs { get; set; }
        public virtual DbSet<Bond> Bonds { get; set; }
        public virtual DbSet<bonu> bonus { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<broker> brokers { get; set; }
        public virtual DbSet<brokerSetup> brokerSetups { get; set; }
        public virtual DbSet<Calender> Calenders { get; set; }
        public virtual DbSet<CAPITAL> CAPITALs { get; set; }
        public virtual DbSet<CAPITAL1> CAPITAL1 { get; set; }
        public virtual DbSet<CATE> CATEs { get; set; }
        public virtual DbSet<cate_acc> cate_acc { get; set; }
        public virtual DbSet<charge> charges { get; set; }
        public virtual DbSet<Client_Type> Client_Type { get; set; }
        public virtual DbSet<CLIENT> CLIENTS { get; set; }
        public virtual DbSet<ClientSlip> ClientSlips { get; set; }
        public virtual DbSet<CODLog> CODLogs { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<coun_party> coun_party { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<c> cs { get; set; }
        public virtual DbSet<CURR> CURRs { get; set; }
        public virtual DbSet<CURR1> CURR1 { get; set; }
        public virtual DbSet<CURR3> CURR3 { get; set; }
        public virtual DbSet<cust> custs { get; set; }
        public virtual DbSet<cust_fees_secu> cust_fees_secu { get; set; }
        public virtual DbSet<CUSTODY> CUSTODies { get; set; }
        public virtual DbSet<CUSTODY1> CUSTODY1 { get; set; }
        public virtual DbSet<custSetup> custSetups { get; set; }
        public virtual DbSet<dea_1997> dea_1997 { get; set; }
        public virtual DbSet<dea_OLD> dea_OLD { get; set; }
        public virtual DbSet<Deals_Delete_Tracker> Deals_Delete_Tracker { get; set; }
        public virtual DbSet<div> divs { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<DURATION_CATEG> DURATION_CATEG { get; set; }
        public virtual DbSet<EN_DEF> EN_DEF { get; set; }
        public virtual DbSet<EN_DEF_OLD> EN_DEF_OLD { get; set; }
        public virtual DbSet<endef_1> endef_1 { get; set; }
        public virtual DbSet<endofyear_values> endofyear_values { get; set; }
        public virtual DbSet<ENT_1997> ENT_1997 { get; set; }
        public virtual DbSet<ENT1_1997> ENT1_1997 { get; set; }
        public virtual DbSet<ENT1_1997_core> ENT1_1997_core { get; set; }
        public virtual DbSet<ENT1_1997_core2> ENT1_1997_core2 { get; set; }
        public virtual DbSet<ENT1_1997_EOD_CANCEL> ENT1_1997_EOD_CANCEL { get; set; }
        public virtual DbSet<EOD_APP_DEP> EOD_APP_DEP { get; set; }
        public virtual DbSet<EOD_Log> EOD_Log { get; set; }
        public virtual DbSet<EOD_Logtrans> EOD_Logtrans { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<ex_ORDER> ex_ORDER { get; set; }
        public virtual DbSet<exch> exches { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Fees_Calc> Fees_Calc { get; set; }
        public virtual DbSet<Fees_client> Fees_client { get; set; }
        public virtual DbSet<Fees_Hold> Fees_Hold { get; set; }
        public virtual DbSet<Fees_layer> Fees_layer { get; set; }
        public virtual DbSet<Fees_Nav> Fees_Nav { get; set; }
        public virtual DbSet<Fees2> Fees2 { get; set; }
        public virtual DbSet<Fees3> Fees3 { get; set; }
        public virtual DbSet<FeesLog> FeesLogs { get; set; }
        public virtual DbSet<Freeze> Freezes { get; set; }
        public virtual DbSet<GIC> GICS { get; set; }
        public virtual DbSet<Hesham> Heshams { get; set; }
        public virtual DbSet<holiday> holidays { get; set; }
        public virtual DbSet<industry> industries { get; set; }
        public virtual DbSet<INT_1997> INT_1997 { get; set; }
        public virtual DbSet<JOU_1997> JOU_1997 { get; set; }
        public virtual DbSet<LIBOR> LIBORs { get; set; }
        public virtual DbSet<liq_daily> liq_daily { get; set; }
        public virtual DbSet<LIQ_HISTORY> LIQ_HISTORY { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<manag> manags { get; set; }
        public virtual DbSet<MANFEE> MANFEES { get; set; }
        public virtual DbSet<MANFEES1> MANFEES1 { get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<marketing> marketings { get; set; }
        public virtual DbSet<MarketPrice_log> MarketPrice_log { get; set; }
        public virtual DbSet<mmd_1997> mmd_1997 { get; set; }
        public virtual DbSet<mmm_1997> mmm_1997 { get; set; }
        public virtual DbSet<mmp_1997> mmp_1997 { get; set; }
        public virtual DbSet<nat> nats { get; set; }
        public virtual DbSet<NAV> NAVs { get; set; }
        public virtual DbSet<nav_daily> nav_daily { get; set; }
        public virtual DbSet<nav_daily_FEES> nav_daily_FEES { get; set; }
        public virtual DbSet<NAV_HISTORY> NAV_HISTORY { get; set; }
        public virtual DbSet<no_gen> no_gen { get; set; }
        public virtual DbSet<No_Gen_ID> No_Gen_ID { get; set; }
        public virtual DbSet<no_gen_order> no_gen_order { get; set; }
        public virtual DbSet<no_gen_order_ex> no_gen_order_ex { get; set; }
        public virtual DbSet<ORDER_BROK> ORDER_BROK { get; set; }
        public virtual DbSet<OTHER_strat> OTHER_strat { get; set; }
        public virtual DbSet<OTHER_strat_PLANS> OTHER_strat_PLANS { get; set; }
        public virtual DbSet<OTHER_strat1> OTHER_strat1 { get; set; }
        public virtual DbSet<portofolioGroup> portofolioGroups { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<psecu> psecus { get; set; }
        public virtual DbSet<RECEIVE1> RECEIVE1 { get; set; }
        public virtual DbSet<RECEIVE2> RECEIVE2 { get; set; }
        public virtual DbSet<RED_1997> RED_1997 { get; set; }
        public virtual DbSet<redemp> redemps { get; set; }
        public virtual DbSet<REMINDER> REMINDERs { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Report_nav> Report_nav { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RestoreHistory> RestoreHistories { get; set; }
        public virtual DbSet<RIGHTS_All> RIGHTS_All { get; set; }
        public virtual DbSet<RIGHTS_BAK> RIGHTS_BAK { get; set; }
        public virtual DbSet<RUA_1997> RUA_1997 { get; set; }
        public virtual DbSet<SCHEMEW> SCHEMEWs { get; set; }
        public virtual DbSet<SECTOR> SECTORs { get; set; }
        public virtual DbSet<SECTOR_strat> SECTOR_strat { get; set; }
        public virtual DbSet<SECTOR_strat_PLANS> SECTOR_strat_PLANS { get; set; }
        public virtual DbSet<SECTOR_strat1> SECTOR_strat1 { get; set; }
        public virtual DbSet<secu> secus { get; set; }
        public virtual DbSet<Secu_StartDate> Secu_StartDate { get; set; }
        public virtual DbSet<SECU_strat> SECU_strat { get; set; }
        public virtual DbSet<SECU_strat_PLANS> SECU_strat_PLANS { get; set; }
        public virtual DbSet<SECU_strat1> SECU_strat1 { get; set; }
        public virtual DbSet<secub> secubs { get; set; }
        public virtual DbSet<SECUB_ADD> SECUB_ADD { get; set; }
        public virtual DbSet<secub_EOD> secub_EOD { get; set; }
        public virtual DbSet<SERIAL50> SERIAL50 { get; set; }
        public virtual DbSet<set_1997> set_1997 { get; set; }
        public virtual DbSet<split> splits { get; set; }
        public virtual DbSet<sponsor> sponsors { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<state_1> state_1 { get; set; }
        public virtual DbSet<STRU> STRUs { get; set; }
        public virtual DbSet<subsc> subscs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<T1> T1 { get; set; }
        public virtual DbSet<T2> T2 { get; set; }
        public virtual DbSet<T24> T24 { get; set; }
        public virtual DbSet<T25> T25 { get; set; }
        public virtual DbSet<T4> T4 { get; set; }
        public virtual DbSet<T6> T6 { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<TALKON> TALKONs { get; set; }
        public virtual DbSet<tbfkacc_all> tbfkacc_all { get; set; }
        public virtual DbSet<tbillrate> tbillrates { get; set; }
        public virtual DbSet<temp> temps { get; set; }
        public virtual DbSet<temp_Tr> temp_Tr { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Tr> Trs { get; set; }
        public virtual DbSet<Tra_market> Tra_market { get; set; }
        public virtual DbSet<tra_type> tra_type { get; set; }
        public virtual DbSet<tran> trans { get; set; }
        public virtual DbSet<TRANS_EOY> TRANS_EOY { get; set; }
        public virtual DbSet<TRANS_EOY1> TRANS_EOY1 { get; set; }
        public virtual DbSet<trans_history> trans_history { get; set; }
        public virtual DbSet<trans_Log> trans_Log { get; set; }
        public virtual DbSet<Transfer_To_Cust> Transfer_To_Cust { get; set; }
        public virtual DbSet<T> Ts { get; set; }
        public virtual DbSet<tsecu> tsecus { get; set; }
        public virtual DbSet<USER_CLIENT> USER_CLIENT { get; set; }
        public virtual DbSet<user_client_junction> user_client_junction { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }
        public virtual DbSet<usermain> usermains { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<var_rate> var_rate { get; set; }
        public virtual DbSet<WAvg> WAvgs { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<ENT1_Entry> ENT1_Entry { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BSPL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.liq_bal)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.name_eng)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.SORTBY)
                .HasPrecision(5, 0);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.ACCHEAD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.ACCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.reportname)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.CATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.drcr)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.s_type_____)
                .HasPrecision(5, 0);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BANK_REUTER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BANK_CORESPONDENE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BANK_CORESPONDENE_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.ACCOUNT_NUM_OF_BANK_AT_CORESPONDENE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BANK_INTERMEDIARY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.BANK_INTERMEDIARY_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_ALL>()
                .Property(e => e.ACCOUNT_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<acc_num>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_NUM1>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_NUM1>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_P>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_P>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_PP>()
                .Property(e => e.code)
                .HasPrecision(12, 0);

            modelBuilder.Entity<ACC_PP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_PP>()
                .Property(e => e.ACC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC_PP>()
                .Property(e => e.desc_s)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.bspl)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.NAME_eng)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.ACCHEAD)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.ACCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.reportname)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.CATE)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.drcr)
                .IsUnicode(false);

            modelBuilder.Entity<acc1>()
                .Property(e => e.s_type_____)
                .HasPrecision(5, 0);

            modelBuilder.Entity<acc2>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.acc1)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.acc1_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.name_eng)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.ACCHEAD)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.ACCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.reportname)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.CATE)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.drcr)
                .IsUnicode(false);

            modelBuilder.Entity<acc2>()
                .Property(e => e.s_type_____)
                .HasPrecision(5, 0);

            modelBuilder.Entity<acc3>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.acc1)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.acc1_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.acc2)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.acc2_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<acc3>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc1)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc1_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc2)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc2_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc3)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.acc3_name)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<acc4>()
                .Property(e => e.test4)
                .HasPrecision(12, 2);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.book_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.average_cost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.market_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.market_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.bookvalue_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.EXCHANGE_RATE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.market_value_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.PUR_SAL_PRICE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<adj_cost>()
                .Property(e => e.SELLING_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Adjust_Security_Cost>()
                .Property(e => e.new_face_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Adjust_Security_Cost>()
                .Property(e => e.face_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.rev)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.AMO_FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AMO_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e._short)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.instrument)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.interest)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.redem)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.divid)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.bonus)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.rights)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.zero_rate)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.acc_code_un)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.VAR_RATE)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.COUPON)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.ACC_CODE_INT)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.discounted)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.TAX)
                .HasPrecision(18, 5);

            modelBuilder.Entity<asset>()
                .Property(e => e.TAX_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.HOLD_STOCKS)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.M_TO_M)
                .IsUnicode(false);

            modelBuilder.Entity<asset>()
                .Property(e => e.acc_income)
                .IsUnicode(false);

            modelBuilder.Entity<ASSET_CLASS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ASSET_CLASS>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat_PLANS>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<asset_strat1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<bank_ass>()
                .Property(e => e.scr)
                .IsUnicode(false);

            modelBuilder.Entity<bank_ass>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<bank_ass>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<bank_ass>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<bank_max>()
                .Property(e => e.bank)
                .IsUnicode(false);

            modelBuilder.Entity<bank_max1>()
                .Property(e => e.acc_no)
                .IsUnicode(false);

            modelBuilder.Entity<bank_max1>()
                .Property(e => e.acc_desc)
                .IsUnicode(false);

            modelBuilder.Entity<bank_pos>()
                .Property(e => e.Tra_Type)
                .IsUnicode(false);

            modelBuilder.Entity<bank_pos_new>()
                .Property(e => e.Tra_Type)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.CURR_YEAR)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.curr_diff)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.curr_diff_code)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.dbpath)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.ExeclSheetPath)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.SheetName)
                .IsUnicode(false);

            modelBuilder.Entity<BIZSHARE>()
                .Property(e => e.EXCEL_VER)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.deal_no)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.order_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.isin_code)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.invoice)
                .HasPrecision(25, 5);

            modelBuilder.Entity<Bond>()
                .Property(e => e.amortization)
                .HasPrecision(25, 5);

            modelBuilder.Entity<Bond>()
                .Property(e => e.YTM)
                .HasPrecision(25, 5);

            modelBuilder.Entity<Bond>()
                .Property(e => e.cust)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.price)
                .HasPrecision(25, 5);

            modelBuilder.Entity<Bond>()
                .Property(e => e.account_1)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.Inputer)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.secu_id)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.secu_name)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.EX_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Bond>()
                .Property(e => e.ACC_CODE1)
                .IsUnicode(false);

            modelBuilder.Entity<Bond>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Bond>()
                .Property(e => e.invoice_coupon)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Bond>()
                .Property(e => e.face_val)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Bond>()
                .Property(e => e.fees)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bonu>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.let_cust)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<bonu>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Name_arb)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.stock)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_desc)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_desc1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_desc2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_desc3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acc_code3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.acct)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.trader)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.floor)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.research)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.phone3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.hot)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.hot1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.hot2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.hot3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.mobil)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.mobil1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.mobil2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.mobil3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.email2)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.email3)
                .IsUnicode(false);

            modelBuilder.Entity<broker>()
                .Property(e => e.Percentage_Trans)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.min_Trans)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.max_Trans)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.min_Swift)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.max_Swift)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.Fixed_Trans)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.Fixed_Swift)
                .HasPrecision(18, 5);

            modelBuilder.Entity<broker>()
                .Property(e => e.Tra_id)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.stock)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_desc)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_desc1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_desc2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_desc3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acc_code3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.acct)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.trader)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.floor)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.research)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.phone3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.hot)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.hot1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.hot2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.hot3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.mobil)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.mobil1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.mobil2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.mobil3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.email2)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.email3)
                .IsUnicode(false);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.Percentage_Trans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.min_Trans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.max_Trans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.min_Swift)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.max_Swift)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.Fixed_Trans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<brokerSetup>()
                .Property(e => e.Fixed_Swift)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Calender>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.AUTHER)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.ACC_CODE1)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CAPITAL>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.RATE_1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.AUTHER)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.secu_id)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.quantity)
                .HasPrecision(7, 0);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.average_cost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.secu_acc)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CAPITAL1>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CATE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CATE>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<cate_acc>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<cate_acc>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<charge>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<charge>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<charge>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.HOME_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.HOME_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.HOME_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.FAX_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.FAX_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.FAX_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.WORK_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.WORK_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.WORK_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.PORT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.CAPITAL)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.CAPITAL_SHARE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.PERF_FEES)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.MANG_FEES)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAME_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAME_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAME_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAME_4)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_4)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ADDRESS_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ADDRESS_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.MAIL_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.MAIL_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.MAIL_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.MAIL_4)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.OPEN_BAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.LIQ_OPERAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.POSIT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ID_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ISSUE_FROM)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.BANK_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.BANK_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.LE_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.LE_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.US_1)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.US_2)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.OPEN_BAL_T)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.LIQ_OPERAT_T)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.APP_DEP)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NAV)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.strat)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.residual)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.title_arb)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.mail_1e)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.mail_2e)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.mail_3e)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.mail_4E)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.KIND_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.KIND)
                .IsUnicode(false);

            modelBuilder.Entity<ClientSlip>()
                .Property(e => e.TransCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientSlip>()
                .Property(e => e.SchemewId)
                .IsUnicode(false);

            modelBuilder.Entity<ClientSlip>()
                .Property(e => e.Security)
                .IsUnicode(false);

            modelBuilder.Entity<ClientSlip>()
                .Property(e => e.Inputer)
                .IsUnicode(false);

            modelBuilder.Entity<CODLog>()
                .Property(e => e.Schemew)
                .IsFixedLength();

            modelBuilder.Entity<CODLog>()
                .Property(e => e.inputer)
                .IsFixedLength();

            modelBuilder.Entity<company>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.sector)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.person)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.BANK_AC)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<coun_party>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.Schemew)
                .IsFixedLength();

            modelBuilder.Entity<Coupon>()
                .Property(e => e.Security_Id)
                .IsFixedLength();

            modelBuilder.Entity<Coupon>()
                .Property(e => e.Amount)
                .HasPrecision(20, 5);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.S_type)
                .IsFixedLength();

            modelBuilder.Entity<c>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<c>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<c>()
                .Property(e => e.Desc_s)
                .IsUnicode(false);

            modelBuilder.Entity<c>()
                .Property(e => e.flag_s)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CURR>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.CURR1)
                .IsUnicode(false);

            modelBuilder.Entity<CURR1>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CURR1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<CURR1>()
                .Property(e => e.NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<CURR3>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CURR3>()
                .Property(e => e.NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<CURR3>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.fax1)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.nav_ch)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.nav_frq)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.ID_BROK)
                .IsUnicode(false);

            modelBuilder.Entity<cust>()
                .Property(e => e.fixed_flat)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.percentage)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.m_min)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.m_max)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Swift_FixedFlat)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Swift_percentage)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Swift_Min)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Swift_Max)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.PercTxt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Swift_PercTxt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<cust>()
                .Property(e => e.Tra_id)
                .IsUnicode(false);

            modelBuilder.Entity<cust_fees_secu>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<cust_fees_secu>()
                .Property(e => e.s_type)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CUSTODY>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTODY>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTODY>()
                .Property(e => e.QUANTITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CUSTODY>()
                .Property(e => e.QTY_REC)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CUSTODY>()
                .Property(e => e.CUST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTODY1>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTODY1>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTODY1>()
                .Property(e => e.QTY_REC)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CUSTODY1>()
                .Property(e => e.CUST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.fax1)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.nav_ch)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.nav_frq)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.ID_BROK)
                .IsUnicode(false);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.fixed_flat)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.percentage)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.m_min)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.m_max)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.Swift_FixedFlat)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.Swift_percentage)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.Swift_Min)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.Swift_Max)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.PercTxt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.Swift_PercTxt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<custSetup>()
                .Property(e => e.engname)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.average_cost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.dip_dis_no)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.qty_delivered)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.out_qty)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.out_amt)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.pur_sal_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.man_ref)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.custodian_charges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.cum_int)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.broker_comm_Per)
                .HasPrecision(12, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.tot_inv)
                .HasPrecision(20, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.broker_comm)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.stamp)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.stock_charges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.clear_comm)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.net_value)
                .HasPrecision(20, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.int_days)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.accruD_int)
                .HasPrecision(25, 9);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.desc_1)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.tot_inv_l)
                .HasPrecision(20, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.broker_comm_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.stamp_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.stock_charges_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.clear_comm_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.net_value_l)
                .HasPrecision(20, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.exch_rate)
                .HasPrecision(28, 20);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.profit_loss)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.broker_acc)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.BKEEPING)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.BKEEPING_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.ORDER_BROK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(20, 2);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.AVG_PRICE_ORDER)
                .HasPrecision(20, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.DAILY_INT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.other_fees)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.other_fees_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.cma)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.cma_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.TAX_AMOUNT)
                .HasPrecision(25, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.SPONSOR_FEES_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<dea_1997>()
                .Property(e => e.pl_tax_amount)
                .HasPrecision(25, 5);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.average_cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.dip_dis_no)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.qty_delivered)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.out_qty)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.out_amt)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.pur_sal_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.man_ref)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.custodian_charges)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.cum_int)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.broker_comm_Per)
                .HasPrecision(12, 5);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.tot_inv)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.broker_comm)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.stamp)
                .HasPrecision(6, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.stock_charges)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.clear_comm)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.net_value)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.int_days)
                .HasPrecision(10, 0);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.accruD_int)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.desc_1)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.tot_inv_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.broker_comm_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.stamp_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.stock_charges_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.clear_comm_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.net_value_l)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.exch_rate)
                .HasPrecision(10, 5);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.profit_loss)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.broker_acc)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.BKEEPING)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.BKEEPING_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.ORDER_BROK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dea_OLD>()
                .Property(e => e.AVG_PRICE_ORDER)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Deals_Delete_Tracker>()
                .Property(e => e.Inputer)
                .IsFixedLength();

            modelBuilder.Entity<div>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.let_cust)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<div>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<DURATION_CATEG>()
                .Property(e => e.CODE)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DURATION_CATEG>()
                .Property(e => e.CATEG)
                .IsUnicode(false);

            modelBuilder.Entity<DURATION_CATEG>()
                .Property(e => e.AMOUNT)
                .HasPrecision(25, 5);

            modelBuilder.Entity<DURATION_CATEG>()
                .Property(e => e.Current_rate)
                .HasPrecision(25, 5);

            modelBuilder.Entity<DURATION_CATEG>()
                .Property(e => e.Market_rate)
                .HasPrecision(25, 5);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.AC_DEBIT)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.AC_CREDIT)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.AC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.DBCR)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.NARRATION)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e._ref)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.AC_DEBIT)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.AC_CREDIT)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.AC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.DBCR)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.NARRATION)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e._ref)
                .IsUnicode(false);

            modelBuilder.Entity<EN_DEF_OLD>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<endef_1>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<endef_1>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<endef_1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<endofyear_values>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<endofyear_values>()
                .Property(e => e.inputer)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.tra_desc)
                .IsUnicode(false);

            modelBuilder.Entity<ENT_1997>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACC_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.AMOUNT_3)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.LOCAL_AMT1)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACC_DR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.ACC_CR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.AMOUNT_3)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.LOCAL_AMT1)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.acc_fund)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.Refrence)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core>()
                .Property(e => e.del_rev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.AMOUNT_3)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.LOCAL_AMT1)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_core2>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACC_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.AMOUNT_3)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.LOCAL_AMT1)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACC_DR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.ACC_CR)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ENT1_1997_EOD_CANCEL>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EOD_APP_DEP>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<EOD_APP_DEP>()
                .Property(e => e.ACC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EOD_APP_DEP>()
                .Property(e => e.SECU_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EOD_APP_DEP>()
                .Property(e => e.AMOUNT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EOD_APP_DEP>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<EOD_Logtrans>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<EOD_Logtrans>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.ORDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.ref_ORDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.ORDER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.BROKER)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.BROKER_COMM)
                .HasPrecision(25, 6);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.QUANTITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.ex_QUANTITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.PRICE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.TOT_AMT)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.QTY_OUTSTANDING)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.tot_amt_L)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.QTY_SET)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.LIQ_AMT_ORDER)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ex_ORDER>()
                .Property(e => e.LIQ_AMT_EX)
                .HasPrecision(20, 2);

            modelBuilder.Entity<exch>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.tel3)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.fax1)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.fax2)
                .IsUnicode(false);

            modelBuilder.Entity<exch>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Schemew)
                .IsFixedLength();

            modelBuilder.Entity<Fee>()
                .Property(e => e.Percentage)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Amount)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Min_fees)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Max_fees)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Bench_Prec)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Capital_1)
                .HasPrecision(25, 5);

            modelBuilder.Entity<Fee>()
                .Property(e => e.Fixed_Amount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fee>()
                .Property(e => e.swift_fees)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fees_Calc>()
                .Property(e => e.Schemew)
                .IsUnicode(false);

            modelBuilder.Entity<Fees_Calc>()
                .Property(e => e.Nav)
                .HasPrecision(22, 5);

            modelBuilder.Entity<Fees_Calc>()
                .Property(e => e.Fees_Amount)
                .HasPrecision(22, 5);

            modelBuilder.Entity<Fees_layer>()
                .Property(e => e.From)
                .HasPrecision(25, 10);

            modelBuilder.Entity<Fees_layer>()
                .Property(e => e.To)
                .HasPrecision(25, 10);

            modelBuilder.Entity<Fees_layer>()
                .Property(e => e.percentage)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Fees_Nav>()
                .Property(e => e.Acc_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Fees2>()
                .Property(e => e.TABLE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Fees3>()
                .Property(e => e.Schemew)
                .IsFixedLength();

            modelBuilder.Entity<Fees3>()
                .Property(e => e.Percentage)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Fees3>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Freeze>()
                .Property(e => e.Isin_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Freeze>()
                .Property(e => e.Security_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Freeze>()
                .Property(e => e.Amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Freeze>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BSPL)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.liq_bal)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.name_eng)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.SORTBY)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.ACCHEAD)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.ACCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.reportname)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.CATE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.drcr)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.s_type_____)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BANK_REUTER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BANK_CORESPONDENE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BANK_CORESPONDENE_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.ACCOUNT_NUM_OF_BANK_AT_CORESPONDENE)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BANK_INTERMEDIARY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Hesham>()
                .Property(e => e.BANK_INTERMEDIARY_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<holiday>()
                .Property(e => e.day)
                .IsUnicode(false);

            modelBuilder.Entity<holiday>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<holiday>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<industry>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<industry>()
                .Property(e => e.swift_no)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.rev)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.tra_desc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.AMOUNT)
                .HasPrecision(20, 5);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(20, 5);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.RATE_1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.rev)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<JOU_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LIBOR>()
                .Property(e => e.RATE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<liq_daily>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<liq_daily>()
                .Property(e => e.LIQ)
                .HasPrecision(12, 2);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.ACC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.BALANCE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.LINE_OR)
                .HasPrecision(2, 0);

            modelBuilder.Entity<LIQ_HISTORY>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.fax1)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<manag>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.bank_ac)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.MAN_PERIOD)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEE>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.bank_ac)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.MAN_PERIOD)
                .IsUnicode(false);

            modelBuilder.Entity<MANFEES1>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Market>()
                .Property(e => e.Security_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Market>()
                .Property(e => e.Security)
                .IsUnicode(false);

            modelBuilder.Entity<Market>()
                .Property(e => e.TEMP_CODE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Market>()
                .Property(e => e.inputer)
                .IsUnicode(false);

            modelBuilder.Entity<marketing>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<marketing>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<marketing>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<marketing>()
                .Property(e => e.ACC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.RATE_1)
                .HasPrecision(20, 7);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.int_rate)
                .HasPrecision(20, 7);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.rev)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.int_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.AMO_FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.local_int_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.EX_INST)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.EX_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.AMT_DIFF)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.coun_party)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.basis)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.day_basis)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.AMT_POSTED)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.tra_desc)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.VAR_RATE)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.COUPON)
                .IsUnicode(false);

            modelBuilder.Entity<mmd_1997>()
                .Property(e => e.FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.RATE_1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.int_rate)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.no_of_days)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.int_amt)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.AMO_FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.local_int_amt)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.EX_INST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.EX_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.AMT_DIFF)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.coun_party)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.m_deal_no)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.tra_desc)
                .IsUnicode(false);

            modelBuilder.Entity<mmm_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.RATE_1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.int_rate)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.int_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.AMO_FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.EX_INST)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.EX_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.AMT_DIFF)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.coun_party)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.m_deal_no)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.act_int_rec)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.local_int_rec)
                .HasPrecision(18, 5);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.tra_desc)
                .IsUnicode(false);

            modelBuilder.Entity<mmp_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<nat>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<NAV>()
                .Property(e => e.Nav1)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.Hrms)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.EFG)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.IFCI)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.PIMA)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.RelHrms)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.RelPIMA)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.RelIFCI)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.RelNav)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.Relative)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.RelEFG)
                .HasPrecision(12, 5);

            modelBuilder.Entity<NAV>()
                .Property(e => e.FLAG_TR)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NAV>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<NAV>()
                .Property(e => e.IDEN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.nav)
                .HasPrecision(18, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.no_of_cert)
                .HasPrecision(18, 0);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.bench_rate)
                .HasPrecision(18, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.bench_amount)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.net_capital)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Balance)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Weighted_Balance)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.P_L)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Benchmark)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Profit_Over_Benchmark)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Pref_Fess)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily>()
                .Property(e => e.Nav_Fees)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.NAV)
                .HasPrecision(24, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.MARK_FEES)
                .HasPrecision(24, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.MANG_FEES)
                .HasPrecision(24, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.CUST_FEES)
                .HasPrecision(24, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.secu_fees)
                .HasPrecision(25, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.admin_fees)
                .HasPrecision(24, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.service_fees)
                .HasPrecision(18, 5);

            modelBuilder.Entity<nav_daily_FEES>()
                .Property(e => e.adv_fees)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.ORDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.ORDER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.BROKER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.BROKER_COMM)
                .HasPrecision(25, 6);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.QUANTITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.PRICE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.COUPON)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CUMM_INT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.TOT_AMT)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.QTY_OUTSTANDING)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.LIQ_UPDATED)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.QTY_SET)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.rate)
                .HasPrecision(12, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.time_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.AMOUNT_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.BOOK_KEEPING_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.BROKER_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.BUY_SELL)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CLEAR_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CMA_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CURR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.CUSTODIAN)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.INS_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.ISIN_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.QUANTITY_DISK_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.STAMP_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.STOCK_FEES_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<ORDER_BROK>()
                .Property(e => e.UNI_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.asset_type)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.EST_PRICE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OTHER_strat>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.asset_type)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.EST_PRICE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OTHER_strat_PLANS>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.asset_type)
                .IsUnicode(false);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.EST_PRICE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OTHER_strat1>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<psecu>()
                .Property(e => e.deal_no)
                .IsUnicode(false);

            modelBuilder.Entity<psecu>()
                .Property(e => e.order_type)
                .IsUnicode(false);

            modelBuilder.Entity<psecu>()
                .Property(e => e.iss_type)
                .IsUnicode(false);

            modelBuilder.Entity<psecu>()
                .Property(e => e.account_1)
                .IsUnicode(false);

            modelBuilder.Entity<psecu>()
                .Property(e => e.secu_name)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.DEAL_REF)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.cbo_type)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.OUTSTANDING)
                .HasPrecision(12, 2);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RECEIVE1>()
                .Property(e => e.TAXAMOUNT_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.bank_ac)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.DEAL_REF)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RECEIVE2>()
                .Property(e => e.TAXAMOUNT_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.average_cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.dip_dis_no)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.qty_delivered)
                .HasPrecision(10, 0);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.out_qty)
                .HasPrecision(10, 0);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.out_amt)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.pur_sal_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.man_ref)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.custodian_charges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.cum_int)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.broker_comm_Per)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.tot_inv)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.broker_comm)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.stamp)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.stock_charges)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.clear_comm)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.net_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.int_days)
                .HasPrecision(10, 0);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.accruD_int)
                .HasPrecision(20, 9);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.desc_1)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.tot_inv_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.broker_comm_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.stamp_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.stock_charges_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.clear_comm_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.net_value_l)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.exch_rate)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.tra_ch)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.profit_loss)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.broker_acc)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.BKEEPING)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.BKEEPING_l)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.ORDER_BROK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.AVG_PRICE_ORDER)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.TAX_AMOUNT)
                .HasPrecision(25, 5);

            modelBuilder.Entity<RED_1997>()
                .Property(e => e.SPONSOR_FEES_____)
                .HasPrecision(18, 0);

            modelBuilder.Entity<redemp>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.AUTHER)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.quantity)
                .HasPrecision(20, 10);

            modelBuilder.Entity<redemp>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.ic_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.red_fee)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.fee_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.fee_amt_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<redemp>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<redemp>()
                .Property(e => e.marketing)
                .IsUnicode(false);

            modelBuilder.Entity<redemp>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<REMINDER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REMINDER>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<REMINDER>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<REMINDER>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Report_nav>()
                .Property(e => e.Acc_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Yield)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Request>()
                .Property(e => e.Face_Value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Request>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Purchase_Yield)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Request>()
                .Property(e => e.Price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RestoreHistory>()
                .Property(e => e.RestoreId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RestoreHistory>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<RestoreHistory>()
                .Property(e => e.DBSize)
                .IsUnicode(false);

            modelBuilder.Entity<RestoreHistory>()
                .Property(e => e.BackupBath)
                .IsUnicode(false);

            modelBuilder.Entity<RestoreHistory>()
                .Property(e => e.RestoreTime)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.DESC_S)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.form_menu)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.form_name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_All>()
                .Property(e => e.USER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.DESC_S)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.form_menu)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.form_name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RIGHTS_BAK>()
                .Property(e => e.USER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.ACCOUNT_2)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.CHECK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.rev)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.acc_code2)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.AMO_FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.INST_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.bank_ac)
                .IsUnicode(false);

            modelBuilder.Entity<RUA_1997>()
                .Property(e => e.int_rate)
                .HasPrecision(25, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAT)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.HOME_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.HOME_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.HOME_3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.FAX_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.FAX_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.FAX_3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.WORK_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.WORK_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.WORK_3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.PORT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.CAPITAL_SHARE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.PERF_FEES)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.MANG_FEES)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME_3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME_4)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_4)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ADDRESS_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ADDRESS_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.OPEN_BAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.LIQ_OPERAT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.POSIT)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ID_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ISSUE_FROM)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ACC_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.BANK_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.BANK_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.LE_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.LE_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.US_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.US_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.OPEN_BAL_T)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.LIQ_OPERAT_T)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.APP_DEP)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NAV)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.strat)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.residual)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mail_1e)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mail_2e)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mail_3e)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mail_4E)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.KIND)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.div_acc)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.non_op1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.non_op2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.non_op3)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.non_op4)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.non_op6)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.OLD_RESIDUAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.BAR_VALUE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.SUB_FEE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.RED_FEE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.cust_fees)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.amtmanfees_1)
                .HasPrecision(25, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.amtmanfees_2)
                .HasPrecision(25, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mark_fees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.CUSTODIAN)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.admin_fees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.scust_fees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.service_fees)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.ADV_FEES)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.startup_perf_capital)
                .HasPrecision(25, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.startup_perf_pl)
                .HasPrecision(25, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.unified_code)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.unified_code1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.portf_no)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.daysfees)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.Brok_Com_____)
                .HasPrecision(18, 1);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.BROKER_FEES_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.CHK_CONV_____)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.CHK_SET_____)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.client_type)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.DEAL_FEES_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.IF_PER_____)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.issue_Frm)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L1_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L2_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L3_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L4_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L5_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_amt_L6_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L1_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L2_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L3_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L4_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L5_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.mang_fees_L6_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.NO_OF_DEC_____)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.PERF_DAYS_____)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.perf_plan_____)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.start_ic_____)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.start_nav_____)
                .HasPrecision(25, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.Bro_Fees_B)
                .HasPrecision(10, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.Bro_Fees_s)
                .HasPrecision(10, 5);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.keep_max)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.keep_min)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.keep_precentage)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.tbill_tax_prec)
                .HasPrecision(18, 10);

            modelBuilder.Entity<SCHEMEW>()
                .Property(e => e.Foriegn_Bank)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat_PLANS>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR_strat1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.asset_type)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.discounted)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.exch)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.group_s)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.face_value)
                .HasPrecision(18, 9);

            modelBuilder.Entity<secu>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.coupon)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.NO_OF_SHARES)
                .HasPrecision(12, 0);

            modelBuilder.Entity<secu>()
                .Property(e => e.BONUS_RATE)
                .HasPrecision(12, 3);

            modelBuilder.Entity<secu>()
                .Property(e => e.SPLIT_RATE)
                .HasPrecision(12, 3);

            modelBuilder.Entity<secu>()
                .Property(e => e.DIV_RATE)
                .HasPrecision(12, 3);

            modelBuilder.Entity<secu>()
                .Property(e => e.reuter_code)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.secu_liq)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.FIX_PRICE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<secu>()
                .Property(e => e.group_flag)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secu>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.TELE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.SECU_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secu>()
                .Property(e => e.isin_code)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.egx20_____)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secu>()
                .Property(e => e.egx30_____)
                .HasPrecision(18, 10);

            modelBuilder.Entity<secu>()
                .Property(e => e.NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<secu>()
                .Property(e => e.tax_rate_____)
                .HasPrecision(25, 2);

            modelBuilder.Entity<Secu_StartDate>()
                .Property(e => e.Schemew)
                .IsUnicode(false);

            modelBuilder.Entity<Secu_StartDate>()
                .Property(e => e.Security_id)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.SECTOR_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.ASSET_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.QTY_SHARES)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.act_amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.est_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.act_shares)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.ACT_AMOUNT_LOCAL)
                .HasPrecision(12, 3);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.EXCHANGE_RATE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.AMOUNT_ASSET_LOCAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat>()
                .Property(e => e.CURRENCY)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.SECTOR_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.ASSET_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.QTY_SHARES)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.act_amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.est_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.act_shares)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.ACT_AMOUNT_LOCAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.EXCHANGE_RATE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.AMOUNT_ASSET_LOCAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat_PLANS>()
                .Property(e => e.CURRENCY)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.per_from_amt)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.amount_asset)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.SECTOR_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.ASSET_TOT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.QTY_SHARES)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.act_amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.est_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.act_shares)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.PLAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.ACT_AMOUNT_LOCAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.EXCHANGE_RATE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.AMOUNT_ASSET_LOCAL)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.CURRENCY)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.price_temp)
                .HasPrecision(18, 5);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.BASE_SIGN)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.BASE_CURR)
                .IsUnicode(false);

            modelBuilder.Entity<SECU_strat1>()
                .Property(e => e.FLAG_S)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.EX_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.COUNT_BASIS)
                .HasPrecision(2, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.COUNT_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.REMAIN_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.RUNNING_DISCOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<secub>()
                .Property(e => e.FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<secub>()
                .Property(e => e.CHK_ACT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub>()
                .Property(e => e.SECU_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.EX_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.COUNT_BASIS)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.COUNT_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.REMAIN_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.RUNNING_DISCOUNT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.FREQ)
                .IsUnicode(false);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.CHK_ACT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SECUB_ADD>()
                .Property(e => e.SECU_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.ASSET_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.EX_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.COUNT_BASIS)
                .HasPrecision(2, 0);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.COUNT_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.REMAIN_DAYS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.RUNNING_DISCOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<secub_EOD>()
                .Property(e => e.CHK_ACT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.dip_dis_no)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.broker_acc)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.bank_ac)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.acc_code)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.DEAL_REF)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.check_no)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<set_1997>()
                .Property(e => e.TAX_AMOUNT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<split>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.SECURITY)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.let_cust)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<split>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.fax1)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.fund_comm)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.fund_mang)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_1)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_2)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_3)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_4)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_5)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.emp_6)
                .IsUnicode(false);

            modelBuilder.Entity<sponsor>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.state1)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.legend1)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.st1)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.gt1)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.r1)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.acc_no1)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.acc_no2)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.legend2)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.st2)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.gt2)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.r2)
                .IsUnicode(false);

            modelBuilder.Entity<state_1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<STRU>()
                .Property(e => e.YEAR)
                .HasPrecision(18, 0);

            modelBuilder.Entity<STRU>()
                .Property(e => e.RATE)
                .HasPrecision(24, 5);

            modelBuilder.Entity<STRU>()
                .Property(e => e.LIBOR)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.LOCAL_AMT)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.DESC_1)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.TRA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.AUTHER)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.TRA_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.quantity)
                .HasPrecision(20, 10);

            modelBuilder.Entity<subsc>()
                .Property(e => e.ACCOUNT_1)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.acc_code1)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.ic_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.red_fee)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.fee_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.fee_amt_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<subsc>()
                .Property(e => e.LIQ_AMT)
                .HasPrecision(12, 2);

            modelBuilder.Entity<subsc>()
                .Property(e => e.marketing)
                .IsUnicode(false);

            modelBuilder.Entity<subsc>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<Table1>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BSPL)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.NAME_ARB)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.liq_bal)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Table1>()
                .Property(e => e.name_eng)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.SORTBY)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Table1>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.ACCHEAD)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.ACCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.reportname)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.CATE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.cs_1)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.cs_2)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.drcr)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.s_type_____)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BANK_REUTER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BANK_CORESPONDENE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BANK_CORESPONDENE_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.ACCOUNT_NUM_OF_BANK_AT_CORESPONDENE)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BANK_INTERMEDIARY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.BANK_INTERMEDIARY_BIC_CODE_SWIFT)
                .IsUnicode(false);

            modelBuilder.Entity<TALKON>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TALKON>()
                .Property(e => e.SCHEMEW)
                .IsUnicode(false);

            modelBuilder.Entity<TALKON>()
                .Property(e => e.SECURITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tbillrate>()
                .Property(e => e.rate)
                .HasPrecision(18, 5);

            modelBuilder.Entity<tbillrate>()
                .Property(e => e.inputer)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.deal_no)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.order_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.no_of_unit)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.unit_val)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.yield)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.face_val)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.presint_val)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.account_1)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Inputer)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.secu_id)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.secu_name)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.ORDER_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.EX_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.ACC_CODE1)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.acc_int)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Bank_acc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.cust_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.tra_type1)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.prefix)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.discounted)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<tra_type>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tran>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tran>()
                .Property(e => e.book_value)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.average_cost)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.market_price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tran>()
                .Property(e => e.market_value)
                .HasPrecision(20, 2);

            modelBuilder.Entity<tran>()
                .Property(e => e.bookvalue_local)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.exchange_rate)
                .HasPrecision(28, 20);

            modelBuilder.Entity<tran>()
                .Property(e => e.market_value_local)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.curr)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.broker)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.dip_dis_no)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.qty_delivered)
                .HasPrecision(15, 0);

            modelBuilder.Entity<tran>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.industry)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.pur_sal_price)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.SELLING_VALUE)
                .HasPrecision(20, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.CUSTODIAN)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tran>()
                .Property(e => e.symbol)
                .IsUnicode(false);

            modelBuilder.Entity<tran>()
                .Property(e => e.acc_Int)
                .HasPrecision(18, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.Tax_Amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<tran>()
                .Property(e => e.fees_amt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.quantity)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.book_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.average_cost)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.market_price)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.market_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.bookvalue_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.EXCHANGE_RATE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.market_value_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.CURR)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.PUR_SAL_PRICE)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.auther)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY1>()
                .Property(e => e.secu_type)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY1>()
                .Property(e => e.book_value)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY1>()
                .Property(e => e.bookvalue_local)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TRANS_EOY1>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<TRANS_EOY1>()
                .Property(e => e.ACC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<trans_history>()
                .Property(e => e.interest)
                .HasPrecision(20, 5);

            modelBuilder.Entity<trans_history>()
                .Property(e => e.face_value)
                .HasPrecision(20, 5);

            modelBuilder.Entity<trans_history>()
                .Property(e => e.total_amount)
                .HasPrecision(20, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.security_id)
                .IsUnicode(false);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.quantity)
                .HasPrecision(20, 0);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.book_value)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.average_cost)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.market_price)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.market_value)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.bookvalue_local)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.exchange_rate)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.market_value_local)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.qty_delivered)
                .HasPrecision(15, 0);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.pur_sal)
                .IsUnicode(false);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.deal_ref)
                .IsUnicode(false);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.schemeW)
                .IsUnicode(false);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.tra_type)
                .IsUnicode(false);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.pur_sal_price)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.SELLING_VALUE)
                .HasPrecision(25, 5);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.S_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<trans_Log>()
                .Property(e => e.Log_User)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.asset_type)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.discounted)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.exch)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.group_s)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.inputer)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.security)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.co_id)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.coupon)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.name_arb)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.reuter_code)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.secu_liq)
                .IsUnicode(false);

            modelBuilder.Entity<tsecu>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<USER_CLIENT>()
                .Property(e => e.USERS)
                .IsUnicode(false);

            modelBuilder.Entity<USER_CLIENT>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_CLIENT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_CLIENT>()
                .Property(e => e.ACT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UserActivityLog>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.lastin)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.lastout)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.desc_s)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.USER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.nt_name)
                .IsUnicode(false);

            modelBuilder.Entity<usermain>()
                .Property(e => e.flag_count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<usermain>()
                .Property(e => e.password1)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.form_menu)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.form_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.desc_S)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.INPUTER)
                .IsUnicode(false);

            modelBuilder.Entity<var_rate>()
                .Property(e => e.schemew)
                .IsUnicode(false);

            modelBuilder.Entity<var_rate>()
                .Property(e => e.Trans_id)
                .IsUnicode(false);

            modelBuilder.Entity<var_rate>()
                .Property(e => e.Var_rate1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Starting_Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Profit_Loss)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Per)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Schemew)
                .IsUnicode(false);

            modelBuilder.Entity<WAvg>()
                .Property(e => e.Nav)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ENT1_Entry>()
                .Property(e => e.AMOUNT_3)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_Entry>()
                .Property(e => e.LOCAL_AMT1)
                .HasPrecision(20, 5);

            modelBuilder.Entity<ENT1_Entry>()
                .Property(e => e.acc_fund)
                .IsUnicode(false);
        }
    }
}
