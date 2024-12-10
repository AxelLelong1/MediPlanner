using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AttendingOncologistSer", Name = "XIF502TrtmntStrtgActvt")]
[Index("ActivityInstanceSer", Name = "XIF628TrtmntStrtgActvt")]
[Index("DepartmentSer", Name = "XIF642ActivityCapture")]
[Index("CourseSer", Name = "XIF644ActivityCapture")]
[Index("ResourceSer", Name = "XIF684ActivityCapture")]
[Index("PayorSer", Name = "XIF822ActivityCapture")]
public partial class ActivityCapture
{
    [Key]
    public long ActivityCaptureSer { get; set; }

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

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<ActCaptDiagnosis> ActCaptDiagnosis { get; set; } = new List<ActCaptDiagnosis>();

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<ActCaptTreatment> ActCaptTreatment { get; set; } = new List<ActCaptTreatment>();

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<ActivityCaptureAttribute> ActivityCaptureAttribute { get; set; } = new List<ActivityCaptureAttribute>();

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<ActivityCaptureMh> ActivityCaptureMh { get; set; } = new List<ActivityCaptureMh>();

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ActivityCapture")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("AttendingOncologistSer")]
    [InverseProperty("ActivityCapture")]
    public virtual Resource? AttendingOncologistSerNavigation { get; set; }

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [ForeignKey("CourseSer")]
    [InverseProperty("ActivityCapture")]
    public virtual Course? CourseSerNavigation { get; set; }

    [InverseProperty("ActivityCaptureSerNavigation")]
    public virtual ICollection<Credit> Credit { get; set; } = new List<Credit>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ActivityCapture")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("PayorSer")]
    [InverseProperty("ActivityCapture")]
    public virtual Payor? PayorSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("ActivityCapture")]
    public virtual Doctor? ResourceSerNavigation { get; set; }
}
