using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityInstanceSer", "ObjectStatus", "AttendeeSer", Name = "IX_Attendee_ActInSer_obj_Included")]
[Index("ResourceGroupSer", "ObjectStatus", Name = "IX_Attendee_ObjectStatus")]
[Index("ObjectStatus", "ResourceSer", "ActivityInstanceSer", Name = "XIE1Attendee")]
[Index("ObjectStatus", Name = "XIE2Attendee")]
[Index("ActivityInstanceSer", Name = "XIF547ActivityCategory")]
[Index("ResourceSer", Name = "XIF548ActivityCategory")]
[Index("ResourceGroupSer", Name = "XIF549ActivityCategory")]
public partial class Attendee
{
    [Key]
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

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("Attendee")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [InverseProperty("AttendeeSerNavigation")]
    public virtual ICollection<AttendeeMh> AttendeeMh { get; set; } = new List<AttendeeMh>();

    [InverseProperty("AttendeeSerNavigation")]
    public virtual ICollection<ReminderAck> ReminderAck { get; set; } = new List<ReminderAck>();

    [ForeignKey("ResourceGroupSer")]
    [InverseProperty("Attendee")]
    public virtual ResourceGroup? ResourceGroupSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Attendee")]
    public virtual Resource? ResourceSerNavigation { get; set; }

    [InverseProperty("AttendeeSerNavigation")]
    public virtual ICollection<ScheduledProcedure> ScheduledProcedure { get; set; } = new List<ScheduledProcedure>();
}
