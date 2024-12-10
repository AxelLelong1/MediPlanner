using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledActivitySer", "ScheduledActivityRevCount")]
[Table("ScheduledActivityMH")]
[Index("ActivityInstanceSer", "ActivityInstanceRevCount", Name = "XIE1ScheduledActivityMH")]
public partial class ScheduledActivityMh
{
    [Key]
    public long ScheduledActivitySer { get; set; }

    [Key]
    public int ScheduledActivityRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? CreatedByResourceSer { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("CreatedByHL7")]
    [StringLength(255)]
    public string? CreatedByHl7 { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string Uid { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualEndDate { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(64)]
    public string? ScheduledActivityCode { get; set; }

    [StringLength(64)]
    public string? Priority { get; set; }

    public int WaitListedFlag { get; set; }

    [StringLength(254)]
    public string? ActivityNote { get; set; }

    public long? RecurrenceRuleSer { get; set; }

    [StringLength(255)]
    public string? ReadByAppUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadByDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? PreMedication { get; set; }

    [StringLength(64)]
    public string? ContrastAgent { get; set; }

    public int WorkFlowActiveFlag { get; set; }

    [ForeignKey("ScheduledActivitySer")]
    [InverseProperty("ScheduledActivityMh")]
    public virtual ScheduledActivity ScheduledActivitySerNavigation { get; set; } = null!;
}
