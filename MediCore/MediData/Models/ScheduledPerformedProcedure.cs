using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledProcedureSer", "PerformedProcedureSer")]
[Index("PerformedProcedureSer", Name = "XIF2ScheduledPerformedProcedure")]
public partial class ScheduledPerformedProcedure
{
    [Key]
    public long ScheduledProcedureSer { get; set; }

    [Key]
    public long PerformedProcedureSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PerformedProcedureSer")]
    [InverseProperty("ScheduledPerformedProcedure")]
    public virtual PerformedProcedure PerformedProcedureSerNavigation { get; set; } = null!;

    [ForeignKey("ScheduledProcedureSer")]
    [InverseProperty("ScheduledPerformedProcedure")]
    public virtual ScheduledProcedure ScheduledProcedureSerNavigation { get; set; } = null!;
}
