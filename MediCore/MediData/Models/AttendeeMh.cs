using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AttendeeSer", "AttendeeRevCount")]
[Table("AttendeeMH")]
[Index("ActivityInstanceSer", "ActivityInstanceRevCount", Name = "XIE1AttendeeMH")]
public partial class AttendeeMh
{
    [Key]
    public long AttendeeSer { get; set; }

    [Key]
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

    [ForeignKey("AttendeeSer")]
    [InverseProperty("AttendeeMh")]
    public virtual Attendee AttendeeSerNavigation { get; set; } = null!;
}
