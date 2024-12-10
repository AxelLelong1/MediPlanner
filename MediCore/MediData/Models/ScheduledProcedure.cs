using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityInstanceSer", Name = "XIF1ScheduledProcedure")]
[Index("AttendeeSer", Name = "XIF2ScheduledProcedure")]
public partial class ScheduledProcedure
{
    [Key]
    public long ScheduledProcedureSer { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? AttendeeSer { get; set; }

    public int? AttendeeRevCount { get; set; }

    [StringLength(16)]
    public string? Status { get; set; }

    [Column("ScheduledProcedureUID")]
    [StringLength(64)]
    public string ScheduledProcedureUid { get; set; } = null!;

    [StringLength(16)]
    public string ScheduledProcedureId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledEndDateTime { get; set; }

    public int ExportedFlag { get; set; }

    [StringLength(16)]
    public string? Priority { get; set; }

    [StringLength(16)]
    public string? InputAvailability { get; set; }

    [StringLength(64)]
    public string ProcedureStepLabel { get; set; } = null!;

    [StringLength(64)]
    public string? WorklistLabel { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ScheduledProcedure")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("AttendeeSer")]
    [InverseProperty("ScheduledProcedure")]
    public virtual Attendee? AttendeeSerNavigation { get; set; }

    [InverseProperty("ScheduledProcedureSerNavigation")]
    public virtual ICollection<ScheduledObjectPointer> ScheduledObjectPointer { get; set; } = new List<ScheduledObjectPointer>();

    [InverseProperty("ScheduledProcedureSerNavigation")]
    public virtual ICollection<ScheduledPerformedProcedure> ScheduledPerformedProcedure { get; set; } = new List<ScheduledPerformedProcedure>();

    [InverseProperty("ScheduledProcedureSerNavigation")]
    public virtual ICollection<ScheduledProcedureItem> ScheduledProcedureItem { get; set; } = new List<ScheduledProcedureItem>();
}
