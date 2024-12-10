using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("inst")]
public partial class Inst
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("inst_name")]
    [StringLength(50)]
    public string InstName { get; set; } = null!;

    [Column("inst_seq")]
    public int? InstSeq { get; set; }

    [Column("inst_address_1")]
    [StringLength(30)]
    public string InstAddress1 { get; set; } = null!;

    [Column("inst_address_2")]
    [StringLength(30)]
    public string? InstAddress2 { get; set; }

    [Column("inst_address_3")]
    [StringLength(30)]
    public string? InstAddress3 { get; set; }

    [Column("inst_city")]
    [StringLength(30)]
    public string InstCity { get; set; } = null!;

    [Column("inst_prv_state")]
    [StringLength(30)]
    public string InstPrvState { get; set; } = null!;

    [Column("inst_country")]
    public int InstCountry { get; set; }

    [Column("inst_pc_zip")]
    [StringLength(10)]
    public string InstPcZip { get; set; } = null!;

    [Column("inst_tel")]
    [StringLength(28)]
    public string InstTel { get; set; } = null!;

    [Column("inst_fax")]
    [StringLength(28)]
    public string? InstFax { get; set; }

    [Column("inst_typ")]
    public int? InstTyp { get; set; }

    [Column("gs_author")]
    public int? GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column("abs_min_wt", TypeName = "numeric(11, 4)")]
    public decimal? AbsMinWt { get; set; }

    [Column("abs_max_wt", TypeName = "numeric(11, 4)")]
    public decimal? AbsMaxWt { get; set; }

    [Column("wt_unit")]
    public int? WtUnit { get; set; }

    [Column("abs_min_ht", TypeName = "numeric(11, 4)")]
    public decimal? AbsMinHt { get; set; }

    [Column("abs_max_ht", TypeName = "numeric(11, 4)")]
    public decimal? AbsMaxHt { get; set; }

    [Column("ht_unit", TypeName = "numeric(11, 4)")]
    public decimal? HtUnit { get; set; }

    [Column("inst_tel_ext")]
    [StringLength(10)]
    public string? InstTelExt { get; set; }

    [Column("inst_county")]
    [StringLength(30)]
    public string? InstCounty { get; set; }

    [Column("hl7_billing_active")]
    [StringLength(1)]
    public string? Hl7BillingActive { get; set; }

    [Column("bill_void_ind")]
    [StringLength(1)]
    public string? BillVoidInd { get; set; }

    [Column("progress_note_ind")]
    [StringLength(1)]
    public string? ProgressNoteInd { get; set; }

    [Column("inst_date_fmt")]
    [StringLength(20)]
    public string? InstDateFmt { get; set; }

    [Column("inst_rx_ifmt")]
    [StringLength(11)]
    public string? InstRxIfmt { get; set; }

    [Column("inst_rx_dfmt")]
    [StringLength(16)]
    public string? InstRxDfmt { get; set; }

    [Column("inst_test_ifmt")]
    [StringLength(11)]
    public string? InstTestIfmt { get; set; }

    [Column("inst_test_dfmt")]
    [StringLength(16)]
    public string? InstTestDfmt { get; set; }

    [Column("inst_rx_i_fmt")]
    [StringLength(16)]
    public string? InstRxIFmt1 { get; set; }

    [Column("inst_test_i_fmt")]
    [StringLength(16)]
    public string? InstTestIFmt1 { get; set; }

    [Column("bill_unsol_hl7_ind")]
    [StringLength(1)]
    public string? BillUnsolHl7Ind { get; set; }

    [Column("audit_del_ind")]
    [StringLength(1)]
    public string? AuditDelInd { get; set; }

    [Column("trf_trnsprt_mthd")]
    [StringLength(20)]
    public string? TrfTrnsprtMthd { get; set; }

    [Column("trf_retries")]
    public int? TrfRetries { get; set; }

    [Column("trf_ras_phnbk_id")]
    [StringLength(30)]
    public string? TrfRasPhnbkId { get; set; }

    [Column("trf_nw_password")]
    [StringLength(30)]
    public string? TrfNwPassword { get; set; }

    [Column("trf_domain_name")]
    [StringLength(100)]
    public string? TrfDomainName { get; set; }

    [Column("trf_nw_login_id")]
    [StringLength(30)]
    public string? TrfNwLoginId { get; set; }

    [Column("phys_order_dur")]
    public int? PhysOrderDur { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("trf_remote_connect")]
    [StringLength(1)]
    public string? TrfRemoteConnect { get; set; }

    [Column("physical_site_ind")]
    [StringLength(1)]
    public string? PhysicalSiteInd { get; set; }

    [Column("auto_fax_enabled")]
    [StringLength(1)]
    public string? AutoFaxEnabled { get; set; }

    [Column("auto_email_enabled")]
    [StringLength(1)]
    public string? AutoEmailEnabled { get; set; }

    [Column("scan_visit_range")]
    public int? ScanVisitRange { get; set; }

    [Column("dcmnt_que_enabled")]
    [StringLength(1)]
    public string? DcmntQueEnabled { get; set; }

    [Column("dcmnt_hdr_enabled")]
    [StringLength(1)]
    public string? DcmntHdrEnabled { get; set; }

    [Column("prnt_dcmnt_ftr_appr_ind")]
    [StringLength(1)]
    public string? PrntDcmntFtrApprInd { get; set; }

    [Column("prnt_dcmnt_ftr_entered_ind")]
    [StringLength(1)]
    public string? PrntDcmntFtrEnteredInd { get; set; }

    [Column("author_print_enabled")]
    [StringLength(1)]
    public string? AuthorPrintEnabled { get; set; }

    [Column("agt_formulary_inst_id")]
    [StringLength(30)]
    public string? AgtFormularyInstId { get; set; }

    [Column("time_zone_id", TypeName = "numeric(5, 0)")]
    public decimal? TimeZoneId { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("audit_reason_ind")]
    [StringLength(1)]
    public string? AuditReasonInd { get; set; }

    [Column("inst_pc_zip_fmt_id")]
    public int? InstPcZipFmtId { get; set; }

    [Column("inst_tel_fmt_id")]
    public int? InstTelFmtId { get; set; }

    [Column("inst_fax_fmt_id")]
    public int? InstFaxFmtId { get; set; }

    [Column("iv_qstr_id")]
    public int? IvQstrId { get; set; }

    [Column("inpt_ind")]
    [StringLength(1)]
    public string? InptInd { get; set; }

    [Column("bill_parent_ind")]
    [StringLength(1)]
    public string? BillParentInd { get; set; }

    [Column("subj_result_as_txt_ind")]
    [StringLength(1)]
    public string? SubjResultAsTxtInd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("hospital_ser")]
    public long? HospitalSer { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("parent_inst_id")]
    [StringLength(30)]
    public string? ParentInstId { get; set; }

    [Column("file_server_userid")]
    [StringLength(255)]
    public string? FileServerUserid { get; set; }

    [Column("file_server_password")]
    [StringLength(30)]
    public string? FileServerPassword { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("track_inpt_hist_ind")]
    [StringLength(1)]
    public string? TrackInptHistInd { get; set; }

    [Column("department_ser")]
    public long? DepartmentSer { get; set; }

    [Column("inst_email_address")]
    [StringLength(255)]
    public string? InstEmailAddress { get; set; }

    [Column("inst_smtp_address")]
    [StringLength(255)]
    public string? InstSmtpAddress { get; set; }

    [Column("inst_email_username")]
    [StringLength(254)]
    public string? InstEmailUsername { get; set; }

    [Column("inst_email_password")]
    [StringLength(254)]
    public string? InstEmailPassword { get; set; }

    [Column("inst_email_port_num")]
    public int? InstEmailPortNum { get; set; }

    [Column("inst_email_ssl_ind")]
    [StringLength(1)]
    public string InstEmailSslInd { get; set; } = null!;

    [Column("inst_email_anonymous_ind")]
    [StringLength(1)]
    public string InstEmailAnonymousInd { get; set; } = null!;

    [InverseProperty("Inst")]
    public virtual DbInst? DbInst { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<ExtDrugDbLog> ExtDrugDbLog { get; set; } = new List<ExtDrugDbLog>();

    [InverseProperty("Inst")]
    public virtual ICollection<Fac> Fac { get; set; } = new List<Fac>();

    [InverseProperty("Inst")]
    public virtual ICollection<GnrcNote> GnrcNote { get; set; } = new List<GnrcNote>();

    [InverseProperty("Inst")]
    public virtual ICollection<InstCareUnit> InstCareUnit { get; set; } = new List<InstCareUnit>();

    [InverseProperty("Inst")]
    public virtual ICollection<InstDept> InstDept { get; set; } = new List<InstDept>();

    [InverseProperty("Inst")]
    public virtual ICollection<InstDoseMgmt> InstDoseMgmt { get; set; } = new List<InstDoseMgmt>();

    [InverseProperty("Inst")]
    public virtual ICollection<InstDxCode> InstDxCode { get; set; } = new List<InstDxCode>();

    [InverseProperty("Inst")]
    public virtual InstExtDrugDb? InstExtDrugDb { get; set; }

    [ForeignKey("InstFaxFmtId")]
    [InverseProperty("InstInstFaxFmt")]
    public virtual FmtField? InstFaxFmt { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<InstFcn> InstFcn { get; set; } = new List<InstFcn>();

    [InverseProperty("Inst")]
    public virtual InstLab? InstLab { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<InstLocBldg> InstLocBldg { get; set; } = new List<InstLocBldg>();

    [ForeignKey("InstPcZipFmtId")]
    [InverseProperty("InstInstPcZipFmt")]
    public virtual FmtField? InstPcZipFmt { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<InstScheme> InstScheme { get; set; } = new List<InstScheme>();

    [InverseProperty("Inst")]
    public virtual ICollection<InstShift> InstShift { get; set; } = new List<InstShift>();

    [ForeignKey("InstTelFmtId")]
    [InverseProperty("InstInstTelFmt")]
    public virtual FmtField? InstTelFmt { get; set; }

    [ForeignKey("InstTyp")]
    [InverseProperty("Inst")]
    public virtual InstTyp? InstTypNavigation { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<LblFormInst> LblFormInst { get; set; } = new List<LblFormInst>();

    [InverseProperty("Inst")]
    public virtual ICollection<ProductBillCdXref> ProductBillCdXref { get; set; } = new List<ProductBillCdXref>();

    [ForeignKey("PrvStateId")]
    [InverseProperty("Inst")]
    public virtual PrvState? PrvState { get; set; }

    [InverseProperty("Inst")]
    public virtual ICollection<PtInfoRequest> PtInfoRequest { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("Inst")]
    public virtual ICollection<TrfCall> TrfCall { get; set; } = new List<TrfCall>();

    [InverseProperty("Inst")]
    public virtual ICollection<TrfInst> TrfInst { get; set; } = new List<TrfInst>();

    [InverseProperty("GroupInst")]
    public virtual ICollection<UserGroup> UserGroup { get; set; } = new List<UserGroup>();

    [InverseProperty("Inst")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();

    [InverseProperty("Inst")]
    public virtual ICollection<XrefInstDispLoc> XrefInstDispLoc { get; set; } = new List<XrefInstDispLoc>();

    [InverseProperty("Inst")]
    public virtual ICollection<XrefInstRqstn> XrefInstRqstn { get; set; } = new List<XrefInstRqstn>();

    [InverseProperty("Inst")]
    public virtual ICollection<XrefRxTypInst> XrefRxTypInst { get; set; } = new List<XrefRxTypInst>();
}
