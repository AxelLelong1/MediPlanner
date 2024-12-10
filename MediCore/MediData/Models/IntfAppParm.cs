using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_app_parm")]
[Index("IntfEngineId", "ActiveInd", Name = "nc1_intf_app_parm")]
public partial class IntfAppParm
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string? IntfEngineId { get; set; }

    [Column("intf_comm_id")]
    [StringLength(10)]
    public string? IntfCommId { get; set; }

    [Column("msg_typ_id")]
    [StringLength(10)]
    public string? MsgTypId { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("direction_ind")]
    [StringLength(1)]
    public string DirectionInd { get; set; } = null!;

    [Column("app_parm_desc")]
    [StringLength(80)]
    public string AppParmDesc { get; set; } = null!;

    [Column("sending_app")]
    [StringLength(30)]
    public string SendingApp { get; set; } = null!;

    [Column("receiving_app")]
    [StringLength(30)]
    public string? ReceivingApp { get; set; }

    [Column("sending_fac")]
    [StringLength(30)]
    public string? SendingFac { get; set; }

    [Column("receiving_fac")]
    [StringLength(30)]
    public string? ReceivingFac { get; set; }

    [Column("dflt_inst_id")]
    [StringLength(30)]
    public string? DfltInstId { get; set; }

    [Column("admn_inst_id")]
    [StringLength(30)]
    public string? AdmnInstId { get; set; }

    [Column("owner_inst_id")]
    [StringLength(30)]
    public string? OwnerInstId { get; set; }

    [Column("msg_field_separator")]
    [StringLength(1)]
    public string? MsgFieldSeparator { get; set; }

    [Column("msg_comp_separator")]
    [StringLength(1)]
    public string? MsgCompSeparator { get; set; }

    [Column("msg_subcomp_separator")]
    [StringLength(1)]
    public string? MsgSubcompSeparator { get; set; }

    [Column("msg_repetition_separator")]
    [StringLength(1)]
    public string? MsgRepetitionSeparator { get; set; }

    [Column("msg_escape_character")]
    [StringLength(1)]
    public string? MsgEscapeCharacter { get; set; }

    [Column("ovride_prcs")]
    [StringLength(1)]
    public string OvridePrcs { get; set; } = null!;

    [Column("prcs_stat_ind")]
    [StringLength(1)]
    public string? PrcsStatInd { get; set; }

    [Column("cust_intf_ind")]
    [StringLength(1)]
    public string CustIntfInd { get; set; } = null!;

    [Column("cust_name_id")]
    [StringLength(20)]
    public string? CustNameId { get; set; }

    [Column("hl7_batch_ind")]
    [StringLength(1)]
    public string? Hl7BatchInd { get; set; }

    [Column("hl7_batch_fhs_ind")]
    [StringLength(1)]
    public string? Hl7BatchFhsInd { get; set; }

    [Column("hl7_batch_bhs_ind")]
    [StringLength(1)]
    public string? Hl7BatchBhsInd { get; set; }

    [Column("sch_ind")]
    [StringLength(1)]
    public string? SchInd { get; set; }

    [Column("create_trgr_ind")]
    [StringLength(1)]
    public string? CreateTrgrInd { get; set; }

    [Column("wordcap")]
    [StringLength(1)]
    public string? Wordcap { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("update_access_ind")]
    [StringLength(1)]
    public string UpdateAccessInd { get; set; } = null!;

    [Column("msg_purge_days")]
    public int? MsgPurgeDays { get; set; }

    [Column("out_app_ack")]
    [StringLength(2)]
    public string? OutAppAck { get; set; }

    [Column("out_accept_ack")]
    [StringLength(2)]
    public string? OutAcceptAck { get; set; }

    [Column("visit_days_prior")]
    public int? VisitDaysPrior { get; set; }

    [Column("visit_days_after")]
    public int? VisitDaysAfter { get; set; }

    [Column("gen_open_chart_visit_ind")]
    [StringLength(1)]
    public string? GenOpenChartVisitInd { get; set; }

    [Column("inst_id_mthd")]
    [StringLength(1)]
    public string? InstIdMthd { get; set; }

    [Column("appr_for_billing_flag")]
    [StringLength(1)]
    public string? ApprForBillingFlag { get; set; }

    [Column("show_merge_cmt_ind")]
    [StringLength(1)]
    public string? ShowMergeCmtInd { get; set; }

    [Column("create_pt_cmt_ind")]
    [StringLength(1)]
    public string? CreatePtCmtInd { get; set; }

    [Column("insd_id_no_match_ind")]
    [StringLength(1)]
    public string InsdIdNoMatchInd { get; set; } = null!;

    [Column("err_in1_ind")]
    [StringLength(1)]
    public string? ErrIn1Ind { get; set; }

    [Column("sch_prcs_typ")]
    [StringLength(1)]
    public string? SchPrcsTyp { get; set; }

    [Column("sch_res")]
    [StringLength(1)]
    public string? SchRes { get; set; }

    [Column("imp_compl_ind")]
    [StringLength(1)]
    public string? ImpComplInd { get; set; }

    [Column("gen_format_pon_ind")]
    [StringLength(1)]
    public string? GenFormatPonInd { get; set; }

    [Column("pon_next_seq")]
    [StringLength(15)]
    public string? PonNextSeq { get; set; }

    [Column("pon_start_val")]
    [StringLength(15)]
    public string? PonStartVal { get; set; }

    [Column("pon_end_val")]
    [StringLength(15)]
    public string? PonEndVal { get; set; }

    [Column("pon_increment")]
    public int? PonIncrement { get; set; }

    [Column("pon_prefix_list")]
    [StringLength(80)]
    public string? PonPrefixList { get; set; }

    [Column("pon_cur_prefix")]
    [StringLength(10)]
    public string? PonCurPrefix { get; set; }

    [Column("pon_per_test_ind")]
    [StringLength(1)]
    public string? PonPerTestInd { get; set; }

    [Column("send_order_days_ind")]
    [StringLength(1)]
    public string? SendOrderDaysInd { get; set; }

    [Column("pt_addl_match_cd")]
    [StringLength(1)]
    public string? PtAddlMatchCd { get; set; }

    [Column("intf_app_parm_id_no_trgr")]
    [StringLength(10)]
    public string? IntfAppParmIdNoTrgr { get; set; }

    [Column("send_appr_only_ind")]
    [StringLength(1)]
    public string? SendApprOnlyInd { get; set; }

    [Column("send_intf_created_ind")]
    [StringLength(1)]
    public string? SendIntfCreatedInd { get; set; }

    [Column("max_line_size")]
    public int? MaxLineSize { get; set; }

    [Column("max_outbnd_msg_len")]
    public int? MaxOutbndMsgLen { get; set; }

    [Column("prv_state_abrv_ind")]
    [StringLength(1)]
    public string? PrvStateAbrvInd { get; set; }

    [Column("allow_name_change_ind")]
    [StringLength(1)]
    public string? AllowNameChangeInd { get; set; }

    [Column("rad_order_no")]
    [StringLength(20)]
    public string? RadOrderNo { get; set; }

    [Column("mfn_process_cd")]
    [StringLength(1)]
    public string? MfnProcessCd { get; set; }

    [Column("send_phys_only_ind")]
    [StringLength(1)]
    public string? SendPhysOnlyInd { get; set; }

    [Column("send_email_with_phone_ind")]
    [StringLength(1)]
    public string SendEmailWithPhoneInd { get; set; } = null!;

    [Column("grant_all_inst_access_ind")]
    [StringLength(1)]
    public string GrantAllInstAccessInd { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string? DefTyp { get; set; }

    [Column("vers_no")]
    [StringLength(10)]
    public string? VersNo { get; set; }

    [Column("msg_typ")]
    [StringLength(3)]
    public string? MsgTyp { get; set; }

    [Column("msg_typ_name")]
    [StringLength(30)]
    public string? MsgTypName { get; set; }

    [Column("msg_typ_desc")]
    [StringLength(255)]
    public string? MsgTypDesc { get; set; }

    [Column("order_typ")]
    [StringLength(3)]
    public string? OrderTyp { get; set; }

    [Column("msg_typ_level")]
    public int? MsgTypLevel { get; set; }

    [Column("stage_msg_ind")]
    [StringLength(1)]
    public string? StageMsgInd { get; set; }

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("populate_inst_care_bed_ind")]
    [StringLength(1)]
    public string? PopulateInstCareBedInd { get; set; }

    [Column("visit_typ")]
    public int? VisitTyp { get; set; }

    [Column("linked_intf_app_parm_id")]
    [StringLength(10)]
    public string? LinkedIntfAppParmId { get; set; }

    [Column("max_pt_records_per_file")]
    public int? MaxPtRecordsPerFile { get; set; }

    [Column("max_in1_per_patient")]
    public int? MaxIn1PerPatient { get; set; }

    [Column("create_bill_visit_event_ind")]
    [StringLength(1)]
    public string? CreateBillVisitEventInd { get; set; }

    [Column("pt_addl_match_ignore_blank_ind")]
    [StringLength(1)]
    public string? PtAddlMatchIgnoreBlankInd { get; set; }

    [Column("pt_addl_match_ignore_char")]
    [StringLength(30)]
    public string? PtAddlMatchIgnoreChar { get; set; }

    [Column("provider_status_send_cd")]
    public int? ProviderStatusSendCd { get; set; }

    [Column("unfmt_address_ind")]
    [StringLength(1)]
    public string? UnfmtAddressInd { get; set; }

    [Column("varis_ind")]
    [StringLength(1)]
    public string? VarisInd { get; set; }

    [Column("patient_select_ind")]
    [StringLength(1)]
    public string? PatientSelectInd { get; set; }

    [Column("varis_auto_update_ind")]
    [StringLength(1)]
    public string? VarisAutoUpdateInd { get; set; }

    [Column("varis_auto_add_ind")]
    [StringLength(1)]
    public string? VarisAutoAddInd { get; set; }

    [Column("varis_in1_match_typ")]
    [StringLength(1)]
    public string? VarisIn1MatchTyp { get; set; }

    [Column("varis_nk1_match_typ")]
    [StringLength(1)]
    public string? VarisNk1MatchTyp { get; set; }

    [Column("last_name_compare_char_len")]
    public int? LastNameCompareCharLen { get; set; }

    [Column("filter_msg_purge_days")]
    public int? FilterMsgPurgeDays { get; set; }

    [Column("suppress_trgr_ind")]
    [StringLength(1)]
    public string? SuppressTrgrInd { get; set; }

    [Column("send_rtf_ind")]
    [StringLength(1)]
    public string? SendRtfInd { get; set; }

    [Column("intf_mode")]
    public int? IntfMode { get; set; }

    [Column("diagnosis_mode")]
    [StringLength(1)]
    public string? DiagnosisMode { get; set; }

    [Column("diagnosis_internal_ind")]
    [StringLength(1)]
    public string? DiagnosisInternalInd { get; set; }

    [Column("assign_msgs_ind")]
    [StringLength(1)]
    public string? AssignMsgsInd { get; set; }

    [Column("transltn_ind")]
    [StringLength(1)]
    public string? TransltnInd { get; set; }

    [Column("locale_id")]
    public int? LocaleId { get; set; }

    [Column("hl7_encoding")]
    public int Hl7Encoding { get; set; }

    [Column("prcs_attempt")]
    public int PrcsAttempt { get; set; }

    [Column("hitech_filter_ind")]
    [StringLength(1)]
    public string HitechFilterInd { get; set; } = null!;

    [Column("prcs_ccs_trgrs_ind")]
    [StringLength(1)]
    public string PrcsCcsTrgrsInd { get; set; } = null!;

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<BillSysBatchGroup> BillSysBatchGroup { get; set; } = new List<BillSysBatchGroup>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmComp> IntfAppParmComp { get; set; } = new List<IntfAppParmComp>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmEvnt> IntfAppParmEvnt { get; set; } = new List<IntfAppParmEvnt>();

    [InverseProperty("IntfAppParm")]
    public virtual IntfAppParmExtended? IntfAppParmExtended { get; set; }

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmFacId> IntfAppParmFacId { get; set; } = new List<IntfAppParmFacId>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmField> IntfAppParmField { get; set; } = new List<IntfAppParmField>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmFwd> IntfAppParmFwdIntfAppParm { get; set; } = new List<IntfAppParmFwd>();

    [InverseProperty("IntfAppParmFwdNavigation")]
    public virtual ICollection<IntfAppParmFwd> IntfAppParmFwdIntfAppParmFwdNavigation { get; set; } = new List<IntfAppParmFwd>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmSeg> IntfAppParmSeg { get; set; } = new List<IntfAppParmSeg>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmTrgr> IntfAppParmTrgr { get; set; } = new List<IntfAppParmTrgr>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfAppParmTrnsltn> IntfAppParmTrnsltn { get; set; } = new List<IntfAppParmTrnsltn>();

    [InverseProperty("IntfAppParm")]
    public virtual IntfCcsLink? IntfCcsLinkIntfAppParm { get; set; }

    [InverseProperty("IntfAppParmCcs")]
    public virtual ICollection<IntfCcsLink> IntfCcsLinkIntfAppParmCcs { get; set; } = new List<IntfCcsLink>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfFieldCdMap> IntfFieldCdMap { get; set; } = new List<IntfFieldCdMap>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfNoteTypSel> IntfNoteTypSel { get; set; } = new List<IntfNoteTypSel>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfPtKeyMap> IntfPtKeyMap { get; set; } = new List<IntfPtKeyMap>();

    [InverseProperty("IntfAppParm")]
    public virtual ICollection<IntfStkhKeyMap> IntfStkhKeyMap { get; set; } = new List<IntfStkhKeyMap>();
}
