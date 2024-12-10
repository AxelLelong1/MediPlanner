using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCaptureSer", Name = "XIF666ActivityCaptureDiagnosis")]
public partial class ActCaptDiagnosis
{
    [Key]
    public long ActCaptDiagnosisSer { get; set; }

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

    [InverseProperty("ActCaptDiagnosisSerNavigation")]
    public virtual ICollection<ActCaptDiagnosisMh> ActCaptDiagnosisMh { get; set; } = new List<ActCaptDiagnosisMh>();

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("ActCaptDiagnosis")]
    public virtual ActivityCapture ActivityCaptureSerNavigation { get; set; } = null!;
}
