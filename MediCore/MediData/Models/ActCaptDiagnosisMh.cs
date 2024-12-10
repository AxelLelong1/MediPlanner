using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActCaptDiagnosisSer", "ActCaptDiagnosisRevCount")]
[Table("ActCaptDiagnosisMH")]
[Index("ActivityCaptureSer", Name = "XIE1ActCaptDiagnosisMH")]
public partial class ActCaptDiagnosisMh
{
    [Key]
    public long ActCaptDiagnosisSer { get; set; }

    [Key]
    public int ActCaptDiagnosisRevCount { get; set; }

    public long ActivityCaptureSer { get; set; }

    public int ActivityCaptureRevCount { get; set; }

    public long DiagnosisSer { get; set; }

    [StringLength(16)]
    public string LastKnownDiagnosisId { get; set; } = null!;

    [StringLength(64)]
    public string? LastKnownDiagnosisTableName { get; set; }

    [StringLength(16)]
    public string? LastKnownDiagnosisCode { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? ClsSchemeId { get; set; }

    public int? SequenceNumber { get; set; }

    [ForeignKey("ActCaptDiagnosisSer")]
    [InverseProperty("ActCaptDiagnosisMh")]
    public virtual ActCaptDiagnosis ActCaptDiagnosisSerNavigation { get; set; } = null!;
}
