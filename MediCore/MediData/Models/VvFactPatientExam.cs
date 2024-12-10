using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientExam
{
    [StringLength(1)]
    public string? ApprovedIndicator { get; set; }

    [Column("ExamApprovedDateTimeID")]
    public long? ExamApprovedDateTimeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExamApprovedDateTime { get; set; }

    [Column("ExamDateTimeID")]
    public long? ExamDateTimeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExamDateTime { get; set; }

    [StringLength(255)]
    public string? UserId { get; set; }

    [StringLength(30)]
    public string? InstId { get; set; }

    [StringLength(1)]
    public string? ExamValidEntryIndicator { get; set; }

    [StringLength(30)]
    public string? BodySystemDescription { get; set; }

    [Column("ROSPEAssessmentDescription")]
    [StringLength(3000)]
    public string? RospeassessmentDescription { get; set; }

    [Column("UserId_Approved")]
    [StringLength(255)]
    public string? UserIdApproved { get; set; }

    [Column("InstId_Approved")]
    [StringLength(30)]
    public string? InstIdApproved { get; set; }

    [Column("DictationApprovedDateTimeID")]
    public long? DictationApprovedDateTimeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DictationApprovedDateTime { get; set; }

    [StringLength(1)]
    public string? ExamSystemValidEntryIndicator { get; set; }

    [StringLength(255)]
    public string? TransLogUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogDateTime { get; set; }

    [StringLength(255)]
    public string? TransLogModifiedUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogModifiedDateTime { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrpt_exam_id")]
    public int CtrptExamId { get; set; }

    [Column("ctrpt_exam_system_id")]
    public int CtrptExamSystemId { get; set; }
}
