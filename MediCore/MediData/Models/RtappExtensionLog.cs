using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RTAppExtensionLog")]
public partial class RtappExtensionLog
{
    [Key]
    [Column("RTAppExtensionLogSer")]
    public long RtappExtensionLogSer { get; set; }

    [Column("RTAppExtensionSer")]
    public long RtappExtensionSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public long? StructureSetSer { get; set; }

    [StringLength(16)]
    public string? DetailsFormatVersion { get; set; }

    public string? Details { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("RtappExtensionLog")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("RtappExtensionSer")]
    [InverseProperty("RtappExtensionLog")]
    public virtual RtappExtension RtappExtensionSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSetSer")]
    [InverseProperty("RtappExtensionLog")]
    public virtual StructureSet? StructureSetSerNavigation { get; set; }
}
