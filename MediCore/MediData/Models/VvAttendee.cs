using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvAttendee
{
    public long AttendeeSer { get; set; }

    public int AttendeeRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? ResourceSer { get; set; }

    public long? ResourceGroupSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int ExclusiveFlag { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(32)]
    public string? ParticipationRole { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int ActivityOwnerFlag { get; set; }
}
