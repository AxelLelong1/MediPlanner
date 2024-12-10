using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid1")]
[Table("userid")]
[Index("Userid1", Name = "nc1_userid")]
[Index("StkhId", Name = "nc2_userid")]
[Index("Usercuid", Name = "nc3_userid")]
public partial class Userid
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid1 { get; set; } = null!;

    [Column("group_inst_id")]
    [StringLength(30)]
    public string? GroupInstId { get; set; }

    [Column("user_group_id")]
    [StringLength(10)]
    public string? UserGroupId { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

    [Column("user_title_id")]
    public int? UserTitleId { get; set; }

    [Column("user_first_name")]
    [StringLength(20)]
    public string? UserFirstName { get; set; }

    [Column("user_initial")]
    [StringLength(2)]
    public string? UserInitial { get; set; }

    [Column("user_last_name")]
    [StringLength(30)]
    public string? UserLastName { get; set; }

    [Column("prof_flag")]
    [StringLength(1)]
    public string? ProfFlag { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("user_bus_tel")]
    [StringLength(28)]
    public string? UserBusTel { get; set; }

    [Column("user_bus_tel_ext")]
    [StringLength(10)]
    public string? UserBusTelExt { get; set; }

    [Column("user_home_tel")]
    [StringLength(28)]
    public string? UserHomeTel { get; set; }

    [Column("user_pager")]
    [StringLength(28)]
    public string? UserPager { get; set; }

    [Column("user_pager_ext")]
    [StringLength(10)]
    public string? UserPagerExt { get; set; }

    [Column("lic_agrmt_ind")]
    [StringLength(1)]
    public string? LicAgrmtInd { get; set; }

    [Column("lic_agrmt_tstamp", TypeName = "datetime")]
    public DateTime? LicAgrmtTstamp { get; set; }

    [Column("medi_agrmt_tstamp", TypeName = "datetime")]
    public DateTime? MediAgrmtTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("designation_typ")]
    public int? DesignationTyp { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("cpt_agrmt_ind")]
    [StringLength(1)]
    public string? CptAgrmtInd { get; set; }

    [Column("cpt_agrmt_tstamp", TypeName = "datetime")]
    public DateTime? CptAgrmtTstamp { get; set; }

    [Column("bcca_agrmt_ind")]
    [StringLength(1)]
    public string? BccaAgrmtInd { get; set; }

    [Column("bcca_agrmt_tstamp", TypeName = "datetime")]
    public DateTime? BccaAgrmtTstamp { get; set; }

    [Column("dea")]
    [StringLength(10)]
    public string? Dea { get; set; }

    [Column("upin")]
    [StringLength(10)]
    public string? Upin { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("pn_pre_appr_ind")]
    [StringLength(1)]
    public string? PnPreApprInd { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("intf_pre_appr_ind")]
    [StringLength(1)]
    public string? IntfPreApprInd { get; set; }

    [Column("rospe_ind")]
    [StringLength(1)]
    public string? RospeInd { get; set; }

    [Column("dsp_name")]
    [StringLength(80)]
    public string? DspName { get; set; }

    [Column("login_inst_id")]
    [StringLength(30)]
    public string? LoginInstId { get; set; }

    [Column("login_userid")]
    [StringLength(255)]
    public string? LoginUserid { get; set; }

    [Column("bill_for_visit_ind")]
    [StringLength(1)]
    public string? BillForVisitInd { get; set; }

    [Column("dflt_rx_typ")]
    public int? DfltRxTyp { get; set; }

    [Column("first_login_date", TypeName = "datetime")]
    public DateTime? FirstLoginDate { get; set; }

    [Column("name_confirmed_ind")]
    [StringLength(1)]
    public string? NameConfirmedInd { get; set; }

    [Column("user_bus_tel_fmt_id")]
    public int? UserBusTelFmtId { get; set; }

    [Column("user_home_tel_fmt_id")]
    public int? UserHomeTelFmtId { get; set; }

    [Column("bill_for_test_ind")]
    [StringLength(1)]
    public string BillForTestInd { get; set; } = null!;

    [Column("bill_for_meds_ind")]
    [StringLength(1)]
    public string BillForMedsInd { get; set; } = null!;

    [Column("bill_for_qstr_ind")]
    [StringLength(1)]
    public string BillForQstrInd { get; set; } = null!;

    [Column("user_pager_fmt_id")]
    public int? UserPagerFmtId { get; set; }

    [Column("app_user_userid")]
    [StringLength(255)]
    public string? AppUserUserid { get; set; }

    [Column("usercuid")]
    [StringLength(64)]
    public string? Usercuid { get; set; }

    [Column("active_userid")]
    [StringLength(255)]
    public string? ActiveUserid { get; set; }

    [Column("user_typ_cd")]
    [StringLength(1)]
    public string? UserTypCd { get; set; }

    [Column("user_access_time_override_ind")]
    [StringLength(1)]
    public string? UserAccessTimeOverrideInd { get; set; }

    [Column("printer")]
    [StringLength(255)]
    public string? Printer { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [Column("emergency_group_inst_id")]
    [StringLength(30)]
    public string? EmergencyGroupInstId { get; set; }

    [Column("emergency_user_group_id")]
    [StringLength(10)]
    public string? EmergencyUserGroupId { get; set; }

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<AgendaTemplateTaskUser> AgendaTemplateTaskUser { get; set; } = new List<AgendaTemplateTaskUser>();

    [ForeignKey("DesignationTyp")]
    [InverseProperty("Userid")]
    public virtual DesignationTyp? DesignationTypNavigation { get; set; }

    [ForeignKey("DisciplineTyp")]
    [InverseProperty("Userid")]
    public virtual DisciplineTyp? DisciplineTypNavigation { get; set; }

    [InverseProperty("Userid1")]
    public virtual ICollection<ExtDrugDbLog> ExtDrugDbLogUserid1 { get; set; } = new List<ExtDrugDbLog>();

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<ExtDrugDbLog> ExtDrugDbLogUseridNavigation { get; set; } = new List<ExtDrugDbLog>();

    [ForeignKey("InstId")]
    [InverseProperty("Userid")]
    public virtual Inst Inst { get; set; } = null!;

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<Password> Password { get; set; } = new List<Password>();

    [ForeignKey("ProfTyp")]
    [InverseProperty("Userid")]
    public virtual ProfTyp? ProfTypNavigation { get; set; }

    [InverseProperty("Userid")]
    public virtual ICollection<ProfUnavl> ProfUnavl { get; set; } = new List<ProfUnavl>();

    [InverseProperty("Userid")]
    public virtual ICollection<PtInfoRequest> PtInfoRequestUserid { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<PtInfoRequest> PtInfoRequestUseridNavigation { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("Userid")]
    public virtual ICollection<PtProf> PtProf { get; set; } = new List<PtProf>();

    [InverseProperty("Userid")]
    public virtual ICollection<PtTp> PtTp { get; set; } = new List<PtTp>();

    [InverseProperty("Userid")]
    public virtual ICollection<PtVisit> PtVisit { get; set; } = new List<PtVisit>();

    [ForeignKey("StkhId")]
    [InverseProperty("Userid")]
    public virtual Stkh? Stkh { get; set; }

    [ForeignKey("UserBusTelFmtId")]
    [InverseProperty("UseridUserBusTelFmt")]
    public virtual FmtField? UserBusTelFmt { get; set; }

    [ForeignKey("EmergencyGroupInstId, EmergencyUserGroupId")]
    [InverseProperty("UseridUserGroup")]
    public virtual UserGroup? UserGroup { get; set; }

    [ForeignKey("GroupInstId, UserGroupId")]
    [InverseProperty("UseridUserGroupNavigation")]
    public virtual UserGroup? UserGroupNavigation { get; set; }

    [ForeignKey("UserHomeTelFmtId")]
    [InverseProperty("UseridUserHomeTelFmt")]
    public virtual FmtField? UserHomeTelFmt { get; set; }

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<UserPnToolbar> UserPnToolbar { get; set; } = new List<UserPnToolbar>();

    [ForeignKey("UserTitleId")]
    [InverseProperty("Userid")]
    public virtual TitleTyp? UserTitle { get; set; }

    [InverseProperty("UseridNavigation")]
    public virtual ICollection<VisitReasonPnTemplate> VisitReasonPnTemplate { get; set; } = new List<VisitReasonPnTemplate>();
}
