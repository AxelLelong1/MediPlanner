using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledProcedureSer", "ObjectPointerSer")]
[Index("ObjectPointerSer", Name = "XIF2ScheduledObjectPointer")]
public partial class ScheduledObjectPointer
{
    [Key]
    public long ScheduledProcedureSer { get; set; }

    [Key]
    public long ObjectPointerSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ObjectPointerSer")]
    [InverseProperty("ScheduledObjectPointer")]
    public virtual ObjectPointer ObjectPointerSerNavigation { get; set; } = null!;

    [ForeignKey("ScheduledProcedureSer")]
    [InverseProperty("ScheduledObjectPointer")]
    public virtual ScheduledProcedure ScheduledProcedureSerNavigation { get; set; } = null!;
}
