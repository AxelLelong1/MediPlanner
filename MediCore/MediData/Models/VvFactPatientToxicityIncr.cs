using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientToxicityIncr
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    public int Scheme { get; set; }

    public int ToxicityCauseCertaintyType { get; set; }

    public int ToxicityCauseType { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("DimDateID_AssessmentDateTime")]
    public int DimDateIdAssessmentDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AssessmentDateTime { get; set; }

    public int ToxicityGradeAuthor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToxicityEffectiveDate { get; set; }

    [StringLength(30)]
    public string? ToxicityAssessmentType { get; set; }

    [StringLength(30)]
    public string? ToxicityComponentName { get; set; }

    public int ToxicityGrade { get; set; }

    [StringLength(1)]
    public string? AdverseEventsIndicator { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [StringLength(60)]
    public string? ToxicitySubcomponentName { get; set; }

    public int? ToxicitySubComponentGradeName { get; set; }

    public int PatientToxicityAssessmentId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    public int? PatientToxicityAssessmentHeaderId { get; set; }

    public int? TestResultId { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    public int? GradePerAssessmentType { get; set; }

    public int AssessmentType { get; set; }

    [StringLength(3000)]
    public string? ToxicityReason { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [StringLength(1)]
    public string? ToxicityApprovedIndicator { get; set; }

    [StringLength(1)]
    public string? ToxicityHeaderValidEntryIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentPerformedDateTime { get; set; }

    [Column("DimDateID_AssessmentPerformedDateTime")]
    public int DimDateIdAssessmentPerformedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToxicityApprovedDateTime { get; set; }

    [Column("DimDateID_ToxicityApprovedDateTime")]
    public int DimDateIdToxicityApprovedDateTime { get; set; }

    [StringLength(1)]
    public string? ToxicityReviewRequestIndicator { get; set; }

    [StringLength(1)]
    public string? ToxicityReviewedIndicator { get; set; }

    [Column("reviewer_stkh_id")]
    [StringLength(20)]
    public string? ReviewerStkhId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToxicityReviewedDateTime { get; set; }

    [Column("DimDateID_ToxicityReviewedDateTime")]
    public int DimDateIdToxicityReviewedDateTime { get; set; }

    [StringLength(40)]
    public string? AssessmentTypeDesc { get; set; }

    public int? RevisionNumber { get; set; }

    [StringLength(1)]
    public string? CorrectedEntryIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentStartDateTime { get; set; }

    [Column("DimDateID_AssessmentStartDateTime")]
    public int DimDateIdAssessmentStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentEndDateTime { get; set; }

    [Column("DimDateID_AssessmentEndDateTime")]
    public int DimDateIdAssessmentEndDateTime { get; set; }
}
