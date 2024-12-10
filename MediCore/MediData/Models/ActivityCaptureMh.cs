using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityCaptureSer", "ActivityCaptureRevCount")]
[Table("ActivityCaptureMH")]
[Index("ActivityInstanceSer", Name = "XIE1ActivityCaptureMH")]
public partial class ActivityCaptureMh
{
    [Key]
    public long ActivityCaptureSer { get; set; }

    [Key]
    public int ActivityCaptureRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? AccountBillingCodeSer { get; set; }

    public int? AccountBillingCodeRevCount { get; set; }

    public long? PatientPayorSer { get; set; }

    public int? PatientPayorRevCount { get; set; }

    public long? PayorSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? AttendingOncologistSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string? LastKnownCourseId { get; set; }

    public int InPatientFlag { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [StringLength(255)]
    public string? CompletionResetBy { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("ActivityCaptureMh")]
    public virtual ActivityCapture ActivityCaptureSerNavigation { get; set; } = null!;
}
