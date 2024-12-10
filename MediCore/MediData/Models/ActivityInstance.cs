using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivitySer", "ActivityRevCount", Name = "XIE2ActivityInstance")]
[Index("ObjectStatus", "ActivityInstanceSer", Name = "XIE3ActivityInstance")]
[Index("PredecessorSer", Name = "XIF521ClendarActivity")]
[Index("DepartmentSer", Name = "XIF545ClendarActivity")]
[Index("TemplateCycleSer", Name = "XIF566ActivityInstance")]
[Index("StudySer", Name = "XIF964ActivityInstance")]
[Index("LastStatusUpdatedByResourceSer", Name = "XIF965ActivityInstance")]
[Index("LastNoteUpdatedByResourceSer", Name = "XIF966ActivityInstance")]
[Index("WorkFlowOverrideByResourceSer", Name = "XIF967ActivityInstance")]
public partial class ActivityInstance
{
    [Key]
    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? TemplateCycleSer { get; set; }

    public int? TemplateCycleRevCount { get; set; }

    public long ActivitySer { get; set; }

    public int ActivityRevCount { get; set; }

    public long? DepartmentSer { get; set; }

    public int AppointmentInstanceFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long? PredecessorSer { get; set; }

    public int AppointmentDependentFlag { get; set; }

    public int? NotificationPriorTime { get; set; }

    public int? Duration { get; set; }

    public int ExclusiveFlag { get; set; }

    public int? ActivityGroup { get; set; }

    public int? MinPostDuration { get; set; }

    public int? MinTrtmntOccurence { get; set; }

    public int? MaxTrtmntOccurence { get; set; }

    public int? DefaultTrtmntOccurence { get; set; }

    public int? WeekNumber { get; set; }

    public int? DayOfWeek { get; set; }

    public int? PriorPostDueDurUnits { get; set; }

    [StringLength(254)]
    public string? ActivityNote { get; set; }

    public int ActInstReadOnly { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(16)]
    public string? ActivityInstanceId { get; set; }

    public long? StudySer { get; set; }

    [StringLength(64)]
    public string? WorklistType { get; set; }

    [StringLength(64)]
    public string? PlacerOrderNumber { get; set; }

    [StringLength(64)]
    public string? FillerOrderNumber { get; set; }

    public int NotificationPriorTimeFlag { get; set; }

    public long? LastStatusUpdatedByResourceSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastStatusUpdatedDate { get; set; }

    public long? LastNoteUpdatedByResourceSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastNoteUpdatedDate { get; set; }

    public long? WorkFlowOverrideByResourceSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WorkFlowOverrideDate { get; set; }

    public int AnchorActivityFlag { get; set; }

    public int AutoAssignOncologistFlag { get; set; }

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ActInstChecklistItem> ActInstChecklistItem { get; set; } = new List<ActInstChecklistItem>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCode { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ActivityInstanceLink> ActivityInstanceLinkActivityInstanceSerNavigation { get; set; } = new List<ActivityInstanceLink>();

    [InverseProperty("PredecessorSerNavigation")]
    public virtual ICollection<ActivityInstanceLink> ActivityInstanceLinkPredecessorSerNavigation { get; set; } = new List<ActivityInstanceLink>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ActivityInstanceMh> ActivityInstanceMh { get; set; } = new List<ActivityInstanceMh>();

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityInstance")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<Attendee> Attendee { get; set; } = new List<Attendee>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ChartQa> ChartQa { get; set; } = new List<ChartQa>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ActivityInstance")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [InverseProperty("PredecessorSerNavigation")]
    public virtual ICollection<ActivityInstance> InversePredecessorSerNavigation { get; set; } = new List<ActivityInstance>();

    [ForeignKey("LastNoteUpdatedByResourceSer")]
    [InverseProperty("ActivityInstanceLastNoteUpdatedByResourceSerNavigation")]
    public virtual Resource? LastNoteUpdatedByResourceSerNavigation { get; set; }

    [ForeignKey("LastStatusUpdatedByResourceSer")]
    [InverseProperty("ActivityInstanceLastStatusUpdatedByResourceSerNavigation")]
    public virtual Resource? LastStatusUpdatedByResourceSerNavigation { get; set; }

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<NonScheduledActivity> NonScheduledActivity { get; set; } = new List<NonScheduledActivity>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<PerformedProcedure> PerformedProcedure { get; set; } = new List<PerformedProcedure>();

    [ForeignKey("PredecessorSer")]
    [InverseProperty("InversePredecessorSerNavigation")]
    public virtual ActivityInstance? PredecessorSerNavigation { get; set; }

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ScheduledActivity> ScheduledActivity { get; set; } = new List<ScheduledActivity>();

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<ScheduledProcedure> ScheduledProcedure { get; set; } = new List<ScheduledProcedure>();

    [ForeignKey("StudySer")]
    [InverseProperty("ActivityInstance")]
    public virtual Study? StudySerNavigation { get; set; }

    [ForeignKey("TemplateCycleSer")]
    [InverseProperty("ActivityInstance")]
    public virtual TemplateCycle? TemplateCycleSerNavigation { get; set; }

    [InverseProperty("ActivityInstanceSerNavigation")]
    public virtual ICollection<WeeklyChargeLink> WeeklyChargeLink { get; set; } = new List<WeeklyChargeLink>();

    [ForeignKey("WorkFlowOverrideByResourceSer")]
    [InverseProperty("ActivityInstanceWorkFlowOverrideByResourceSerNavigation")]
    public virtual Resource? WorkFlowOverrideByResourceSerNavigation { get; set; }
}
