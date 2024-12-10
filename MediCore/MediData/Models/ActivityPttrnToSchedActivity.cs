using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledActivitySer", "ActivityPttrnPerCycleSer")]
[Index("ActivityPttrnPerCycleSer", Name = "XIF258ActivityPttrnToSchedActi")]
public partial class ActivityPttrnToSchedActivity
{
    [Key]
    public long ScheduledActivitySer { get; set; }

    [Key]
    public long ActivityPttrnPerCycleSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityPttrnPerCycleSer")]
    [InverseProperty("ActivityPttrnToSchedActivity")]
    public virtual ActivityPttrnPerCycle ActivityPttrnPerCycleSerNavigation { get; set; } = null!;

    [ForeignKey("ScheduledActivitySer")]
    [InverseProperty("ActivityPttrnToSchedActivity")]
    public virtual ScheduledActivity ScheduledActivitySerNavigation { get; set; } = null!;
}
