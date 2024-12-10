using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DxId", "RevisionNo")]
[Table("pt_dx_mh")]
public partial class PtDxMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("dx_id")]
    public int DxId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

    [Column("stage_of_disease")]
    [StringLength(50)]
    public string? StageOfDisease { get; set; }

    [Column("onset_date", TypeName = "datetime")]
    public DateTime? OnsetDate { get; set; }

    [Column("dx_typ")]
    [StringLength(1)]
    public string? DxTyp { get; set; }

    [Column("confirm_dx")]
    [StringLength(1)]
    public string? ConfirmDx { get; set; }

    [Column("resolution_date", TypeName = "datetime")]
    public DateTime? ResolutionDate { get; set; }

    [Column("resolution_typ")]
    public int? ResolutionTyp { get; set; }

    [Column("dx_name")]
    [StringLength(250)]
    public string? DxName { get; set; }

    [Column("valid_entry")]
    [StringLength(1)]
    public string? ValidEntry { get; set; }

    [Column("dx_desc")]
    public string? DxDesc { get; set; }

    [Column("mthd_of_dx")]
    public string? MthdOfDx { get; set; }

    [Column("resolution_desc")]
    public string? ResolutionDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

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

    [Column("date_approx_ind")]
    [StringLength(1)]
    public string? DateApproxInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("onset_date_cd")]
    public int? OnsetDateCd { get; set; }

    [Column("hx_of_ind")]
    [StringLength(1)]
    public string? HxOfInd { get; set; }

    [Column("dx_mthd_typ")]
    public int? DxMthdTyp { get; set; }

    [Column("resolution_date_cd")]
    public int? ResolutionDateCd { get; set; }

    [Column("external_ind")]
    [StringLength(1)]
    public string? ExternalInd { get; set; }

    [Column("stg_crit_desc")]
    [StringLength(40)]
    public string? StgCritDesc { get; set; }

    [Column("evlv_pt_dx_id")]
    public int? EvlvPtDxId { get; set; }

    [Column("evlv_tstamp", TypeName = "datetime")]
    public DateTime? EvlvTstamp { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("cs_of_dth_ind")]
    [StringLength(1)]
    public string? CsOfDthInd { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("clinical_desc")]
    [StringLength(255)]
    public string? ClinicalDesc { get; set; }

    [Column("ae_ind")]
    [StringLength(1)]
    public string? AeInd { get; set; }

    [Column("source_typ")]
    public int? SourceTyp { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("dx_cmt")]
    public string? DxCmt { get; set; }

    [Column("diagnosis_ser")]
    public long? DiagnosisSer { get; set; }

    [Column("vision_diagnosis_id")]
    [StringLength(16)]
    public string? VisionDiagnosisId { get; set; }

    [Column("intf_diagnosis_id")]
    [StringLength(50)]
    public string? IntfDiagnosisId { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("reported_ind")]
    [StringLength(1)]
    public string? ReportedInd { get; set; }

    [Column("publish_ind")]
    [StringLength(1)]
    public string? PublishInd { get; set; }

    [Column("unique_ccda_id")]
    [StringLength(75)]
    public string? UniqueCcdaId { get; set; }

    [Column("intf_reconcile_date", TypeName = "datetime")]
    public DateTime? IntfReconcileDate { get; set; }

    [Column("encounter_dx_ind")]
    [StringLength(1)]
    public string? EncounterDxInd { get; set; }
}
