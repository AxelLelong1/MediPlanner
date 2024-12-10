using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityPttrnPerCycleSer", "ActivitySer")]
[Index("ActivitySer", Name = "XIF616PttrnRelatedNonSchActivi")]
public partial class PttrnRelatedNonSchActivity
{
    [Key]
    public long ActivityPttrnPerCycleSer { get; set; }

    [Key]
    public long ActivitySer { get; set; }

    public int? PriorPostDueTime { get; set; }

    public long ResourceAssignedBySer { get; set; }

    public long GroupAssignedToSer { get; set; }

    public long ResourceAssignedToSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityPttrnPerCycleSer")]
    [InverseProperty("PttrnRelatedNonSchActivity")]
    public virtual ActivityPttrnPerCycle ActivityPttrnPerCycleSerNavigation { get; set; } = null!;

    [ForeignKey("ActivitySer")]
    [InverseProperty("PttrnRelatedNonSchActivity")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;
}
