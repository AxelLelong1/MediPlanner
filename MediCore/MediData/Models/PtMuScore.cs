using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "CompliancePrdId")]
[Table("pt_mu_score")]
public partial class PtMuScore
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Column("visit_ind")]
    [StringLength(1)]
    public string? VisitInd { get; set; }

    [Column("demographics_ind")]
    [StringLength(1)]
    public string? DemographicsInd { get; set; }

    [Column("gender_ind")]
    [StringLength(1)]
    public string? GenderInd { get; set; }

    [Column("race_ind")]
    [StringLength(1)]
    public string? RaceInd { get; set; }

    [Column("ethnicity_ind")]
    [StringLength(1)]
    public string? EthnicityInd { get; set; }

    [Column("dob_ind")]
    [StringLength(1)]
    public string? DobInd { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("dod_ind")]
    [StringLength(1)]
    public string? DodInd { get; set; }

    [Column("lang_ind")]
    [StringLength(1)]
    public string? LangInd { get; set; }

    [Column("prob_ind")]
    [StringLength(1)]
    public string? ProbInd { get; set; }

    [Column("med_ind")]
    [StringLength(1)]
    public string? MedInd { get; set; }

    [Column("actual_med_ind")]
    [StringLength(1)]
    public string? ActualMedInd { get; set; }

    [Column("allergy_ind")]
    [StringLength(1)]
    public string? AllergyInd { get; set; }

    [Column("smoking_info_req_ind")]
    [StringLength(1)]
    public string? SmokingInfoReqInd { get; set; }

    [Column("smoking_ind")]
    [StringLength(1)]
    public string? SmokingInd { get; set; }

    [Column("portal_acct_ind")]
    [StringLength(1)]
    public string? PortalAcctInd { get; set; }

    [Column("portal_send_ind")]
    [StringLength(1)]
    public string? PortalSendInd { get; set; }

    [Column("education_ind")]
    [StringLength(1)]
    public string? EducationInd { get; set; }

    [Column("med_recon_ind")]
    [StringLength(1)]
    public string? MedReconInd { get; set; }

    [Column("rem_info_req_ind")]
    [StringLength(1)]
    public string? RemInfoReqInd { get; set; }

    [Column("rem_sent_ind")]
    [StringLength(1)]
    public string? RemSentInd { get; set; }

    [Column("score_last_updated", TypeName = "datetime")]
    public DateTime? ScoreLastUpdated { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("electronic_note_ind")]
    [StringLength(1)]
    public string? ElectronicNoteInd { get; set; }

    [Column("portal_vdt_ind")]
    [StringLength(1)]
    public string? PortalVdtInd { get; set; }

    [Column("family_hlth_hst_ind")]
    [StringLength(1)]
    public string? FamilyHlthHstInd { get; set; }

    [Column("stage1_vitals_info_req_ind")]
    [StringLength(1)]
    public string? Stage1VitalsInfoReqInd { get; set; }

    [Column("stage1_vitals_ind")]
    [StringLength(1)]
    public string? Stage1VitalsInd { get; set; }

    [Column("stage1_ht_ind")]
    [StringLength(1)]
    public string? Stage1HtInd { get; set; }

    [Column("stage1_wt_ind")]
    [StringLength(1)]
    public string? Stage1WtInd { get; set; }

    [Column("stage1_bmi_ind")]
    [StringLength(1)]
    public string? Stage1BmiInd { get; set; }

    [Column("stage1_systolic_ind")]
    [StringLength(1)]
    public string? Stage1SystolicInd { get; set; }

    [Column("stage1_diastolic_ind")]
    [StringLength(1)]
    public string? Stage1DiastolicInd { get; set; }

    [Column("pghd_ind")]
    [StringLength(1)]
    public string? PghdInd { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtMuScore")]
    public virtual Pt Pt { get; set; } = null!;
}
