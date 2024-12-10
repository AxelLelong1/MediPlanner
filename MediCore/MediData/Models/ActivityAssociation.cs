using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SchedulableActivitySer", Name = "XIF607ActivityAssociation")]
[Index("NonSchedulableActivitySer", Name = "XIF609ActivityAssociation")]
public partial class ActivityAssociation
{
    [Key]
    public long ActivityAssociationSer { get; set; }

    public long NonSchedulableActivitySer { get; set; }

    public long SchedulableActivitySer { get; set; }

    public int DefaultFlag { get; set; }

    public int? DefaultPriorPostDueTime { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("NonSchedulableActivitySer")]
    [InverseProperty("ActivityAssociationNonSchedulableActivitySerNavigation")]
    public virtual Activity NonSchedulableActivitySerNavigation { get; set; } = null!;

    [ForeignKey("SchedulableActivitySer")]
    [InverseProperty("ActivityAssociationSchedulableActivitySerNavigation")]
    public virtual Activity SchedulableActivitySerNavigation { get; set; } = null!;
}
