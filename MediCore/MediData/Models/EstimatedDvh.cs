using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("EstimatedDVH")]
[Index("PlanSetupSer", Name = "XIF1EstimatedDVH")]
[Index("StructureSer", Name = "XIF2EstimatedDVH")]
public partial class EstimatedDvh
{
    [Key]
    [Column("EstimatedDVHSer")]
    public long EstimatedDvhser { get; set; }

    public long PlanSetupSer { get; set; }

    public long StructureSer { get; set; }

    [Column("DVHArray", TypeName = "image")]
    public byte[] Dvharray { get; set; } = null!;

    [StringLength(32)]
    public string Type { get; set; } = null!;

    public double BinWidth { get; set; }

    [StringLength(16)]
    public string DoseUnit { get; set; } = null!;

    [StringLength(16)]
    public string VolumeUnit { get; set; } = null!;

    public double? TargetDoseLevel { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("EstimatedDvh")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSer")]
    [InverseProperty("EstimatedDvh")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;
}
