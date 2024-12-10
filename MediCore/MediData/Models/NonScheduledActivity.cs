using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("Uid", Name = "XAKTask", IsUnique = true)]
[Index("DueDateTime", Name = "XIE3Task")]
[Index("NonScheduledActivitySer", "ActivityInstanceSer", "ObjectStatus", Name = "XIE8NonScheduledActivity")]
[Index("HstryDateTime", Name = "XIE9NonScheduledActivity")]
[Index("PatientSer", Name = "XIF570NonScheduledActivity")]
[Index("ActivityInstanceSer", Name = "XIF592NonScheduledActivity")]
[Index("RecurrenceRuleSer", Name = "XIF595NonScheduledActivity")]
[Index("ActivityInstanceSer", "ObjectStatus", Name = "XIF596NonScheduledActivity")]
[Index("CreatedByResourceSer", Name = "XIF626NonScheduledActivity")]
public partial class NonScheduledActivity
{
    [Key]
    public long NonScheduledActivitySer { get; set; }

    public int NonScheduledActivityRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? CreatedByResourceSer { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string Uid { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DueDateTime { get; set; }

    [StringLength(64)]
    public string? NonScheduledActivityCode { get; set; }

    [StringLength(64)]
    public string? Priority { get; set; }

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

    public int WorkFlowActiveFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletionDate { get; set; }

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("NonScheduledActivity")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("CreatedByResourceSer")]
    [InverseProperty("NonScheduledActivity")]
    public virtual Resource? CreatedByResourceSerNavigation { get; set; }

    [InverseProperty("NonScheduledActivitySerNavigation")]
    public virtual ICollection<NonScheduledActivityMh> NonScheduledActivityMh { get; set; } = new List<NonScheduledActivityMh>();

    [ForeignKey("PatientSer")]
    [InverseProperty("NonScheduledActivity")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [ForeignKey("RecurrenceRuleSer")]
    [InverseProperty("NonScheduledActivity")]
    public virtual RecurrenceRule? RecurrenceRuleSerNavigation { get; set; }
}
