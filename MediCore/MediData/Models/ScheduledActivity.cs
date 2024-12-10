using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ObjectStatus", "ScheduledEndTime", Name = "IX_ScheduledActivity_Endtime")]
[Index("Uid", Name = "XAKScheduledActivity", IsUnique = true)]
[Index("ScheduledStartTime", Name = "XIE1Event")]
[Index("ScheduledEndTime", "ScheduledStartTime", Name = "XIE2Event")]
[Index("WaitListedFlag", Name = "XIE5ScheduledActivity")]
[Index("ScheduledActivityCode", "ObjectStatus", Name = "XIE8ScheduledActivity")]
[Index("HstryDateTime", Name = "XIE9ScheduledActivity")]
[Index("RecurrenceRuleSer", Name = "XIF758ScheduledActivity")]
[Index("ActivityInstanceSer", "ScheduledActivitySer", Name = "XIF759ScheduledActivity")]
[Index("PatientSer", Name = "XIF760ScheduledActivity")]
[Index("CreatedByResourceSer", Name = "XIF761ScheduledActivity")]
[Index("ScheduledActivitySer", "ScheduledActivityCode", Name = "XIF901ScheduledActivity")]
public partial class ScheduledActivity
{
    [Key]
    public long ScheduledActivitySer { get; set; }

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

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ScheduledActivity")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [InverseProperty("ScheduledActivitySerNavigation")]
    public virtual ICollection<ActivityPttrnToSchedActivity> ActivityPttrnToSchedActivity { get; set; } = new List<ActivityPttrnToSchedActivity>();

    [InverseProperty("ScheduledActivitySerNavigation")]
    public virtual ICollection<ActivitySession> ActivitySession { get; set; } = new List<ActivitySession>();

    [ForeignKey("CreatedByResourceSer")]
    [InverseProperty("ScheduledActivity")]
    public virtual Resource? CreatedByResourceSerNavigation { get; set; }

    [InverseProperty("ScheduledActivitySerNavigation")]
    public virtual ICollection<PatientLocation> PatientLocation { get; set; } = new List<PatientLocation>();

    [ForeignKey("PatientSer")]
    [InverseProperty("ScheduledActivity")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [ForeignKey("RecurrenceRuleSer")]
    [InverseProperty("ScheduledActivity")]
    public virtual RecurrenceRule? RecurrenceRuleSerNavigation { get; set; }

    [InverseProperty("ScheduledActivitySerNavigation")]
    public virtual ICollection<ScheduledActivityMh> ScheduledActivityMh { get; set; } = new List<ScheduledActivityMh>();
}
