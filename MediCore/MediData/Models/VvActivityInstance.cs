using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvActivityInstance
{
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

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int ActInstReadOnly { get; set; }

    public long? StudySer { get; set; }

    [StringLength(16)]
    public string? ActivityInstanceId { get; set; }

    [StringLength(64)]
    public string? PlacerOrderNumber { get; set; }

    [StringLength(64)]
    public string? FillerOrderNumber { get; set; }

    [StringLength(64)]
    public string? WorklistType { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? ChkBoxLastUpdate { get; set; }
}
