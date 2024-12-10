using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AttendeeSer", Name = "XIF1ReminderAck")]
public partial class ReminderAck
{
    [Key]
    public long ReminderAckSer { get; set; }

    public long AttendeeSer { get; set; }

    public int ReminderAckFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReminderAckDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AttendeeSer")]
    [InverseProperty("ReminderAck")]
    public virtual Attendee AttendeeSerNavigation { get; set; } = null!;
}
