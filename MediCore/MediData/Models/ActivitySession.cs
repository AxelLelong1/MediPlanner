using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledActivitySer", "SessionSer")]
[Index("SessionSer", Name = "XIF319ActivityTreatmentSession")]
public partial class ActivitySession
{
    [Key]
    public long ScheduledActivitySer { get; set; }

    [Key]
    public long SessionSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ScheduledActivitySer")]
    [InverseProperty("ActivitySession")]
    public virtual ScheduledActivity ScheduledActivitySerNavigation { get; set; } = null!;

    [ForeignKey("SessionSer")]
    [InverseProperty("ActivitySession")]
    public virtual Session SessionSerNavigation { get; set; } = null!;
}
