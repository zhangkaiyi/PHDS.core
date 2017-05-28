using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PHDS.core.Entities.Pinhua
{
    public partial class PinhuaContext : DbContext
    {
        public virtual DbSet<EsAgentSet> EsAgentSet { get; set; }
        public virtual DbSet<EsAgentUser> EsAgentUser { get; set; }
        public virtual DbSet<EsCaseFormat> EsCaseFormat { get; set; }
        public virtual DbSet<EsCaseLink> EsCaseLink { get; set; }
        public virtual DbSet<EsCasePic> EsCasePic { get; set; }
        public virtual DbSet<EsDataDomain> EsDataDomain { get; set; }
        public virtual DbSet<EsDataField> EsDataField { get; set; }
        public virtual DbSet<EsDataRef> EsDataRef { get; set; }
        public virtual DbSet<EsDataSource> EsDataSource { get; set; }
        public virtual DbSet<EsDataTable> EsDataTable { get; set; }
        public virtual DbSet<EsDept> EsDept { get; set; }
        public virtual DbSet<EsDeptAdmin> EsDeptAdmin { get; set; }
        public virtual DbSet<EsDomainMatch> EsDomainMatch { get; set; }
        public virtual DbSet<EsDtDesignAcl> EsDtDesignAcl { get; set; }
        public virtual DbSet<EsFillStd> EsFillStd { get; set; }
        public virtual DbSet<EsGlobalSafe> EsGlobalSafe { get; set; }
        public virtual DbSet<EsGrpRole> EsGrpRole { get; set; }
        public virtual DbSet<EsGrpUser> EsGrpUser { get; set; }
        public virtual DbSet<EsHandoverJob> EsHandoverJob { get; set; }
        public virtual DbSet<EsHandoverRc> EsHandoverRc { get; set; }
        public virtual DbSet<EsHandoverWi> EsHandoverWi { get; set; }
        public virtual DbSet<EsHomeInfo> EsHomeInfo { get; set; }
        public virtual DbSet<EsIdDel> EsIdDel { get; set; }
        public virtual DbSet<EsIdPart> EsIdPart { get; set; }
        public virtual DbSet<EsIdRec> EsIdRec { get; set; }
        public virtual DbSet<EsIdRule> EsIdRule { get; set; }
        public virtual DbSet<EsIdUsed> EsIdUsed { get; set; }
        public virtual DbSet<EsIdxFld> EsIdxFld { get; set; }
        public virtual DbSet<EsIdxTable> EsIdxTable { get; set; }
        public virtual DbSet<EsImContactGrp> EsImContactGrp { get; set; }
        public virtual DbSet<EsImUserContact> EsImUserContact { get; set; }
        public virtual DbSet<EsImfastReply> EsImfastReply { get; set; }
        public virtual DbSet<EsImmsgLog> EsImmsgLog { get; set; }
        public virtual DbSet<EsJob> EsJob { get; set; }
        public virtual DbSet<EsLog> EsLog { get; set; }
        public virtual DbSet<EsNewRepBar> EsNewRepBar { get; set; }
        public virtual DbSet<EsNfsauth> EsNfsauth { get; set; }
        public virtual DbSet<EsOuterLink> EsOuterLink { get; set; }
        public virtual DbSet<EsOuterLinkAcl> EsOuterLinkAcl { get; set; }
        public virtual DbSet<EsQryAcl> EsQryAcl { get; set; }
        public virtual DbSet<EsQryDesignAcl> EsQryDesignAcl { get; set; }
        public virtual DbSet<EsRcAdd> EsRcAdd { get; set; }
        public virtual DbSet<EsRepCase> EsRepCase { get; set; }
        public virtual DbSet<EsRole> EsRole { get; set; }
        public virtual DbSet<EsRoleGroup> EsRoleGroup { get; set; }
        public virtual DbSet<EsRtfIdbind> EsRtfIdbind { get; set; }
        public virtual DbSet<EsRtfLink> EsRtfLink { get; set; }
        public virtual DbSet<EsRtfStd> EsRtfStd { get; set; }
        public virtual DbSet<EsRtfs> EsRtfs { get; set; }
        public virtual DbSet<EsRtts> EsRtts { get; set; }
        public virtual DbSet<EsRuleDelCase> EsRuleDelCase { get; set; }
        public virtual DbSet<EsRuleDelDetail> EsRuleDelDetail { get; set; }
        public virtual DbSet<EsRuleFill> EsRuleFill { get; set; }
        public virtual DbSet<EsRuleInsDetail> EsRuleInsDetail { get; set; }
        public virtual DbSet<EsRuleInsDt> EsRuleInsDt { get; set; }
        public virtual DbSet<EsRuleNewCase> EsRuleNewCase { get; set; }
        public virtual DbSet<EsRuleQry> EsRuleQry { get; set; }
        public virtual DbSet<EsRuleRelDt> EsRuleRelDt { get; set; }
        public virtual DbSet<EsRuleRelDtfld> EsRuleRelDtfld { get; set; }
        public virtual DbSet<EsRuleRelRtfs> EsRuleRelRtfs { get; set; }
        public virtual DbSet<EsRuleRelRtts> EsRuleRelRtts { get; set; }
        public virtual DbSet<EsRuleUpd> EsRuleUpd { get; set; }
        public virtual DbSet<EsRules> EsRules { get; set; }
        public virtual DbSet<EsSheetProp> EsSheetProp { get; set; }
        public virtual DbSet<EsSmFill> EsSmFill { get; set; }
        public virtual DbSet<EsSmQry> EsSmQry { get; set; }
        public virtual DbSet<EsSmQryAcl> EsSmQryAcl { get; set; }
        public virtual DbSet<EsSmQryDesignAcl> EsSmQryDesignAcl { get; set; }
        public virtual DbSet<EsStdComp> EsStdComp { get; set; }
        public virtual DbSet<EsStdFld> EsStdFld { get; set; }
        public virtual DbSet<EsStdList> EsStdList { get; set; }
        public virtual DbSet<EsStdQry> EsStdQry { get; set; }
        public virtual DbSet<EsStdTree> EsStdTree { get; set; }
        public virtual DbSet<EsStdValSet> EsStdValSet { get; set; }
        public virtual DbSet<EsSysId> EsSysId { get; set; }
        public virtual DbSet<EsSysIdS> EsSysIdS { get; set; }
        public virtual DbSet<EsTmp> EsTmp { get; set; }
        public virtual DbSet<EsTmpAcl> EsTmpAcl { get; set; }
        public virtual DbSet<EsTmpAdd> EsTmpAdd { get; set; }
        public virtual DbSet<EsTmpClass> EsTmpClass { get; set; }
        public virtual DbSet<EsTmpDesigner> EsTmpDesigner { get; set; }
        public virtual DbSet<EsTmpPic> EsTmpPic { get; set; }
        public virtual DbSet<EsTmpProp> EsTmpProp { get; set; }
        public virtual DbSet<EsTmpSheet> EsTmpSheet { get; set; }
        public virtual DbSet<EsUrecent> EsUrecent { get; set; }
        public virtual DbSet<EsUruleFill> EsUruleFill { get; set; }
        public virtual DbSet<EsUruleFillRt> EsUruleFillRt { get; set; }
        public virtual DbSet<EsUser> EsUser { get; set; }
        public virtual DbSet<EsUserDataFilter> EsUserDataFilter { get; set; }
        public virtual DbSet<EsUserMgr> EsUserMgr { get; set; }
        public virtual DbSet<EsUserOption> EsUserOption { get; set; }
        public virtual DbSet<EsUserPwdHis> EsUserPwdHis { get; set; }
        public virtual DbSet<EsUserRegInfo> EsUserRegInfo { get; set; }
        public virtual DbSet<EsUserRole> EsUserRole { get; set; }
        public virtual DbSet<EsViewTable> EsViewTable { get; set; }
        public virtual DbSet<EsVirtualWi> EsVirtualWi { get; set; }
        public virtual DbSet<EsVwiGroup> EsVwiGroup { get; set; }
        public virtual DbSet<EsWfCase> EsWfCase { get; set; }
        public virtual DbSet<EsWfLink> EsWfLink { get; set; }
        public virtual DbSet<EsWfTask> EsWfTask { get; set; }
        public virtual DbSet<EsWftAuth> EsWftAuth { get; set; }
        public virtual DbSet<EsWftAuthScope> EsWftAuthScope { get; set; }
        public virtual DbSet<EsWftDataTrans> EsWftDataTrans { get; set; }
        public virtual DbSet<EsWftDeadline> EsWftDeadline { get; set; }
        public virtual DbSet<EsWftFld> EsWftFld { get; set; }
        public virtual DbSet<EsWftJointCond> EsWftJointCond { get; set; }
        public virtual DbSet<EsWftRoles> EsWftRoles { get; set; }
        public virtual DbSet<EsWftRules> EsWftRules { get; set; }
        public virtual DbSet<EsWiLink> EsWiLink { get; set; }
        public virtual DbSet<EsWitodo> EsWitodo { get; set; }
        public virtual DbSet<EsWorkFlow> EsWorkFlow { get; set; }
        public virtual DbSet<EsWorkItem> EsWorkItem { get; set; }
        public virtual DbSet<WeixinClock> WeixinClock { get; set; }
        public virtual DbSet<WeixinClockOptions> WeixinClockOptions { get; set; }
        public virtual DbSet<WeixinOptions> WeixinOptions { get; set; }
        public virtual DbSet<WeixinWorkPlan> WeixinWorkPlan { get; set; }
        public virtual DbSet<WeixinWorkPlanDetail> WeixinWorkPlanDetail { get; set; }
        public virtual DbSet<Wx异常说明> Wx异常说明 { get; set; }
        public virtual DbSet<业务类型> 业务类型 { get; set; }
        public virtual DbSet<人员档案> 人员档案 { get; set; }
        public virtual DbSet<付款单> 付款单 { get; set; }
        public virtual DbSet<发货> 发货 { get; set; }
        public virtual DbSet<发货Detail> 发货Detail { get; set; }
        public virtual DbSet<图形登记表> 图形登记表 { get; set; }
        public virtual DbSet<对账结算主表> 对账结算主表 { get; set; }
        public virtual DbSet<工资档案主表> 工资档案主表 { get; set; }
        public virtual DbSet<工资计算备份年月> 工资计算备份年月 { get; set; }
        public virtual DbSet<工资计算年月> 工资计算年月 { get; set; }
        public virtual DbSet<应付款对账单> 应付款对账单 { get; set; }
        public virtual DbSet<应收款对账单> 应收款对账单 { get; set; }
        public virtual DbSet<往来单位> 往来单位 { get; set; }
        public virtual DbSet<打卡登记> 打卡登记 { get; set; }
        public virtual DbSet<打卡记录> 打卡记录 { get; set; }
        public virtual DbSet<收款单> 收款单 { get; set; }
        public virtual DbSet<收货> 收货 { get; set; }
        public virtual DbSet<收货D> 收货D { get; set; }
        public virtual DbSet<月考勤汇总主表> 月考勤汇总主表 { get; set; }
        public virtual DbSet<物料分类> 物料分类 { get; set; }
        public virtual DbSet<物料登记> 物料登记 { get; set; }
        public virtual DbSet<物料登记Old> 物料登记Old { get; set; }
        public virtual DbSet<生产入库> 生产入库 { get; set; }
        public virtual DbSet<生产入库D> 生产入库D { get; set; }
        public virtual DbSet<生产型号> 生产型号 { get; set; }
        public virtual DbSet<考勤卡号变动> 考勤卡号变动 { get; set; }
        public virtual DbSet<考勤明细> 考勤明细 { get; set; }
        public virtual DbSet<考勤期间> 考勤期间 { get; set; }
        public virtual DbSet<计量单位主表> 计量单位主表 { get; set; }
        public virtual DbSet<请假登记> 请假登记 { get; set; }

        // Unable to generate entity type for table 'dbo.宿舍清单_D_历史记录'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.宿舍清单'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.外协加工_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.厂房登记'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.打卡记录_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.放假登记'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.调休登记'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.调休登记_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.费用计算'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.费用计算_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资新算_DETAIL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资新算_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.费用登记'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资规则_按工龄列表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.费用登记_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.费用登记_公用水费'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资规则_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资规则_按人员列表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.往来单位_单位类型'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.打卡登记_wi'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.木种登记'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.test_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.外协加工'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.test_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.人员工资变动'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.人员工资变动_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.销售发货_Old_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.销售发货_Old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.应收款查询_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.应收款查询_发货'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.外协回库'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.辅助表_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.应收款查询_退货'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.外协回库_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤汇总_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.应收款查询_收款'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资计算_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资计算备份_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.计量单位_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资计算备份_辅表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.人员调动历史'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工艺信息'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资计算_辅表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.图形一览_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.借款单'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.物料登记_Old_木种'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.数据词典'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.数据词典_D'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.图形一览_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.往来单位_账号'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.物料登记_木种描述'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤卡号变动_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤期间_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤期间_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤年度日历_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤年度日历_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.物料登记_素板处理'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤班次'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.考勤计算_班次'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.辅助表_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资项目_主表'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.工资档案_明细'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.月考勤汇总_明细'. Please see the warning messages.

        public PinhuaContext(DbContextOptions<PinhuaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EsAgentSet>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ES_AgentSet__14E61A24");

                entity.ToTable("ES_AgentSet");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DueTime).HasColumnType("datetime");

                entity.Property(e => e.RevokeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EsAgentUser>(entity =>
            {
                entity.HasKey(e => new { e.AgentUserId, e.UserId })
                    .HasName("PK__ES_AgentUser__16CE6296");

                entity.ToTable("ES_AgentUser");

                entity.Property(e => e.TmpIds)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TmpScope).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsCaseFormat>(entity =>
            {
                entity.HasKey(e => new { e.RcId, e.RtfId, e.R, e.C })
                    .HasName("PK__ES_CaseFormat__01342732");

                entity.ToTable("ES_CaseFormat");

                entity.Property(e => e.RcId)
                    .HasColumnName("rcId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RtfId)
                    .HasColumnName("rtfId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R)
                    .HasColumnName("r")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sh)
                    .HasColumnName("sh")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsCaseLink>(entity =>
            {
                entity.HasKey(e => new { e.RcId, e.LinkNo })
                    .HasName("PK__ES_CaseLink__74CE504D");

                entity.ToTable("ES_CaseLink");

                entity.Property(e => e.RcId).HasMaxLength(50);

                entity.Property(e => e.LinkNo).HasMaxLength(20);

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("image");

                entity.Property(e => e.Display)
                    .HasColumnName("display")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("fileType")
                    .HasMaxLength(20);

                entity.Property(e => e.IsNew)
                    .HasColumnName("isNew")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nfsfolder)
                    .HasColumnName("NFSFolder")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NfsfolderId).HasColumnName("NFSFolderId");

                entity.Property(e => e.PhyFileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.R)
                    .HasColumnName("r")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RelaFolder)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rng)
                    .HasColumnName("rng")
                    .HasMaxLength(20);

                entity.Property(e => e.RtfId).HasDefaultValueSql("0");

                entity.Property(e => e.SaveInto).HasDefaultValueSql("0");

                entity.Property(e => e.Sh)
                    .HasColumnName("sh")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsCasePic>(entity =>
            {
                entity.HasKey(e => new { e.RcId, e.PicNo })
                    .HasName("PK__ES_CasePic__6A50C1DA");

                entity.ToTable("ES_CasePic");

                entity.Property(e => e.RcId).HasMaxLength(50);

                entity.Property(e => e.PicNo).HasMaxLength(50);

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("fileType")
                    .HasMaxLength(20);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasColumnType("image");

                entity.Property(e => e.IsNew)
                    .HasColumnName("isNew")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nfsfolder)
                    .HasColumnName("NFSFolder")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NfsfolderId).HasColumnName("NFSFolderId");

                entity.Property(e => e.PhyFileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.R)
                    .HasColumnName("r")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RelaFolder)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rng)
                    .HasColumnName("rng")
                    .HasMaxLength(20);

                entity.Property(e => e.RtfId).HasDefaultValueSql("0");

                entity.Property(e => e.SaveInto).HasDefaultValueSql("0");

                entity.Property(e => e.Sh)
                    .HasColumnName("sh")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsDataDomain>(entity =>
            {
                entity.HasKey(e => e.DomainName)
                    .HasName("PK__ES_DataDomain__2DB1C7EE");

                entity.ToTable("ES_DataDomain");

                entity.Property(e => e.DomainName)
                    .HasColumnName("domainName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BaseType)
                    .HasColumnName("baseType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreUname)
                    .HasColumnName("CreUName")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.DftName)
                    .HasColumnName("dftName")
                    .HasMaxLength(20);

                entity.Property(e => e.DftValue)
                    .HasColumnName("dftValue")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DomainId).HasColumnName("domainId");

                entity.Property(e => e.InnerType)
                    .IsRequired()
                    .HasColumnName("innerType")
                    .HasMaxLength(20);

                entity.Property(e => e.IsIdentity)
                    .HasColumnName("isIdentity")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsUrl)
                    .HasColumnName("isUrl")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.L).HasColumnName("l");

                entity.Property(e => e.MatchPattern)
                    .HasColumnName("matchPattern")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OtherCanUpd).HasDefaultValueSql("1");

                entity.Property(e => e.PreDefined)
                    .HasColumnName("preDefined")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdTime).HasColumnType("datetime");

                entity.Property(e => e.UpdUname).HasMaxLength(50);
            });

            modelBuilder.Entity<EsDataField>(entity =>
            {
                entity.HasKey(e => e.FldId)
                    .HasName("PK__ES_DataField__477199F1");

                entity.ToTable("ES_DataField");

                entity.HasIndex(e => new { e.DtId, e.FldName })
                    .HasName("XAK1ES_DataField")
                    .IsUnique();

                entity.Property(e => e.FldId).ValueGeneratedNever();

                entity.Property(e => e.BaseType).HasDefaultValueSql("0");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Expr)
                    .HasColumnName("expr")
                    .HasMaxLength(1000);

                entity.Property(e => e.FldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IfPk).HasDefaultValueSql("0");

                entity.Property(e => e.InnerType).HasMaxLength(20);

                entity.Property(e => e.IsIdentity)
                    .HasColumnName("isIdentity")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.L)
                    .HasColumnName("l")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotNull).HasDefaultValueSql("0");

                entity.Property(e => e.PicType).HasMaxLength(8);

                entity.Property(e => e.RealName).HasMaxLength(200);
            });

            modelBuilder.Entity<EsDataRef>(entity =>
            {
                entity.HasKey(e => new { e.ObjType, e.ObjId, e.RefType, e.RefId, e.MainRefId })
                    .HasName("PK_ES_DataRef");

                entity.ToTable("ES_DataRef");

                entity.Property(e => e.ObjType)
                    .HasColumnName("objType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .HasMaxLength(20);

                entity.Property(e => e.RefType)
                    .HasColumnName("refType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RefId)
                    .HasColumnName("refId")
                    .HasMaxLength(20);

                entity.Property(e => e.MainRefId)
                    .HasColumnName("mainRefId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsDataSource>(entity =>
            {
                entity.HasKey(e => e.DsId)
                    .HasName("PK__ES_DataSource__2136E270");

                entity.ToTable("ES_DataSource");

                entity.HasIndex(e => e.DsName)
                    .HasName("XAK1ES_DataSource")
                    .IsUnique();

                entity.Property(e => e.DsId)
                    .HasColumnName("dsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreTime)
                    .HasColumnName("creTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DataSrc)
                    .HasColumnName("dataSrc")
                    .HasMaxLength(256);

                entity.Property(e => e.Db)
                    .IsRequired()
                    .HasColumnName("db")
                    .HasMaxLength(256);

                entity.Property(e => e.DbmsType)
                    .HasColumnName("dbmsType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DsName)
                    .IsRequired()
                    .HasColumnName("dsName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DsType)
                    .HasColumnName("dsType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LnkServerName)
                    .HasColumnName("lnkServerName")
                    .HasMaxLength(50);

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(256);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SupportTrans)
                    .HasColumnName("supportTrans")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<EsDataTable>(entity =>
            {
                entity.HasKey(e => e.DtId)
                    .HasName("PK__ES_DataTable__3A179ED3");

                entity.ToTable("ES_DataTable");

                entity.HasIndex(e => e.DtName)
                    .HasName("XAK1ES_DataTable")
                    .IsUnique();

                entity.Property(e => e.DtId).ValueGeneratedNever();

                entity.Property(e => e.BuiltIn).HasDefaultValueSql("0");

                entity.Property(e => e.Catalog)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUid).HasColumnName("creUid");

                entity.Property(e => e.CreUname)
                    .HasColumnName("creUname")
                    .HasMaxLength(50);

                entity.Property(e => e.DsName).HasMaxLength(50);

                entity.Property(e => e.DtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfCanMap).HasDefaultValueSql("1");

                entity.Property(e => e.IfReadOnly).HasDefaultValueSql("0");

                entity.Property(e => e.IsView).HasDefaultValueSql("0");

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RefName)
                    .IsRequired()
                    .HasMaxLength(2500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RefNameBak).HasMaxLength(2500);

                entity.Property(e => e.Schem)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.Property(e => e.UpdTime)
                    .HasColumnName("updTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdUid).HasColumnName("updUid");

                entity.Property(e => e.UpdUname)
                    .HasColumnName("updUname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EsDept>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__ES_Dept__1920BF5C");

                entity.ToTable("ES_Dept");

                entity.HasIndex(e => e.DeptNo)
                    .HasName("XAK1ES_Dept")
                    .IsUnique();

                entity.HasIndex(e => new { e.DeptName, e.SuperId })
                    .HasName("XAK2ES_Dept")
                    .IsUnique();

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.AdminName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeptNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DispName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsOrg).HasDefaultValueSql("0");

                entity.Property(e => e.IsOuter).HasDefaultValueSql("0");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SuperId).IsRequired();
            });

            modelBuilder.Entity<EsDeptAdmin>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.UserId })
                    .HasName("PK__ES_DeptAdmin__7A672E12");

                entity.ToTable("ES_DeptAdmin");
            });

            modelBuilder.Entity<EsDomainMatch>(entity =>
            {
                entity.HasKey(e => new { e.DomainName, e.Pattern })
                    .HasName("PK__ES_DomainMatch__373B3228");

                entity.ToTable("ES_DomainMatch");

                entity.Property(e => e.DomainName)
                    .HasColumnName("domainName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pattern).HasMaxLength(20);
            });

            modelBuilder.Entity<EsDtDesignAcl>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DtId })
                    .HasName("PK__ES_DtDesignAcl__1975C517");

                entity.ToTable("ES_DtDesignAcl");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Qry)
                    .HasColumnName("qry")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rewrite)
                    .HasColumnName("rewrite")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsFillStd>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_FillStd__4F12BBB9");

                entity.ToTable("ES_FillStd");

                entity.HasIndex(e => new { e.StdName, e.StdType })
                    .HasName("XAK1ES_FillStd")
                    .IsUnique();

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.BuiltIn).HasDefaultValueSql("0");

                entity.Property(e => e.BuiltInId).HasDefaultValueSql("0");

                entity.Property(e => e.CreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUid)
                    .HasColumnName("CreUId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreUname)
                    .HasColumnName("CreUName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DsType).HasDefaultValueSql("0");

                entity.Property(e => e.Expr).HasColumnType("ntext");

                entity.Property(e => e.Filter)
                    .HasMaxLength(1500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GrpExpr).HasColumnType("ntext");

                entity.Property(e => e.Mia).HasDefaultValueSql("0");

                entity.Property(e => e.OtherCanUpd).HasDefaultValueSql("1");

                entity.Property(e => e.StdName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StdType).HasDefaultValueSql("0");

                entity.Property(e => e.UpdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdUid)
                    .HasColumnName("UpdUId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdUname)
                    .HasColumnName("UpdUName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UseIsNull)
                    .HasColumnName("useIsNull")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<EsGlobalSafe>(entity =>
            {
                entity.ToTable("ES_GlobalSafe");

                entity.Property(e => e.Id).HasDefaultValueSql("1");

                entity.Property(e => e.AssDgnDeptSet).HasDefaultValueSql("0");

                entity.Property(e => e.AssDgnRoleSet).HasDefaultValueSql("0");

                entity.Property(e => e.AssDgnScope).HasDefaultValueSql("0");

                entity.Property(e => e.AssExcludeAdmin).HasDefaultValueSql("1");

                entity.Property(e => e.AssRwdeptSet)
                    .HasColumnName("AssRWDeptSet")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssRwroleSet)
                    .HasColumnName("AssRWRoleSet")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssRwscope)
                    .HasColumnName("AssRWScope")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AwakeLoginA).HasDefaultValueSql("0");

                entity.Property(e => e.AwakeLoginM).HasDefaultValueSql("1");

                entity.Property(e => e.DirectSql)
                    .HasColumnName("directSql")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PwdCharset)
                    .IsRequired()
                    .HasColumnType("char(20)");

                entity.Property(e => e.PwdCycle).HasDefaultValueSql("0");

                entity.Property(e => e.PwdErrTimes).HasDefaultValueSql("0");

                entity.Property(e => e.PwdLockExp).HasDefaultValueSql("0");

                entity.Property(e => e.PwdMaxDay).HasDefaultValueSql("0");

                entity.Property(e => e.PwdMinLen).HasDefaultValueSql("0");

                entity.Property(e => e.SpecialChars)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TmpProtectPwd).HasMaxLength(500);
            });

            modelBuilder.Entity<EsGrpRole>(entity =>
            {
                entity.HasKey(e => new { e.GId, e.RoleId })
                    .HasName("PK__ES_GrpRole__7C4F7684");

                entity.ToTable("ES_GrpRole");

                entity.Property(e => e.GId).HasColumnName("gId");
            });

            modelBuilder.Entity<EsGrpUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GId })
                    .HasName("PK__ES_GrpUser__7E37BEF6");

                entity.ToTable("ES_GrpUser");

                entity.Property(e => e.GId).HasColumnName("gId");
            });

            modelBuilder.Entity<EsHandoverJob>(entity =>
            {
                entity.HasKey(e => e.Hid)
                    .HasName("PK__ES_HandoverJob__5EDF0F2E");

                entity.ToTable("ES_HandoverJob");

                entity.Property(e => e.Hid)
                    .HasColumnName("hid")
                    .HasMaxLength(20);

                entity.Property(e => e.FromUserId).HasColumnName("fromUserId");

                entity.Property(e => e.FromUserName)
                    .IsRequired()
                    .HasColumnName("fromUserName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HTime)
                    .HasColumnName("hTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasColumnName("rtId")
                    .HasMaxLength(20);

                entity.Property(e => e.ToUserId).HasColumnName("toUserId");

                entity.Property(e => e.ToUserName)
                    .IsRequired()
                    .HasColumnName("toUserName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EsHandoverRc>(entity =>
            {
                entity.HasKey(e => new { e.Hid, e.RcId })
                    .HasName("PK__ES_HandoverRc__61BB7BD9");

                entity.ToTable("ES_HandoverRc");

                entity.Property(e => e.Hid)
                    .HasColumnName("hid")
                    .HasMaxLength(20);

                entity.Property(e => e.RcId).HasMaxLength(20);
            });

            modelBuilder.Entity<EsHandoverWi>(entity =>
            {
                entity.HasKey(e => new { e.Hid, e.WiId })
                    .HasName("PK__ES_HandoverWi__63A3C44B");

                entity.ToTable("ES_HandoverWi");

                entity.Property(e => e.Hid)
                    .HasColumnName("hid")
                    .HasMaxLength(20);

                entity.Property(e => e.WiId)
                    .HasColumnName("wiId")
                    .HasMaxLength(20);

                entity.Property(e => e.ComBy)
                    .HasColumnName("comBy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreBy)
                    .HasColumnName("creBy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Todo)
                    .HasColumnName("todo")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsHomeInfo>(entity =>
            {
                entity.ToTable("ES_HomeInfo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcctDay).HasColumnName("acctDay");

                entity.Property(e => e.AcctMonth)
                    .HasColumnName("acctMonth")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AcctMonthType)
                    .HasColumnName("acctMonth_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AcctTime).HasColumnName("acctTime");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200);

                entity.Property(e => e.AllowOuter)
                    .HasColumnName("allowOuter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowSendEmail)
                    .HasColumnName("allowSendEmail")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AppId)
                    .HasColumnName("appId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AppTitle)
                    .IsRequired()
                    .HasColumnName("appTitle")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppWindowCaption)
                    .IsRequired()
                    .HasColumnName("appWindowCaption")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttLimit)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AutoRegUser)
                    .HasColumnName("autoRegUser")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BankAccount)
                    .HasColumnName("bankAccount")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .HasColumnName("bankName")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseDesc)
                    .HasColumnName("caseDesc")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dbname)
                    .HasColumnName("DBName")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DomainUser)
                    .HasColumnName("domainUser")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailContent)
                    .HasColumnName("emailContent")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailPcontent)
                    .HasColumnName("EmailPContent")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailRcontent)
                    .HasColumnName("EmailRContent")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailSubject).HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FillSecurity)
                    .HasColumnName("fillSecurity")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideEditbox).HasDefaultValueSql("0");

                entity.Property(e => e.HideGridline).HasDefaultValueSql("0");

                entity.Property(e => e.HideHead).HasDefaultValueSql("0");

                entity.Property(e => e.JPerson)
                    .HasColumnName("jPerson")
                    .HasMaxLength(20);

                entity.Property(e => e.LdbaseDn)
                    .HasColumnName("LDBaseDN")
                    .HasMaxLength(255);

                entity.Property(e => e.LdbindDn)
                    .HasColumnName("LDBindDN")
                    .HasMaxLength(255);

                entity.Property(e => e.Ldenable)
                    .HasColumnName("LDEnable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ldhost)
                    .HasColumnName("LDHost")
                    .HasMaxLength(100);

                entity.Property(e => e.Ldpasswd)
                    .HasColumnName("LDPasswd")
                    .HasMaxLength(255);

                entity.Property(e => e.Ldport).HasColumnName("LDPort");

                entity.Property(e => e.MenuStyle).HasDefaultValueSql("0");

                entity.Property(e => e.RegPrompt)
                    .HasColumnName("regPrompt")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleGrp)
                    .HasColumnName("roleGrp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxNo)
                    .HasColumnName("taxNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(20);

                entity.Property(e => e.WebUrl)
                    .HasColumnName("webUrl")
                    .HasMaxLength(100);

                entity.Property(e => e.WfConExec)
                    .HasColumnName("wfConExec")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<EsIdDel>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.TheId })
                    .HasName("PK__ES_IdDel__29AC2CE0");

                entity.ToTable("ES_IdDel");

                entity.HasIndex(e => new { e.Prefix1, e.Ymd })
                    .HasName("XIE1ES_IdDel");

                entity.Property(e => e.TheId)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prefix1)
                    .HasColumnName("Prefix_1")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RcId)
                    .IsRequired()
                    .HasColumnName("rcId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ymd).HasColumnType("datetime");
            });

            modelBuilder.Entity<EsIdPart>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.PartId })
                    .HasName("PK__ES_IdPart__14D10B8B");

                entity.ToTable("ES_IdPart");

                entity.Property(e => e.PartId).HasDefaultValueSql("0");

                entity.Property(e => e.FixText)
                    .HasColumnName("fixText")
                    .HasMaxLength(20);

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.NumLen).HasColumnName("numLen");

                entity.Property(e => e.PartType)
                    .HasColumnName("partType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SysVar)
                    .HasColumnName("sysVar")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YmdStyle)
                    .HasColumnName("ymdStyle")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsIdRec>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.Prefix })
                    .HasName("PK__ES_IdRec__27C3E46E");

                entity.ToTable("ES_IdRec");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(200);

                entity.Property(e => e.GenDate)
                    .HasColumnName("genDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxNum).HasColumnName("maxNum");
            });

            modelBuilder.Entity<EsIdRule>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_IdRule__1E3A7A34");

                entity.ToTable("ES_IdRule");

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.GenAtSave).HasDefaultValueSql("0");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnName("pattern")
                    .HasMaxLength(200);

                entity.Property(e => e.Reuse)
                    .HasColumnName("reuse")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sample)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsIdUsed>(entity =>
            {
                entity.HasKey(e => new { e.TheId, e.StdId })
                    .HasName("PK__ES_IdUsed__2F650636");

                entity.ToTable("ES_IdUsed");

                entity.HasIndex(e => e.SesId)
                    .HasName("XIE2ES_IdUsed");

                entity.HasIndex(e => new { e.RcId, e.WiId, e.SesId })
                    .HasName("XIE1ES_IdUsed");

                entity.Property(e => e.TheId)
                    .HasColumnName("theId")
                    .HasMaxLength(200);

                entity.Property(e => e.Dd)
                    .HasColumnName("dd")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mm)
                    .HasColumnName("mm")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prefix1)
                    .HasColumnName("prefix_1")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RcId)
                    .HasColumnName("rcId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SesId)
                    .HasColumnName("sesId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WiId)
                    .HasColumnName("wiId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ymd)
                    .HasColumnName("ymd")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Yy)
                    .HasColumnName("yy")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsIdxFld>(entity =>
            {
                entity.HasKey(e => new { e.IdxId, e.FldId })
                    .HasName("XAK1ES_idxFld");

                entity.ToTable("ES_IdxFld");

                entity.Property(e => e.IdxId).HasColumnName("idxId");

                entity.Property(e => e.OrderBy).HasColumnName("orderBy");
            });

            modelBuilder.Entity<EsIdxTable>(entity =>
            {
                entity.HasKey(e => e.IdxId)
                    .HasName("PK__ES_IdxTable__2EFAF1E2");

                entity.ToTable("ES_IdxTable");

                entity.HasIndex(e => new { e.DtId, e.IdxName })
                    .HasName("XAK1ES_IdxTable")
                    .IsUnique();

                entity.Property(e => e.IdxId)
                    .HasColumnName("idxId")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdxName)
                    .IsRequired()
                    .HasColumnName("idxName")
                    .HasMaxLength(50);

                entity.Property(e => e.IsClustered)
                    .HasColumnName("isClustered")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsIndex)
                    .HasColumnName("isIndex")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsUnique)
                    .HasColumnName("isUnique")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsImContactGrp>(entity =>
            {
                entity.HasKey(e => new { e.GrpName, e.UserId })
                    .HasName("PK__ES_ImContactGrp__35A7EF71");

                entity.ToTable("ES_ImContactGrp");

                entity.Property(e => e.GrpName)
                    .HasColumnName("grpName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EsImUserContact>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ContactId })
                    .HasName("PK__ES_ImUserContact__4301EA8F");

                entity.ToTable("ES_ImUserContact");

                entity.Property(e => e.ContactId).HasColumnName("contactId");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GrpName)
                    .HasColumnName("grpName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EsImfastReply>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Num })
                    .HasName("PK__ES_IMFastReply__379037E3");

                entity.ToTable("ES_IMFastReply");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsImmsgLog>(entity =>
            {
                entity.HasKey(e => new { e.SendTime, e.SenderName })
                    .HasName("PK__ES_IMMsgLog__3A6CA48E");

                entity.ToTable("ES_IMMsgLog");

                entity.Property(e => e.SendTime)
                    .HasColumnName("sendTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SenderName)
                    .HasColumnName("senderName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MsgType)
                    .HasColumnName("msgType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recver)
                    .HasColumnName("recver")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecverName)
                    .HasColumnName("recverName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsJob>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.DeptId })
                    .HasName("PK__ES_Job__30F848ED");

                entity.ToTable("ES_Job");
            });

            modelBuilder.Entity<EsLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__ES_Log__07F6335A");

                entity.ToTable("ES_Log");

                entity.HasIndex(e => new { e.OpTime, e.UserId, e.UserName, e.UserLogin })
                    .HasName("XIE1ES_Log");

                entity.Property(e => e.LogId)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentLogin)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppNo).HasDefaultValueSql("0");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FuncName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogType).HasDefaultValueSql("0");

                entity.Property(e => e.OpDesc).HasMaxLength(500);

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RcId)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RtId)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SesId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SqlStmt).HasColumnType("ntext");

                entity.Property(e => e.UserId).HasDefaultValueSql("0");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WiId)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsNewRepBar>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RtId })
                    .HasName("PK__ES_NewRepBar__1209AD79");

                entity.ToTable("ES_NewRepBar");

                entity.Property(e => e.RtId).HasMaxLength(20);
            });

            modelBuilder.Entity<EsNfsauth>(entity =>
            {
                entity.HasKey(e => e.AuthId)
                    .HasName("PK__ES_NFSAuth__20ACD28B");

                entity.ToTable("ES_NFSAuth");

                entity.Property(e => e.AuthId)
                    .HasColumnName("authId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthType)
                    .HasColumnName("authType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreDir)
                    .HasColumnName("creDir")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreFile)
                    .HasColumnName("creFile")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DelDir)
                    .HasColumnName("delDir")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeleteFile)
                    .HasColumnName("deleteFile")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeptIds)
                    .HasColumnName("deptIds")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptScope)
                    .HasColumnName("deptScope")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownloadFile)
                    .HasColumnName("downloadFile")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListSub)
                    .HasColumnName("listSub")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RenameDir)
                    .HasColumnName("renameDir")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoleId).HasDefaultValueSql("0");

                entity.Property(e => e.UpdFile)
                    .HasColumnName("updFile")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsOuterLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PK__ES_OuterLink__190BB0C3");

                entity.ToTable("ES_OuterLink");

                entity.HasIndex(e => e.LinkName)
                    .HasName("XAK1ESOuterLink")
                    .IsUnique();

                entity.Property(e => e.LinkId)
                    .HasColumnName("linkId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreTime)
                    .HasColumnName("creTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUid).HasColumnName("creUid");

                entity.Property(e => e.CreUname)
                    .HasColumnName("creUName")
                    .HasMaxLength(50);

                entity.Property(e => e.IfOpen)
                    .HasColumnName("ifOpen")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IfShow)
                    .HasColumnName("ifShow")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LinkDesc).HasMaxLength(1500);

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasColumnName("linkName")
                    .HasMaxLength(50);

                entity.Property(e => e.Paras)
                    .HasColumnName("paras")
                    .HasMaxLength(200);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<EsOuterLinkAcl>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.RoleId })
                    .HasName("PK__ES_OuterLinkAcl__1DD065E0");

                entity.ToTable("ES_OuterLinkAcl");

                entity.Property(e => e.LinkId).HasColumnName("linkId");

                entity.Property(e => e.DeptIds)
                    .HasColumnName("deptIds")
                    .HasMaxLength(200);

                entity.Property(e => e.DeptScope)
                    .HasColumnName("deptScope")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsQryAcl>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.RoleId, e.UserId })
                    .HasName("PK__ES_QryAcl__1E5A75C5");

                entity.ToTable("ES_QryAcl");

                entity.Property(e => e.RoleId).HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuthType)
                    .HasColumnName("authType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeptIds)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptScope).HasDefaultValueSql("0");

                entity.Property(e => e.Export).HasDefaultValueSql("0");

                entity.Property(e => e.R).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<EsQryDesignAcl>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.StdId })
                    .HasName("PK__ES_QryDesignAcl__567ED357");

                entity.ToTable("ES_QryDesignAcl");

                entity.Property(e => e.Dgn).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRcAdd>(entity =>
            {
                entity.HasKey(e => e.RcId)
                    .HasName("PK__ES_RcAdd__2610A626");

                entity.ToTable("ES_RcAdd");

                entity.Property(e => e.RcId)
                    .HasColumnName("rcId")
                    .HasMaxLength(20);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("fileType")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nfsfolder)
                    .HasColumnName("NFSFolder")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NfsfolderId)
                    .HasColumnName("NFSFolderId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhyFileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelaFolder)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SaveInto).HasDefaultValueSql("0");

                entity.Property(e => e.XlsFile)
                    .HasColumnName("xlsFile")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<EsRepCase>(entity =>
            {
                entity.HasKey(e => e.RcId)
                    .HasName("PK__ES_RepCase__1A9EF37A");

                entity.ToTable("ES_RepCase");

                entity.HasIndex(e => e.CommitByDataWriter)
                    .HasName("XIE5ES_RepCase");

                entity.HasIndex(e => e.OpenBySesId)
                    .HasName("XIE2ES_RepCase");

                entity.HasIndex(e => new { e.RtId, e.LockInServer })
                    .HasName("XIE3ES_RepCase");

                entity.HasIndex(e => new { e.RtId, e.LstFiller })
                    .HasName("XIE7ES_RepCase");

                entity.HasIndex(e => new { e.RtId, e.SetNstateInServer })
                    .HasName("XIE4ES_RepCase");

                entity.HasIndex(e => new { e.RtId, e.FillUser, e.LstFiller })
                    .HasName("XIE6ES_RepCase");

                entity.HasIndex(e => new { e.RtId, e.FillUser, e.FillDept, e.FillDate, e.State })
                    .HasName("XIE1ES_RepCase");

                entity.Property(e => e.RcId)
                    .HasColumnName("rcId")
                    .HasMaxLength(20);

                entity.Property(e => e.BackUpdate)
                    .HasColumnName("backUpdate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommitByDataWriter)
                    .HasColumnName("commitByDataWriter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FillDate)
                    .HasColumnName("fillDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FillDept).HasColumnName("fillDept");

                entity.Property(e => e.FillDeptName)
                    .HasColumnName("fillDeptName")
                    .HasMaxLength(50);

                entity.Property(e => e.FillUser).HasColumnName("fillUser");

                entity.Property(e => e.FillUserName)
                    .HasColumnName("fillUserName")
                    .HasMaxLength(50);

                entity.Property(e => e.LockInServer)
                    .HasColumnName("lockInServer")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockState)
                    .HasColumnName("lockState")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LstFillDate)
                    .HasColumnName("lstFillDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LstFiller).HasColumnName("lstFiller");

                entity.Property(e => e.LstFillerName)
                    .IsRequired()
                    .HasColumnName("lstFillerName")
                    .HasMaxLength(50);

                entity.Property(e => e.NoticeState)
                    .HasColumnName("noticeState")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpenBy).HasColumnName("openBy");

                entity.Property(e => e.OpenByName)
                    .HasColumnName("openByName")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenBySesId).HasMaxLength(20);

                entity.Property(e => e.OpenState)
                    .HasColumnName("openState")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrintTime)
                    .HasColumnName("printTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RcDesc)
                    .HasColumnName("rcDesc")
                    .HasMaxLength(2000);

                entity.Property(e => e.ReplacerIdFill).HasColumnName("replacerId_fill");

                entity.Property(e => e.ReplacerIdLstFill).HasColumnName("replacerId_lstFill");

                entity.Property(e => e.ReplacerNameFill)
                    .HasColumnName("replacerName_fill")
                    .HasMaxLength(50);

                entity.Property(e => e.ReplacerNameLstFill)
                    .HasColumnName("replacerName_lstFill")
                    .HasMaxLength(50);

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.SetNstateInServer)
                    .HasColumnName("setNStateInServer")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WiId)
                    .IsRequired()
                    .HasColumnName("wiId")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__ES_Role__20C1E124");

                entity.ToTable("ES_Role");

                entity.HasIndex(e => e.RoleName)
                    .HasName("XAK1ES_Role")
                    .IsUnique();

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.BuiltIn).HasDefaultValueSql("0");

                entity.Property(e => e.BuiltinId).HasDefaultValueSql("0");

                entity.Property(e => e.CanAssign).HasDefaultValueSql("1");

                entity.Property(e => e.CreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUid).HasDefaultValueSql("0");

                entity.Property(e => e.CreUname)
                    .IsRequired()
                    .HasColumnName("CreUName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptScope).HasDefaultValueSql("0");

                entity.Property(e => e.HasSuper).HasDefaultValueSql("0");

                entity.Property(e => e.OtherCanUpd).HasDefaultValueSql("0");

                entity.Property(e => e.RoleDesc).HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoleSpec)
                    .HasColumnName("roleSpec")
                    .HasColumnType("ntext");

                entity.Property(e => e.SuperDeptType).HasDefaultValueSql("0");

                entity.Property(e => e.SuperRoleName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdUid).HasDefaultValueSql("0");

                entity.Property(e => e.UpdUname)
                    .HasColumnName("UpdUName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsRoleGroup>(entity =>
            {
                entity.HasKey(e => e.GId)
                    .HasName("PK__ES_RoleGroup__00200768");

                entity.ToTable("ES_RoleGroup");

                entity.Property(e => e.GId)
                    .HasColumnName("gId")
                    .ValueGeneratedNever();

                entity.Property(e => e.GName)
                    .IsRequired()
                    .HasColumnName("gName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EsRtfIdbind>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.RtfId, e.PartId })
                    .HasName("PK__ES_RTF_IDBIND__049AA3C2");

                entity.ToTable("ES_RTF_IDBIND");

                entity.Property(e => e.StdId).HasColumnName("stdId");

                entity.Property(e => e.RtfId).HasColumnName("rtfId");

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.BindRtfId).HasColumnName("bindRtfId");
            });

            modelBuilder.Entity<EsRtfLink>(entity =>
            {
                entity.HasKey(e => new { e.RtfId, e.No })
                    .HasName("PK__ES_RtfLink__11D4A34F");

                entity.ToTable("ES_RtfLink");

                entity.Property(e => e.EditMode)
                    .HasColumnName("editMode")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkIgnoreFill).HasDefaultValueSql("1");

                entity.Property(e => e.Para).HasMaxLength(1000);

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<EsRtfStd>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.RtfId })
                    .HasName("PK__ES_RTF_STD__0682EC34");

                entity.ToTable("ES_RTF_STD");

                entity.Property(e => e.StdId).HasColumnName("stdId");

                entity.Property(e => e.RtfId)
                    .HasColumnName("rtfId")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AutoIdGen)
                    .HasColumnName("autoIdGen")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Filter)
                    .HasColumnName("filter")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FilterSpec)
                    .HasColumnName("filterSpec")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FilterSpecListGrp)
                    .HasColumnName("filterSpecListGrp")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ListFill)
                    .HasColumnName("listFill")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ListMultiSel)
                    .HasColumnName("listMultiSel")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewIdBindChg)
                    .HasColumnName("newIdBindChg")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.NoBindNoId)
                    .HasColumnName("noBindNoId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpCond)
                    .HasColumnName("opCond")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StdValRefresh)
                    .HasColumnName("stdValRefresh")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TreeSeparateFill)
                    .HasColumnName("treeSeparateFill")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRtfs>(entity =>
            {
                entity.HasKey(e => e.RtfId)
                    .HasName("PK__ES_RTFS__762C88DA");

                entity.ToTable("ES_RTFS");

                entity.HasIndex(e => e.StdId)
                    .HasName("XIE1ES_RTFS");

                entity.HasIndex(e => new { e.RtId, e.FldId })
                    .HasName("XAK1ES_RTFS")
                    .IsUnique();

                entity.Property(e => e.RtfId).ValueGeneratedNever();

                entity.Property(e => e.DataRng)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FldAlias).HasMaxLength(100);

                entity.Property(e => e.FldPrompt).HasMaxLength(1500);

                entity.Property(e => e.FldSpecial).HasDefaultValueSql("0");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GrpNo).HasDefaultValueSql("0");

                entity.Property(e => e.GrpOrdType).HasDefaultValueSql("0");

                entity.Property(e => e.HeadMark).HasDefaultValueSql("0");

                entity.Property(e => e.IfHidden).HasDefaultValueSql("0");

                entity.Property(e => e.InExprTmpLock)
                    .HasColumnName("inExprTmpLock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InExprTmpNotice)
                    .HasColumnName("inExprTmpNotice")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InExprWfLink)
                    .HasColumnName("inExprWfLink")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsFindFld).HasDefaultValueSql("1");

                entity.Property(e => e.IsIndex).HasDefaultValueSql("0");

                entity.Property(e => e.IsMerge)
                    .HasColumnName("isMerge")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkRtFld).HasDefaultValueSql("0");

                entity.Property(e => e.LinkType).HasDefaultValueSql("0");

                entity.Property(e => e.ListFill).HasMaxLength(1500);

                entity.Property(e => e.ListGrpSpec).HasMaxLength(1500);

                entity.Property(e => e.Locked).HasDefaultValueSql("0");

                entity.Property(e => e.LogUpd).HasDefaultValueSql("0");

                entity.Property(e => e.NoClear).HasDefaultValueSql("0");

                entity.Property(e => e.NotNull).HasDefaultValueSql("0");

                entity.Property(e => e.NotPrint).HasDefaultValueSql("0");

                entity.Property(e => e.OccurNo).HasDefaultValueSql("1");

                entity.Property(e => e.OrdNo).HasDefaultValueSql("0");

                entity.Property(e => e.OrdType).HasDefaultValueSql("0");

                entity.Property(e => e.Overprint).HasDefaultValueSql("0");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SheetId).HasDefaultValueSql("1");

                entity.Property(e => e.StdLstIsMultiSel).HasDefaultValueSql("0");

                entity.Property(e => e.StdType)
                    .HasColumnName("stdType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StdValRefresh).HasDefaultValueSql("0");

                entity.Property(e => e.TreeFilter).HasMaxLength(1500);

                entity.Property(e => e.TreeFilterSpec).HasMaxLength(1500);

                entity.Property(e => e.TreeSeparateFill).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRtts>(entity =>
            {
                entity.HasKey(e => e.RttId)
                    .HasName("PK__ES_RTTS__6D9742D9");

                entity.ToTable("ES_RTTS");

                entity.HasIndex(e => new { e.RtId, e.DtId })
                    .HasName("XAK1ES_RTTS")
                    .IsUnique();

                entity.Property(e => e.RttId).ValueGeneratedNever();

                entity.Property(e => e.Alias).HasMaxLength(200);

                entity.Property(e => e.Extendable).HasDefaultValueSql("0");

                entity.Property(e => e.Extendable1).HasDefaultValueSql("0");

                entity.Property(e => e.IfHidden).HasDefaultValueSql("0");

                entity.Property(e => e.Num).HasDefaultValueSql("0");

                entity.Property(e => e.OccurNo).HasDefaultValueSql("1");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SheetId).HasDefaultValueSql("1");

                entity.Property(e => e.Style).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRuleDelCase>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleDelCase__4DB4832C");

                entity.ToTable("ES_RuleDelCase");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.RtIdDest)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleDelDetail>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleDelDetail__48EFCE0F");

                entity.ToTable("ES_RuleDelDetail");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.RtIdDest)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleFill>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RtfIdDest })
                    .HasName("PK__ES_RuleFill__36D11DD4");

                entity.ToTable("ES_RuleFill");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.Expr)
                    .IsRequired()
                    .HasColumnName("expr")
                    .HasMaxLength(3000);

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ord)
                    .HasColumnName("ord")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRuleInsDetail>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleInsDetail__4AD81681");

                entity.ToTable("ES_RuleInsDetail");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.IsRollBack)
                    .HasColumnName("isRollBack")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Matcher)
                    .HasColumnName("matcher")
                    .HasMaxLength(3000);

                entity.Property(e => e.RtIdDest)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleInsDt>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleInsDT__4F9CCB9E");

                entity.ToTable("ES_RuleInsDT");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.JoinCond)
                    .HasColumnName("joinCond")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sdts)
                    .HasColumnName("SDTs")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<EsRuleNewCase>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleNewCase__51851410");

                entity.ToTable("ES_RuleNewCase");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.FillerType).HasDefaultValueSql("0");

                entity.Property(e => e.IfQuickOpen)
                    .HasColumnName("ifQuickOpen")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtIdDest)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleQry>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleQry__2C538F61");

                entity.ToTable("ES_RuleQry");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.AppHide)
                    .HasColumnName("appHide")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AppMenu)
                    .HasColumnName("appMenu")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExecConSpec)
                    .HasColumnName("execConSpec")
                    .HasMaxLength(1500);

                entity.Property(e => e.ExecCondition)
                    .HasColumnName("execCondition")
                    .HasMaxLength(1500);

                entity.Property(e => e.FillAtTop).HasDefaultValueSql("0");

                entity.Property(e => e.FillIfNotMatch).HasDefaultValueSql("0");

                entity.Property(e => e.IfClearDataFld)
                    .HasColumnName("ifClearDataFld")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfDelRow)
                    .HasColumnName("ifDelRow")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfReOrder)
                    .HasColumnName("ifReOrder")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InputVars)
                    .HasColumnName("inputVars")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDistinct)
                    .HasColumnName("isDistinct")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinCond)
                    .HasColumnName("joinCond")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sdts)
                    .HasColumnName("SDTs")
                    .HasMaxLength(500);

                entity.Property(e => e.TopN)
                    .HasColumnName("topN")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsRuleRelDt>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.DtId })
                    .HasName("PK__ES_RuleRel_DT__3C89F72A");

                entity.ToTable("ES_RuleRel_DT");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleRelDtfld>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.FldId })
                    .HasName("PK__ES_RuleRel_DTFld__3E723F9C");

                entity.ToTable("ES_RuleRel_DTFld");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleRelRtfs>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RtfId })
                    .HasName("PK__ES_RuleRel_Rtfs__405A880E");

                entity.ToTable("ES_RuleRel_Rtfs");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleRelRtts>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RttId })
                    .HasName("PK__ES_RuleRel_Rtts__4242D080");

                entity.ToTable("ES_RuleRel_Rtts");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRuleUpd>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_RuleUpd__442B18F2");

                entity.ToTable("ES_RuleUpd");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsRules>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__ES_Rules__25A691D2");

                entity.ToTable("ES_Rules");

                entity.HasIndex(e => new { e.RtId, e.RuleName })
                    .HasName("XAK1Rules")
                    .IsUnique();

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.AppOrder)
                    .HasColumnName("appOrder")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreTime).HasColumnType("datetime");

                entity.Property(e => e.CreUname)
                    .HasColumnName("CreUName")
                    .HasMaxLength(50);

                entity.Property(e => e.Dbtype)
                    .HasColumnName("DBType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FilterCond)
                    .HasColumnName("filterCond")
                    .HasColumnType("ntext");

                entity.Property(e => e.Op)
                    .IsRequired()
                    .HasColumnName("op")
                    .HasMaxLength(50);

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasColumnName("rtId")
                    .HasMaxLength(20);

                entity.Property(e => e.RuleDesc)
                    .HasColumnName("ruleDesc")
                    .HasColumnType("ntext");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasColumnName("ruleName")
                    .HasMaxLength(100);

                entity.Property(e => e.RuleSpec)
                    .HasColumnName("ruleSpec")
                    .HasColumnType("ntext");

                entity.Property(e => e.RuleType)
                    .HasColumnName("ruleType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TIds)
                    .HasColumnName("tIds")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdTime).HasColumnType("datetime");

                entity.Property(e => e.UpdUname)
                    .HasColumnName("UpdUName")
                    .HasMaxLength(50);

                entity.Property(e => e.UseIsNull)
                    .HasColumnName("useIsNull")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Ver).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsSheetProp>(entity =>
            {
                entity.HasKey(e => new { e.RtId, e.SheetId, e.PropType, e.PropName })
                    .HasName("PK__ES_SheetProp__662B2B3B");

                entity.ToTable("ES_SheetProp");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.SheetId).HasDefaultValueSql("1");

                entity.Property(e => e.PropName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisplayValue).HasMaxLength(128);

                entity.Property(e => e.PropValue1).HasMaxLength(128);

                entity.Property(e => e.PropValue2).HasMaxLength(128);
            });

            modelBuilder.Entity<EsSmFill>(entity =>
            {
                entity.HasKey(e => e.CmdId)
                    .HasName("PK__ES_SmFill__0BB1B5A5");

                entity.ToTable("ES_SmFill");

                entity.Property(e => e.CmdId).ValueGeneratedNever();

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SepaF).HasMaxLength(10);

                entity.Property(e => e.SepaR).HasMaxLength(10);

                entity.Property(e => e.SepaT).HasMaxLength(10);

                entity.Property(e => e.Spec)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<EsSmQry>(entity =>
            {
                entity.HasKey(e => e.CmdId)
                    .HasName("PK__ES_SmQry__0D99FE17");

                entity.ToTable("ES_SmQry");

                entity.Property(e => e.CmdId).ValueGeneratedNever();

                entity.Property(e => e.Datasrc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FillManner)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filter).HasColumnType("text");

                entity.Property(e => e.JoinCond).HasMaxLength(1000);

                entity.Property(e => e.QryDesc)
                    .IsRequired()
                    .HasColumnName("qryDesc")
                    .HasColumnType("text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.QryParams)
                    .HasColumnName("qryParams")
                    .HasMaxLength(500);

                entity.Property(e => e.QrySpec)
                    .IsRequired()
                    .HasColumnName("qrySpec")
                    .HasColumnType("text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RtnSyntax)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsSmQryAcl>(entity =>
            {
                entity.HasKey(e => new { e.CmdId, e.RoleId })
                    .HasName("PK__ES_SmQryAcl__1446FBA6");

                entity.ToTable("ES_SmQryAcl");

                entity.Property(e => e.DeptIds).HasMaxLength(200);

                entity.Property(e => e.DeptScope).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsSmQryDesignAcl>(entity =>
            {
                entity.HasKey(e => new { e.CmdId, e.UserId })
                    .HasName("PK__ES_SmQryDesignAc__17236851");

                entity.ToTable("ES_SmQryDesignAcl");
            });

            modelBuilder.Entity<EsStdComp>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_StdComp__68687968");

                entity.ToTable("ES_StdComp");

                entity.Property(e => e.StdId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EsStdFld>(entity =>
            {
                entity.HasKey(e => new { e.FldId, e.StdId, e.Op })
                    .HasName("PK__ES_StdFld__6225902D");

                entity.ToTable("ES_StdFld");

                entity.Property(e => e.Op)
                    .HasColumnName("op")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DispName).HasMaxLength(50);

                entity.Property(e => e.DispTotal)
                    .HasColumnName("dispTotal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GrpInList).HasDefaultValueSql("0");

                entity.Property(e => e.HiddenInList).HasDefaultValueSql("0");

                entity.Property(e => e.IsFilter).HasDefaultValueSql("0");

                entity.Property(e => e.IsReturn).HasDefaultValueSql("0");

                entity.Property(e => e.Num).HasDefaultValueSql("0");

                entity.Property(e => e.OrdType).HasDefaultValueSql("0");

                entity.Property(e => e.TreeFldId).HasDefaultValueSql("0");

                entity.Property(e => e.TreeId).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsStdList>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_StdList__4183B671");

                entity.ToTable("ES_StdList");

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.HasGrp).HasDefaultValueSql("0");

                entity.Property(e => e.IsDistinct).HasDefaultValueSql("1");

                entity.Property(e => e.NoPage)
                    .HasColumnName("noPage")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowByFilter)
                    .HasColumnName("showByFilter")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsStdQry>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_StdQry__473C8FC7");

                entity.ToTable("ES_StdQry");

                entity.HasIndex(e => e.QryNo)
                    .HasName("XAK1ES_StdQry")
                    .IsUnique();

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.AutoRmd)
                    .HasColumnName("autoRmd")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasGrp)
                    .HasColumnName("hasGrp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QryNo)
                    .IsRequired()
                    .HasColumnName("qryNo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RmdByEmail)
                    .HasColumnName("rmdByEmail")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RmdByIm)
                    .HasColumnName("rmdByIm")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RmdBySm)
                    .HasColumnName("rmdBySm")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RmdCon)
                    .HasColumnName("rmdCon")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaskId).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsStdTree>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__ES_StdTree__3AD6B8E2");

                entity.ToTable("ES_StdTree");

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.KeyLen)
                    .HasColumnName("keyLen")
                    .HasMaxLength(100);

                entity.Property(e => e.LeafOnly)
                    .HasColumnName("leafOnly")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MultiSelect)
                    .HasColumnName("multiSelect")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ord)
                    .HasColumnName("ord")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrdBy)
                    .HasColumnName("ordBy")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Style)
                    .HasColumnName("style")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsStdValSet>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.Vno })
                    .HasName("PK__ES_StdValSet__5F492382");

                entity.ToTable("ES_StdValSet");

                entity.Property(e => e.Vno)
                    .HasColumnName("VNo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fk).HasMaxLength(500);

                entity.Property(e => e.K).HasMaxLength(500);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<EsSysId>(entity =>
            {
                entity.HasKey(e => e.IdName)
                    .HasName("PK__ES_SysId__7C8480AE");

                entity.ToTable("ES_SysId");

                entity.Property(e => e.IdName).ValueGeneratedNever();

                entity.Property(e => e.IdDesc)
                    .HasColumnName("idDesc")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaxDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MaxId).HasDefaultValueSql("0");

                entity.Property(e => e.NoNum).HasDefaultValueSql("0");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsSysIdS>(entity =>
            {
                entity.HasKey(e => new { e.IdName, e.IdDate })
                    .HasName("PK__ES_SysId_s__03317E3D");

                entity.ToTable("ES_SysId_s");

                entity.Property(e => e.IdDate)
                    .HasColumnName("idDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxId)
                    .HasColumnName("maxId")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmp>(entity =>
            {
                entity.HasKey(e => e.RtId)
                    .HasName("PK__ES_Tmp__31B762FC");

                entity.ToTable("ES_Tmp");

                entity.HasIndex(e => e.RtName)
                    .HasName("XAK2ES_Tmp")
                    .IsUnique();

                entity.HasIndex(e => e.RtNo)
                    .HasName("XAK1ES_Tmp")
                    .IsUnique();

                entity.HasIndex(e => new { e.RtName, e.ClassId })
                    .HasName("XIE1ES_Tmp");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.CheckoutBy).HasDefaultValueSql("0");

                entity.Property(e => e.CheckoutByName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileFormat)
                    .HasColumnName("fileFormat")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HasNoticeExp)
                    .HasColumnName("hasNoticeExp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfCheckout).HasDefaultValueSql("0");

                entity.Property(e => e.IfLockByExp).HasDefaultValueSql("0");

                entity.Property(e => e.IfMakeWeb)
                    .HasColumnName("ifMakeWeb")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IndexDesc)
                    .HasColumnName("indexDesc")
                    .HasMaxLength(1000);

                entity.Property(e => e.IndexSpec)
                    .HasColumnName("indexSpec")
                    .HasMaxLength(1000);

                entity.Property(e => e.IndexType)
                    .HasColumnName("indexType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockDependDate).HasDefaultValueSql("0");

                entity.Property(e => e.LockExpSpec).HasMaxLength(2000);

                entity.Property(e => e.LockExpText).HasMaxLength(2000);

                entity.Property(e => e.ProtectType).HasDefaultValueSql("1");

                entity.Property(e => e.QryOnly).HasDefaultValueSql("0");

                entity.Property(e => e.RtName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RtNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RtPwd).HasMaxLength(500);

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.Property(e => e.UpdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdUname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ver)
                    .HasColumnName("ver")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmpAcl>(entity =>
            {
                entity.HasKey(e => e.AuthId)
                    .HasName("PK__ES_TmpAcl__69FBBC1F");

                entity.ToTable("ES_TmpAcl");

                entity.Property(e => e.AuthId).ValueGeneratedNever();

                entity.Property(e => e.AuthType).HasDefaultValueSql("0");

                entity.Property(e => e.ByFlds)
                    .HasColumnName("byFlds")
                    .HasMaxLength(200);

                entity.Property(e => e.C).HasDefaultValueSql("1");

                entity.Property(e => e.D).HasDefaultValueSql("1");

                entity.Property(e => e.DeptIds)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptScope).HasDefaultValueSql("0");

                entity.Property(e => e.ExpDesc)
                    .HasColumnName("expDesc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpSpec)
                    .HasColumnName("expSpec")
                    .HasColumnType("ntext");

                entity.Property(e => e.Export).HasDefaultValueSql("1");

                entity.Property(e => e.FillBySuper).HasDefaultValueSql("0");

                entity.Property(e => e.FillFlds)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FillbySub).HasDefaultValueSql("0");

                entity.Property(e => e.HiddenFlds)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lock)
                    .HasColumnName("lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PartinProc).HasDefaultValueSql("0");

                entity.Property(e => e.Prt).HasDefaultValueSql("1");

                entity.Property(e => e.R).HasDefaultValueSql("1");

                entity.Property(e => e.ReadScope).HasDefaultValueSql("0");

                entity.Property(e => e.RoleId).HasDefaultValueSql("0");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SaveLocal).HasDefaultValueSql("1");

                entity.Property(e => e.SelfUpd).HasDefaultValueSql("1");

                entity.Property(e => e.U).HasDefaultValueSql("1");

                entity.Property(e => e.Unlock)
                    .HasColumnName("unlock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmpAdd>(entity =>
            {
                entity.HasKey(e => e.RtId)
                    .HasName("PK__ES_TmpAdd__5AB9788F");

                entity.ToTable("ES_TmpAdd");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.Css)
                    .HasColumnName("css")
                    .HasColumnType("image");

                entity.Property(e => e.TmpFile).HasColumnType("image");
            });

            modelBuilder.Entity<EsTmpClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK__ES_TmpClass__2645B050");

                entity.ToTable("ES_TmpClass");

                entity.HasIndex(e => new { e.SuperId, e.ClassName })
                    .HasName("XAK1ES_TmpClass")
                    .IsUnique();

                entity.Property(e => e.ClassId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreUname)
                    .HasColumnName("CreUName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrdNum).HasDefaultValueSql("0");

                entity.Property(e => e.OrdPath)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OtherCanUpd).HasDefaultValueSql("1");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SuperId).IsRequired();

                entity.Property(e => e.UpdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdUname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsTmpDesigner>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RtId })
                    .HasName("PK__ES_TmpDesigner__7E02B4CC");

                entity.ToTable("ES_TmpDesigner");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.Dgn).HasDefaultValueSql("0");

                entity.Property(e => e.Map).HasDefaultValueSql("0");

                entity.Property(e => e.Qry).HasDefaultValueSql("0");

                entity.Property(e => e.Rewrite).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmpPic>(entity =>
            {
                entity.HasKey(e => e.PicNo)
                    .HasName("PK__ES_TmpPic__04AFB25B");

                entity.ToTable("ES_TmpPic");

                entity.Property(e => e.PicNo).HasMaxLength(20);

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("fileType")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.H)
                    .HasColumnName("h")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasColumnType("image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsMove)
                    .HasColumnName("isMove")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsNew)
                    .HasColumnName("isNew")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.L)
                    .HasColumnName("l")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R)
                    .HasColumnName("r")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sh)
                    .HasColumnName("sh")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.T)
                    .HasColumnName("t")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseType)
                    .HasColumnName("useType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.W)
                    .HasColumnName("w")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmpProp>(entity =>
            {
                entity.HasKey(e => e.RtId)
                    .HasName("PK__ES_TmpProp__45BE5BA9");

                entity.ToTable("ES_TmpProp");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.CanDownload).HasDefaultValueSql("0");

                entity.Property(e => e.CheckDataType).HasDefaultValueSql("0");

                entity.Property(e => e.CheckValid).HasDefaultValueSql("0");

                entity.Property(e => e.CloseAfterSave).HasDefaultValueSql("0");

                entity.Property(e => e.CycleType).HasDefaultValueSql("0");

                entity.Property(e => e.LocalUnprotect).HasDefaultValueSql("0");

                entity.Property(e => e.LockFormula).HasDefaultValueSql("1");

                entity.Property(e => e.NoPaste).HasDefaultValueSql("0");

                entity.Property(e => e.NoSaveNoPrint).HasDefaultValueSql("0");

                entity.Property(e => e.PasteVonly)
                    .HasColumnName("PasteVOnly")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PopWinOnSave).HasDefaultValueSql("0");

                entity.Property(e => e.PromptNext).HasDefaultValueSql("1");

                entity.Property(e => e.PromptPrint).HasDefaultValueSql("0");

                entity.Property(e => e.QrySaveLocal)
                    .HasColumnName("qrySaveLocal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SaveFile).HasDefaultValueSql("0");

                entity.Property(e => e.SelLockedCell).HasDefaultValueSql("0");

                entity.Property(e => e.SetFormat).HasDefaultValueSql("1");

                entity.Property(e => e.StatCycle).HasDefaultValueSql("0");

                entity.Property(e => e.TmpKind).HasDefaultValueSql("0");

                entity.Property(e => e.WebFillable).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsTmpSheet>(entity =>
            {
                entity.HasKey(e => new { e.RtId, e.SheetId })
                    .HasName("PK__ES_TmpSheet__5CA1C101");

                entity.ToTable("ES_TmpSheet");

                entity.Property(e => e.RtId).HasMaxLength(20);

                entity.Property(e => e.SheetId).HasDefaultValueSql("1");

                entity.Property(e => e.C1).HasDefaultValueSql("0");

                entity.Property(e => e.Cn).HasDefaultValueSql("0");

                entity.Property(e => e.IfProtect).HasDefaultValueSql("1");

                entity.Property(e => e.R1).HasDefaultValueSql("0");

                entity.Property(e => e.Rn).HasDefaultValueSql("0");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SheetNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsUrecent>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RecType, e.RecNo })
                    .HasName("PK__ES_URecent__5832119F");

                entity.ToTable("ES_URecent");

                entity.Property(e => e.RecType).HasMaxLength(50);

                entity.Property(e => e.Pk1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EsUruleFill>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.FldIdDest })
                    .HasName("PK__ES_URuleFill__46136164");

                entity.ToTable("ES_URuleFill");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.Expr)
                    .HasColumnName("expr")
                    .HasMaxLength(3000);

                entity.Property(e => e.IsUnique)
                    .HasColumnName("isUnique")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUruleFillRt>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RtfIdDest })
                    .HasName("PK__ES_URuleFillRt__5555A4F4");

                entity.ToTable("ES_URuleFillRt");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);

                entity.Property(e => e.Expr)
                    .HasColumnName("expr")
                    .HasMaxLength(3000);

                entity.Property(e => e.IfIndex)
                    .HasColumnName("ifIndex")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ES_User__32E0915F");

                entity.ToTable("ES_User");

                entity.HasIndex(e => e.DeptId)
                    .HasName("XIE1ES_User");

                entity.HasIndex(e => e.UserLogin)
                    .HasName("XAK1ES_User")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("XAK2ES_User")
                    .IsUnique();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.AccState).HasDefaultValueSql("0");

                entity.Property(e => e.AddPwd)
                    .HasColumnName("addPwd")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BuiltIn).HasDefaultValueSql("0");

                entity.Property(e => e.DispName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Domain)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImSignature)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IpList).HasMaxLength(500);

                entity.Property(e => e.IsOuter).HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LdDn)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoAgent)
                    .HasColumnName("noAgent")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Oaddress)
                    .HasColumnName("OAddress")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ocompany)
                    .HasColumnName("OCompany")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Otelephone)
                    .HasColumnName("OTelephone")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OtptokenId)
                    .HasColumnName("OTPTokenId")
                    .HasMaxLength(20);

                entity.Property(e => e.Ozipcode)
                    .HasColumnName("OZipcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PwdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PwdNoChange)
                    .HasColumnName("pwdNoChange")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegState).HasDefaultValueSql("0");

                entity.Property(e => e.RoleNames)
                    .HasColumnName("roleNames")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SynLogin).HasDefaultValueSql("1");

                entity.Property(e => e.UseOtpauth)
                    .HasColumnName("useOTPAuth")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Utype)
                    .HasColumnName("UType")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUserDataFilter>(entity =>
            {
                entity.HasKey(e => e.Dfid)
                    .HasName("PK__ES_UserDataFilte__5A1A5A11");

                entity.ToTable("ES_UserDataFilter");

                entity.HasIndex(e => e.FilterName)
                    .HasName("XAK1ES_UserDataFilter")
                    .IsUnique();

                entity.Property(e => e.Dfid)
                    .HasColumnName("DFId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataFilter).HasColumnType("ntext");

                entity.Property(e => e.DataType)
                    .HasColumnName("dataType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FilterDesc).HasMaxLength(500);

                entity.Property(e => e.FilterName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TId)
                    .HasColumnName("tId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TvType)
                    .HasColumnName("tvType")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUserMgr>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ES_UserMgr__66603565");

                entity.ToTable("ES_UserMgr");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.MgrType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUserOption>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ES_UserOption__5165187F");

                entity.ToTable("ES_UserOption");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.DftRtId).HasMaxLength(20);

                entity.Property(e => e.DftWin).HasDefaultValueSql("1");

                entity.Property(e => e.ExitOnNewLogin)
                    .HasColumnName("exitOnNewLogin")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideEditBox)
                    .HasColumnName("hideEditBox")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideGridline)
                    .HasColumnName("hideGridline")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideHead)
                    .HasColumnName("hideHead")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MenuStyle).HasDefaultValueSql("0");

                entity.Property(e => e.MoveDirect).HasDefaultValueSql("0");

                entity.Property(e => e.MultiPage)
                    .HasColumnName("multiPage")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PageSize)
                    .HasColumnName("pageSize")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.QryAutoFill).HasDefaultValueSql("1");

                entity.Property(e => e.ShowDoneWi)
                    .HasColumnName("showDoneWi")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowField)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TimeOnReport).HasDefaultValueSql("0");

                entity.Property(e => e.TimeOnWork).HasDefaultValueSql("0");

                entity.Property(e => e.UseDateObj).HasDefaultValueSql("1");

                entity.Property(e => e.UseSms).HasDefaultValueSql("0");

                entity.Property(e => e.UseTreeObj).HasDefaultValueSql("1");

                entity.Property(e => e.WaQuicken)
                    .HasColumnName("waQuicken")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WiDateNum)
                    .HasColumnName("wiDateNum")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WiDateUnit)
                    .HasColumnName("wiDateUnit")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsUserPwdHis>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CreTime })
                    .HasName("PK__ES_UserPwdHis__693CA210");

                entity.ToTable("ES_UserPwdHis");

                entity.Property(e => e.CreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EsUserRegInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ES_UserRegInfo__6D0D32F4");

                entity.ToTable("ES_UserRegInfo");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DealTime).HasColumnType("datetime");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsOuter).HasDefaultValueSql("0");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoPassReason).HasMaxLength(1000);

                entity.Property(e => e.RegState).HasDefaultValueSql("0");

                entity.Property(e => e.RegTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserDesc).HasMaxLength(1000);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Zipcode).HasMaxLength(20);
            });

            modelBuilder.Entity<EsUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__ES_UserRole__4D94879B");

                entity.ToTable("ES_UserRole");

                entity.Property(e => e.DeptIds)
                    .HasColumnName("deptIds")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeptScope)
                    .HasColumnName("deptScope")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsViewTable>(entity =>
            {
                entity.HasKey(e => e.DtId)
                    .HasName("PK__ES_ViewTable__15A53433");

                entity.ToTable("ES_ViewTable");

                entity.Property(e => e.DtId).ValueGeneratedNever();

                entity.Property(e => e.BaseTables)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateStmt).HasColumnType("ntext");

                entity.Property(e => e.DirectSql).HasDefaultValueSql("0");

                entity.Property(e => e.Filter).HasColumnType("ntext");

                entity.Property(e => e.JoinCond).HasMaxLength(1000);

                entity.Property(e => e.SelectStmt).HasColumnType("ntext");

                entity.Property(e => e.UseIsNull)
                    .HasColumnName("useIsNull")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViewDesc).HasColumnType("ntext");
            });

            modelBuilder.Entity<EsVirtualWi>(entity =>
            {
                entity.HasKey(e => e.WiId)
                    .HasName("PK__ES_VirtualWi__1C1D2798");

                entity.ToTable("ES_VirtualWi");

                entity.Property(e => e.WiId)
                    .HasColumnName("wiId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubWiComp).HasDefaultValueSql("0");

                entity.Property(e => e.WiType).HasColumnName("wiType");
            });

            modelBuilder.Entity<EsVwiGroup>(entity =>
            {
                entity.HasKey(e => e.SubWiId)
                    .HasName("PK__ES_VWiGroup__1FEDB87C");

                entity.ToTable("ES_VWiGroup");

                entity.Property(e => e.SubWiId).HasMaxLength(20);

                entity.Property(e => e.WiId)
                    .IsRequired()
                    .HasColumnName("wiId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsWfCase>(entity =>
            {
                entity.HasKey(e => e.PiId)
                    .HasName("PK__ES_WfCase__10AB74EC");

                entity.ToTable("ES_WfCase");

                entity.HasIndex(e => e.PId)
                    .HasName("XIE1ES_WfCase");

                entity.Property(e => e.PiId)
                    .HasColumnName("piId")
                    .HasMaxLength(20);

                entity.Property(e => e.InitDate)
                    .HasColumnName("initDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.InitUser).HasColumnName("initUser");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWfLink>(entity =>
            {
                entity.HasKey(e => e.RouteId)
                    .HasName("PK__ES_WfLink__0BE6BFCF");

                entity.ToTable("ES_WfLink");

                entity.Property(e => e.RouteId)
                    .HasColumnName("routeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpDesc)
                    .HasColumnName("expDesc")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpSpec)
                    .HasColumnName("expSpec")
                    .HasColumnType("ntext");

                entity.Property(e => e.HasExp)
                    .HasColumnName("hasExp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JointNumType).HasDefaultValueSql("0");

                entity.Property(e => e.JointType).HasDefaultValueSql("0");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.Rtfs)
                    .HasColumnName("rtfs")
                    .HasMaxLength(500);

                entity.Property(e => e.ShapeName)
                    .IsRequired()
                    .HasColumnName("shapeName")
                    .HasMaxLength(50);

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.TtId).HasColumnName("ttId");
            });

            modelBuilder.Entity<EsWfTask>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK__ES_WfTask__5B438874");

                entity.ToTable("ES_WfTask");

                entity.Property(e => e.TId)
                    .HasColumnName("tId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BackData)
                    .HasColumnName("backData")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CanReturn)
                    .HasColumnName("canReturn")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommitByDataWriter)
                    .HasColumnName("commitByDataWriter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DelFlag).HasDefaultValueSql("0");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfJointData)
                    .HasColumnName("ifJointData")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfReadOnly)
                    .HasColumnName("ifReadOnly")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfSendEmail)
                    .HasColumnName("ifSendEmail")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfSendSms)
                    .HasColumnName("ifSendSms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JointNumType).HasDefaultValueSql("0");

                entity.Property(e => e.JointType).HasDefaultValueSql("0");

                entity.Property(e => e.LogoutAfterCommit)
                    .HasColumnName("logoutAfterCommit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NoTempSave)
                    .HasColumnName("noTempSave")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.PIdNew).HasColumnName("pIdNew");

                entity.Property(e => e.QuickOpen).HasDefaultValueSql("0");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RtIdNew).HasMaxLength(20);

                entity.Property(e => e.SaveCaption)
                    .HasColumnName("saveCaption")
                    .HasMaxLength(50);

                entity.Property(e => e.SavePrompt)
                    .HasColumnName("savePrompt")
                    .HasMaxLength(500);

                entity.Property(e => e.SaveRetData)
                    .HasColumnName("saveRetData")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShapeName)
                    .IsRequired()
                    .HasColumnName("shapeName")
                    .HasMaxLength(50);

                entity.Property(e => e.TDesc)
                    .HasColumnName("tDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.TIdNew).HasColumnName("tIdNew");

                entity.Property(e => e.TName)
                    .IsRequired()
                    .HasColumnName("tName")
                    .HasMaxLength(50);

                entity.Property(e => e.TType)
                    .HasColumnName("tType")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftAuth>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK__ES_WftAuth__76EBA2E9");

                entity.ToTable("ES_WftAuth");

                entity.Property(e => e.TId)
                    .HasColumnName("tId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthType)
                    .HasColumnName("authType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExceptCom)
                    .HasColumnName("exceptCom")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftAuthScope>(entity =>
            {
                entity.HasKey(e => new { e.TId, e.ScopeType })
                    .HasName("PK__ES_WftAuthScope__0539C240");

                entity.ToTable("ES_WftAuthScope");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.ScopeType).HasDefaultValueSql("0");

                entity.Property(e => e.ActorType)
                    .HasColumnName("actorType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Relation)
                    .HasColumnName("relation")
                    .HasMaxLength(20);

                entity.Property(e => e.RoleDisp).HasMaxLength(200);

                entity.Property(e => e.RtfMeaning).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftDataTrans>(entity =>
            {
                entity.HasKey(e => new { e.RtfIdTo, e.TId })
                    .HasName("PK__ES_wftDataTrans__025D5595");

                entity.ToTable("ES_wftDataTrans");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.IfIndex)
                    .HasColumnName("ifIndex")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftDeadline>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK__ES_WftDeadline__6C6E1476");

                entity.ToTable("ES_WftDeadline");

                entity.Property(e => e.TId)
                    .HasColumnName("tId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoCommit).HasDefaultValueSql("0");

                entity.Property(e => e.DlDay).HasColumnName("dlDay");

                entity.Property(e => e.DlTime)
                    .HasColumnName("dlTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DlWk).HasColumnName("dlWk");

                entity.Property(e => e.IfDeadLine)
                    .HasColumnName("ifDeadLine")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IfRemind)
                    .HasColumnName("ifRemind")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReNum).HasColumnName("reNum");

                entity.Property(e => e.ReUnit)
                    .HasColumnName("reUnit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RmdNum).HasColumnName("rmdNum");

                entity.Property(e => e.RmdUnit)
                    .HasColumnName("rmdUnit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TdNum).HasColumnName("tdNum");

                entity.Property(e => e.TdUnit)
                    .HasColumnName("tdUnit")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftFld>(entity =>
            {
                entity.HasKey(e => new { e.TId, e.RtfId })
                    .HasName("PK__ES_WftFld__7CA47C3F");

                entity.ToTable("ES_WftFld");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.RtfId).HasColumnName("rtfId");

                entity.Property(e => e.AutoCommitData)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DelData)
                    .HasColumnName("delData")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Editable).HasDefaultValueSql("0");

                entity.Property(e => e.Hidden).HasDefaultValueSql("0");

                entity.Property(e => e.RecAuth).HasMaxLength(500);

                entity.Property(e => e.RecAuthDisp).HasMaxLength(500);
            });

            modelBuilder.Entity<EsWftJointCond>(entity =>
            {
                entity.HasKey(e => new { e.TId, e.RtfId })
                    .HasName("PK__ES_WftJointCond__7ABC33CD");

                entity.ToTable("ES_WftJointCond");

                entity.Property(e => e.TId).HasColumnName("tId");
            });

            modelBuilder.Entity<EsWftRoles>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.TId })
                    .HasName("PK__ES_WftRoles__740F363E");

                entity.ToTable("ES_WftRoles");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.DeptIds).HasMaxLength(200);

                entity.Property(e => e.DeptNames).HasMaxLength(1000);

                entity.Property(e => e.DeptScope).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EsWftRules>(entity =>
            {
                entity.HasKey(e => new { e.TId, e.RuleId })
                    .HasName("PK__ES_WftRules__09FE775D");

                entity.ToTable("ES_WftRules");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.RuleId)
                    .HasColumnName("ruleId")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsWiLink>(entity =>
            {
                entity.HasKey(e => new { e.PrevWiId, e.WiId })
                    .HasName("PK__ES_WiLink__21D600EE");

                entity.ToTable("ES_WiLink");

                entity.HasIndex(e => new { e.WiId, e.PrevWiId })
                    .HasName("XIE1ES_WiLink");

                entity.Property(e => e.PrevWiId)
                    .HasColumnName("prevWiId")
                    .HasMaxLength(20);

                entity.Property(e => e.WiId).HasMaxLength(20);
            });

            modelBuilder.Entity<EsWitodo>(entity =>
            {
                entity.HasKey(e => new { e.WiId, e.UserId })
                    .HasName("PK__ES_Witodo__23BE4960");

                entity.ToTable("ES_Witodo");

                entity.HasIndex(e => new { e.UserId, e.WiId })
                    .HasName("XAK1ES_Witodo")
                    .IsUnique();

                entity.Property(e => e.WiId)
                    .HasColumnName("wiId")
                    .HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<EsWorkFlow>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__ES_WorkFlow__595B4002");

                entity.ToTable("ES_WorkFlow");

                entity.Property(e => e.PId)
                    .HasColumnName("pId")
                    .ValueGeneratedNever();

                entity.Property(e => e.PDesc)
                    .IsRequired()
                    .HasColumnName("pDesc")
                    .HasMaxLength(200);

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasColumnName("pName")
                    .HasMaxLength(50);

                entity.Property(e => e.PSpec)
                    .HasColumnName("pSpec")
                    .HasColumnType("image");

                entity.Property(e => e.RtId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EsWorkItem>(entity =>
            {
                entity.HasKey(e => e.WiId)
                    .HasName("PK__ES_WorkItem__147C05D0");

                entity.ToTable("ES_WorkItem");

                entity.HasIndex(e => new { e.RcId, e.ComBy })
                    .HasName("XIE6ES_WorkItem");

                entity.HasIndex(e => new { e.ComBy, e.WiType, e.RcId })
                    .HasName("XIE3ES_WorkItem");

                entity.HasIndex(e => new { e.PiId, e.ComDate, e.CreDate })
                    .HasName("XIE4ES_WorkItem");

                entity.HasIndex(e => new { e.RcId, e.CreBy, e.ComBy })
                    .HasName("XIE5ES_WorkItem");

                entity.HasIndex(e => new { e.WiId, e.RcId, e.State, e.CreDate })
                    .HasName("XAK2ES_WorkItem")
                    .IsUnique();

                entity.HasIndex(e => new { e.WiType, e.State, e.State1, e.ComBy })
                    .HasName("XIE2ES_WorkItem");

                entity.HasIndex(e => new { e.TId, e.CreDate, e.ComBy, e.State, e.RcId })
                    .HasName("XIE1ES_WorkItem");

                entity.HasIndex(e => new { e.WiType, e.State, e.TId, e.WiId, e.RcId })
                    .HasName("XAK1ES_WorkItem")
                    .IsUnique();

                entity.Property(e => e.WiId)
                    .HasColumnName("wiId")
                    .HasMaxLength(20);

                entity.Property(e => e.AutoCommit)
                    .HasColumnName("autoCommit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CheckOutByName).HasMaxLength(50);

                entity.Property(e => e.CheckoutBySesId).HasMaxLength(20);

                entity.Property(e => e.ComByA).HasColumnName("ComBy_A");

                entity.Property(e => e.ComByName).HasMaxLength(50);

                entity.Property(e => e.ComByNameA)
                    .HasColumnName("ComByName_A")
                    .HasMaxLength(50);

                entity.Property(e => e.ComDate).HasColumnType("datetime");

                entity.Property(e => e.CreByA).HasColumnName("CreBy_A");

                entity.Property(e => e.CreByName).HasMaxLength(50);

                entity.Property(e => e.CreByNameA)
                    .HasColumnName("CreByName_A")
                    .HasMaxLength(50);

                entity.Property(e => e.CreDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.DlDate).HasColumnType("datetime");

                entity.Property(e => e.IsFirst).HasDefaultValueSql("0");

                entity.Property(e => e.PiId)
                    .IsRequired()
                    .HasColumnName("piId")
                    .HasMaxLength(20);

                entity.Property(e => e.RcId)
                    .IsRequired()
                    .HasColumnName("rcId")
                    .HasMaxLength(20);

                entity.Property(e => e.RmdTime)
                    .HasColumnName("rmdTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RtnByName).HasMaxLength(50);

                entity.Property(e => e.RtnTime).HasColumnType("datetime");

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.Property(e => e.State1)
                    .HasColumnName("state1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TId).HasColumnName("tId");

                entity.Property(e => e.Temp1)
                    .HasColumnName("temp1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WiDesc)
                    .HasColumnName("wiDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.WiType)
                    .HasColumnName("wiType")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WeixinClock>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ClockPlanId).HasMaxLength(100);

                entity.Property(e => e.Clocktime).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Userid).HasMaxLength(100);

                entity.Property(e => e.Weixinid).HasMaxLength(100);
            });

            modelBuilder.Entity<WeixinClockOptions>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Ip).HasMaxLength(100);
            });

            modelBuilder.Entity<WeixinOptions>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.CorpId).HasMaxLength(100);

                entity.Property(e => e.EncodingAeskey)
                    .HasColumnName("EncodingAESKey")
                    .HasMaxLength(100);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Secret).HasMaxLength(100);

                entity.Property(e => e.Token).HasMaxLength(100);
            });

            modelBuilder.Entity<WeixinWorkPlan>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<WeixinWorkPlanDetail>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Beginning).HasColumnType("datetime");

                entity.Property(e => e.Ending).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.休息开始时间).HasColumnType("datetime");

                entity.Property(e => e.休息结束时间).HasColumnType("datetime");

                entity.Property(e => e.延迟算加班).HasMaxLength(20);

                entity.Property(e => e.必须打上班卡).HasMaxLength(20);

                entity.Property(e => e.必须打下班卡).HasMaxLength(20);
            });

            modelBuilder.Entity<Wx异常说明>(entity =>
            {
                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.原因).HasMaxLength(500);

                entity.Property(e => e.填报日期).HasColumnType("datetime");

                entity.Property(e => e.姓名).HasMaxLength(100);

                entity.Property(e => e.时间).HasColumnType("datetime");

                entity.Property(e => e.用户号).HasMaxLength(100);
            });

            modelBuilder.Entity<业务类型>(entity =>
            {
                entity.HasKey(e => e.业务类型1)
                    .HasName("pk_266");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.业务类型1)
                    .HasColumnName("业务类型")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.MvP).HasMaxLength(20);

                entity.Property(e => e.性质).HasMaxLength(20);

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.类型描述).HasMaxLength(100);
            });

            modelBuilder.Entity<人员档案>(entity =>
            {
                entity.HasKey(e => e.人员编号)
                    .HasName("pk_66");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.人员编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.入职时间).HasColumnType("datetime");

                entity.Property(e => e.出生年月).HasColumnType("datetime");

                entity.Property(e => e.姓名).HasMaxLength(20);

                entity.Property(e => e.性别).HasMaxLength(20);

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.登记时间).HasColumnType("datetime");

                entity.Property(e => e.离职时间).HasColumnType("datetime");

                entity.Property(e => e.考勤班次).HasMaxLength(20);

                entity.Property(e => e.联系地址).HasMaxLength(100);

                entity.Property(e => e.联系电话).HasMaxLength(20);

                entity.Property(e => e.证件号码).HasMaxLength(20);
            });

            modelBuilder.Entity<付款单>(entity =>
            {
                entity.HasKey(e => e.付款单号)
                    .HasName("pk_198");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.付款单号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.付款单位).HasMaxLength(100);

                entity.Property(e => e.付款日期).HasColumnType("datetime");

                entity.Property(e => e.付款类型).HasMaxLength(20);

                entity.Property(e => e.付款金额).HasColumnType("decimal");

                entity.Property(e => e.单位编号).HasMaxLength(20);

                entity.Property(e => e.备注).HasMaxLength(100);
            });

            modelBuilder.Entity<发货>(entity =>
            {
                entity.HasKey(e => e.送货单号)
                    .HasName("pk_146");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.送货单号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.业务描述).HasMaxLength(100);

                entity.Property(e => e.业务类型).HasMaxLength(20);

                entity.Property(e => e.冲销理由).HasMaxLength(100);

                entity.Property(e => e.创建者).HasMaxLength(20);

                entity.Property(e => e.地址).HasMaxLength(100);

                entity.Property(e => e.备注).HasMaxLength(100);

                entity.Property(e => e.客户).HasMaxLength(100);

                entity.Property(e => e.客户编号).HasMaxLength(20);

                entity.Property(e => e.联系人).HasMaxLength(20);

                entity.Property(e => e.联系电话).HasMaxLength(20);

                entity.Property(e => e.送货日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<发货Detail>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("PK_发货_DETAIL");

                entity.ToTable("发货_DETAIL");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Pcs)
                    .HasColumnName("PCS")
                    .HasColumnType("decimal");

                entity.Property(e => e.代号).HasMaxLength(20);

                entity.Property(e => e.单价).HasColumnType("decimal");

                entity.Property(e => e.单位数量).HasColumnType("decimal");

                entity.Property(e => e.工艺).HasMaxLength(100);

                entity.Property(e => e.描述).HasMaxLength(100);

                entity.Property(e => e.木种).HasMaxLength(20);

                entity.Property(e => e.标记).HasMaxLength(100);

                entity.Property(e => e.类型).HasMaxLength(20);

                entity.Property(e => e.编号).HasMaxLength(20);

                entity.Property(e => e.规格).HasMaxLength(20);

                entity.Property(e => e.计价单位).HasMaxLength(20);

                entity.Property(e => e.金额).HasColumnType("decimal");
            });

            modelBuilder.Entity<图形登记表>(entity =>
            {
                entity.HasKey(e => e.图形编号)
                    .HasName("pk_43");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.图形编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.图形).HasMaxLength(20);

                entity.Property(e => e.图形名称).HasMaxLength(100);

                entity.Property(e => e.描述).HasMaxLength(500);
            });

            modelBuilder.Entity<对账结算主表>(entity =>
            {
                entity.HasKey(e => new { e.单位编号, e.日期 })
                    .HasName("pk_315");

                entity.ToTable("对账结算_主表");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.单位编号).HasMaxLength(20);

                entity.Property(e => e.日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.单位名称).HasMaxLength(20);

                entity.Property(e => e.应付).HasColumnType("decimal");

                entity.Property(e => e.应收).HasColumnType("decimal");
            });

            modelBuilder.Entity<工资档案主表>(entity =>
            {
                entity.HasKey(e => e.流水号)
                    .HasName("pk_103");

                entity.ToTable("工资档案_主表");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.流水号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.姓名).HasMaxLength(20);

                entity.Property(e => e.编号).HasMaxLength(20);
            });

            modelBuilder.Entity<工资计算备份年月>(entity =>
            {
                entity.HasKey(e => new { e.年, e.月 })
                    .HasName("pk_177");

                entity.ToTable("工资计算备份_年月");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.月初).HasColumnType("datetime");

                entity.Property(e => e.月末).HasColumnType("datetime");
            });

            modelBuilder.Entity<工资计算年月>(entity =>
            {
                entity.HasKey(e => new { e.年, e.月 })
                    .HasName("pk_101");

                entity.ToTable("工资计算_年月");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.月初).HasColumnType("datetime");

                entity.Property(e => e.月末).HasColumnType("datetime");
            });

            modelBuilder.Entity<应付款对账单>(entity =>
            {
                entity.HasKey(e => new { e.单位编码, e.对账日期 })
                    .HasName("pk_208");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.单位编码).HasMaxLength(20);

                entity.Property(e => e.对账日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.单位名称).HasMaxLength(100);

                entity.Property(e => e.对账金额).HasColumnType("decimal");
            });

            modelBuilder.Entity<应收款对账单>(entity =>
            {
                entity.HasKey(e => new { e.客户编码, e.对账日期 })
                    .HasName("pk_132");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.客户编码).HasMaxLength(20);

                entity.Property(e => e.对账日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.客户名称).HasMaxLength(100);

                entity.Property(e => e.对账金额).HasColumnType("decimal");
            });

            modelBuilder.Entity<往来单位>(entity =>
            {
                entity.HasKey(e => e.单位编号)
                    .HasName("pk_25");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.单位编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Rank).HasColumnName("RANK");

                entity.Property(e => e.传真).HasMaxLength(20);

                entity.Property(e => e.单位名称).HasMaxLength(100);

                entity.Property(e => e.单位地址).HasMaxLength(100);

                entity.Property(e => e.单位性质).HasMaxLength(20);

                entity.Property(e => e.单位类型).HasMaxLength(20);

                entity.Property(e => e.电话).HasMaxLength(20);

                entity.Property(e => e.登记日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<打卡登记>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("pk_110");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.人员编号).HasMaxLength(20);

                entity.Property(e => e.姓名).HasMaxLength(20);

                entity.Property(e => e.审核人).HasMaxLength(20);

                entity.Property(e => e.审核时间).HasColumnType("datetime");

                entity.Property(e => e.审核状态).HasMaxLength(20);

                entity.Property(e => e.时间).HasColumnType("datetime");

                entity.Property(e => e.签卡原因).HasMaxLength(20);
            });

            modelBuilder.Entity<打卡记录>(entity =>
            {
                entity.HasKey(e => new { e.Yy, e.Mm })
                    .HasName("pk_226");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Yy).HasColumnName("yy");

                entity.Property(e => e.Mm).HasColumnName("mm");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<收款单>(entity =>
            {
                entity.HasKey(e => e.收款单号)
                    .HasName("pk_30");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.收款单号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.单位编号).HasMaxLength(20);

                entity.Property(e => e.备注).HasMaxLength(100);

                entity.Property(e => e.收款单位).HasMaxLength(100);

                entity.Property(e => e.收款日期).HasColumnType("datetime");

                entity.Property(e => e.收款类型).HasMaxLength(20);

                entity.Property(e => e.收款金额).HasColumnType("decimal");
            });

            modelBuilder.Entity<收货>(entity =>
            {
                entity.HasKey(e => e.单号)
                    .HasName("pk_194");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.单号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.业务描述).HasMaxLength(100);

                entity.Property(e => e.业务类型).HasMaxLength(20);

                entity.Property(e => e.供应商名称).HasMaxLength(100);

                entity.Property(e => e.供应商编号).HasMaxLength(20);

                entity.Property(e => e.创建者).HasMaxLength(20);

                entity.Property(e => e.日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<收货D>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("PK_收货_D");

                entity.ToTable("收货_D");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Pcs)
                    .HasColumnName("PCS")
                    .HasColumnType("decimal");

                entity.Property(e => e.单价).HasColumnType("decimal");

                entity.Property(e => e.单位数量).HasColumnType("decimal");

                entity.Property(e => e.名称).HasMaxLength(100);

                entity.Property(e => e.类型).HasMaxLength(20);

                entity.Property(e => e.编号).HasMaxLength(20);

                entity.Property(e => e.规格).HasMaxLength(100);

                entity.Property(e => e.计价单位).HasMaxLength(20);

                entity.Property(e => e.金额).HasColumnType("decimal");
            });

            modelBuilder.Entity<月考勤汇总主表>(entity =>
            {
                entity.HasKey(e => new { e.年份, e.月份 })
                    .HasName("pk_105");

                entity.ToTable("月考勤汇总_主表");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<物料分类>(entity =>
            {
                entity.HasKey(e => e.完整编码)
                    .HasName("pk_141");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.完整编码).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.上级全称).HasMaxLength(100);

                entity.Property(e => e.上级名称).HasMaxLength(100);

                entity.Property(e => e.上级编码).HasMaxLength(100);

                entity.Property(e => e.全称).HasMaxLength(100);

                entity.Property(e => e.本级名称).HasMaxLength(100);

                entity.Property(e => e.本级编码).HasMaxLength(20);
            });

            modelBuilder.Entity<物料登记>(entity =>
            {
                entity.HasKey(e => e.编号)
                    .HasName("pk_142");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.Height).HasColumnType("decimal");

                entity.Property(e => e.Length).HasColumnType("decimal");

                entity.Property(e => e.Width).HasColumnType("decimal");

                entity.Property(e => e.分类编号).HasMaxLength(20);

                entity.Property(e => e.图形编号).HasMaxLength(20);

                entity.Property(e => e.型号).HasMaxLength(100);

                entity.Property(e => e.工艺).HasMaxLength(100);

                entity.Property(e => e.描述).HasMaxLength(100);

                entity.Property(e => e.木种).HasMaxLength(100);

                entity.Property(e => e.木种个数).HasMaxLength(20);

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.类型).HasMaxLength(20);

                entity.Property(e => e.规格).HasMaxLength(100);

                entity.Property(e => e.面皮厚度).HasColumnType("decimal");
            });

            modelBuilder.Entity<物料登记Old>(entity =>
            {
                entity.HasKey(e => e.编号)
                    .HasName("pk_138");

                entity.ToTable("物料登记_Old");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.主单位).HasMaxLength(20);

                entity.Property(e => e.主单位编号).HasMaxLength(20);

                entity.Property(e => e.代号).HasMaxLength(100);

                entity.Property(e => e.分类编号).HasMaxLength(20);

                entity.Property(e => e.单位组).HasMaxLength(20);

                entity.Property(e => e.单位组编号).HasMaxLength(20);

                entity.Property(e => e.名称).HasMaxLength(100);

                entity.Property(e => e.图形编号).HasMaxLength(20);

                entity.Property(e => e.工艺).HasMaxLength(100);

                entity.Property(e => e.换算率).HasColumnType("decimal");

                entity.Property(e => e.木种).HasMaxLength(100);

                entity.Property(e => e.木种数).HasMaxLength(20);

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.登记人).HasMaxLength(20);

                entity.Property(e => e.登记日期).HasColumnType("datetime");

                entity.Property(e => e.类型).HasMaxLength(20);

                entity.Property(e => e.规格).HasMaxLength(100);

                entity.Property(e => e.辅单位).HasMaxLength(20);

                entity.Property(e => e.辅单位编号).HasMaxLength(20);
            });

            modelBuilder.Entity<生产入库>(entity =>
            {
                entity.HasKey(e => e.日期)
                    .HasName("pk_346");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.自增).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<生产入库D>(entity =>
            {
                entity.HasKey(e => e.自增)
                    .HasName("pk_344");

                entity.ToTable("生产入库_D");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.型号).HasMaxLength(20);

                entity.Property(e => e.宽).HasColumnType("decimal");

                entity.Property(e => e.平方数).HasColumnType("decimal");

                entity.Property(e => e.描述).HasMaxLength(50);

                entity.Property(e => e.长).HasColumnType("decimal");
            });

            modelBuilder.Entity<生产型号>(entity =>
            {
                entity.HasKey(e => e.型号)
                    .HasName("pk_345");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.型号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.自增).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<考勤卡号变动>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("pk_71");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.卡号).HasMaxLength(20);

                entity.Property(e => e.截止日期).HasColumnType("datetime");

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.起始日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<考勤明细>(entity =>
            {
                entity.HasKey(e => new { e.人员编号, e.日期 })
                    .HasName("pk_78");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.人员编号).HasMaxLength(20);

                entity.Property(e => e.日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.上班1).HasMaxLength(20);

                entity.Property(e => e.上班2).HasMaxLength(20);

                entity.Property(e => e.上班3).HasMaxLength(20);

                entity.Property(e => e.下班1).HasMaxLength(20);

                entity.Property(e => e.下班2).HasMaxLength(20);

                entity.Property(e => e.下班3).HasMaxLength(20);

                entity.Property(e => e.加班).HasColumnType("decimal");

                entity.Property(e => e.姓名).HasMaxLength(20);

                entity.Property(e => e.正常出勤).HasColumnType("decimal");

                entity.Property(e => e.状态).HasMaxLength(20);

                entity.Property(e => e.首打日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<考勤期间>(entity =>
            {
                entity.HasKey(e => new { e.年, e.月 })
                    .HasName("pk_81");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<计量单位主表>(entity =>
            {
                entity.HasKey(e => e.计量单位组编号)
                    .HasName("pk_31");

                entity.ToTable("计量单位_主表");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.计量单位组编号).HasMaxLength(20);

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.计量单位组名称).HasMaxLength(20);
            });

            modelBuilder.Entity<请假登记>(entity =>
            {
                entity.HasKey(e => new { e.编号, e.开始日期 })
                    .HasName("pk_114");

                entity.HasIndex(e => new { e.ExcelServerRcid, e.ExcelServerWiid })
                    .HasName("idx1");

                entity.Property(e => e.编号).HasMaxLength(20);

                entity.Property(e => e.开始日期).HasColumnType("datetime");

                entity.Property(e => e.ExcelServerChg).HasColumnName("ExcelServerCHG");

                entity.Property(e => e.ExcelServerCn).HasColumnName("ExcelServerCN");

                entity.Property(e => e.ExcelServerRc1)
                    .HasColumnName("ExcelServerRC1")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRcid)
                    .HasColumnName("ExcelServerRCID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerRn).HasColumnName("ExcelServerRN");

                entity.Property(e => e.ExcelServerRtid)
                    .HasColumnName("ExcelServerRTID")
                    .HasMaxLength(20);

                entity.Property(e => e.ExcelServerWiid)
                    .HasColumnName("ExcelServerWIID")
                    .HasMaxLength(20);

                entity.Property(e => e.姓名).HasMaxLength(20);

                entity.Property(e => e.结束日期).HasColumnType("datetime");

                entity.Property(e => e.请假理由).HasMaxLength(100);
            });
        }
    }
}