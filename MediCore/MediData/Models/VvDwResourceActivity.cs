using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwResourceActivity
{
    public long ScheduledActivitySer { get; set; }

    public long? ResourceSer { get; set; }

    public int ExclusiveFlag { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("Attendee_ObjectStatus")]
    [StringLength(16)]
    public string AttendeeObjectStatus { get; set; } = null!;

    public int ActivityInstanceRevCount { get; set; }
}
