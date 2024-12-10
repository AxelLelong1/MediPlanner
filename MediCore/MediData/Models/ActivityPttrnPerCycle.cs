using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityPttrnSer", Name = "XIF260EventPttrnDescript")]
public partial class ActivityPttrnPerCycle
{
    [Key]
    public long ActivityPttrnPerCycleSer { get; set; }

    public long ActivityPttrnSer { get; set; }

    public int? WeekNumber { get; set; }

    public int? ActivityDayOfWeek { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivityEndTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityPttrnSer")]
    [InverseProperty("ActivityPttrnPerCycle")]
    public virtual ActivityPttrn ActivityPttrnSerNavigation { get; set; } = null!;

    [InverseProperty("ActivityPttrnPerCycleSerNavigation")]
    public virtual ICollection<ActivityPttrnToSchedActivity> ActivityPttrnToSchedActivity { get; set; } = new List<ActivityPttrnToSchedActivity>();

    [InverseProperty("ActivityPttrnPerCycleSerNavigation")]
    public virtual ICollection<PttrnRelatedNonSchActivity> PttrnRelatedNonSchActivity { get; set; } = new List<PttrnRelatedNonSchActivity>();
}
