using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ScheduledProcedureSer", Name = "XIF1ScheduledProcedureItem")]
[Index("ProcedureItemSer", Name = "XIF2ScheduledProcedureItem")]
public partial class ScheduledProcedureItem
{
    [Key]
    public long ScheduledProcedureItemSer { get; set; }

    public long ScheduledProcedureSer { get; set; }

    public long ProcedureItemSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ProcedureItemSer")]
    [InverseProperty("ScheduledProcedureItem")]
    public virtual ProcedureItem ProcedureItemSerNavigation { get; set; } = null!;

    [ForeignKey("ScheduledProcedureSer")]
    [InverseProperty("ScheduledProcedureItem")]
    public virtual ScheduledProcedure ScheduledProcedureSerNavigation { get; set; } = null!;
}
