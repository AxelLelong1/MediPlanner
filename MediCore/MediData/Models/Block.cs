using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AddOnMaterialSer", Name = "XIF435Block")]
[Index("RadiationSer", Name = "XIF436Block")]
[Index("MillingMachineResourceSer", Name = "XIF437Block")]
[Index("TrayAddOnSer", Name = "XIF438Block")]
public partial class Block
{
    [Key]
    public long BlockSer { get; set; }

    public long RadiationSer { get; set; }

    public long? AddOnMaterialSer { get; set; }

    public long? TrayAddOnSer { get; set; }

    [StringLength(64)]
    public string BlockId { get; set; } = null!;

    public int DicomSeqNumber { get; set; }

    [StringLength(32)]
    public string? BlockType { get; set; }

    public int AboveTrayFlag { get; set; }

    public int DivergingFlag { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Coordinates { get; set; }

    public int CoordinatesLen { get; set; }

    public int EllipticalMarginFlag { get; set; }

    [Column("BEVMarginFlag")]
    public int BevmarginFlag { get; set; }

    public double? LeftMargin { get; set; }

    public double? RightMargin { get; set; }

    public double? TopMargin { get; set; }

    public double? BottomMargin { get; set; }

    public int OptimizeCollRtnFlag { get; set; }

    public int OptimizeFldSizeFlag { get; set; }

    public double? BlockThickness { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? MillingMachineResourceSer { get; set; }

    public double? DrillBitDiameter { get; set; }

    public double? SnoutPositionUsedForMillingCorrection { get; set; }

    public int MillingCorrectionConfiguredFlag { get; set; }

    [StringLength(64)]
    public string? CustomCode { get; set; }

    [ForeignKey("AddOnMaterialSer")]
    [InverseProperty("Block")]
    public virtual AddOnMaterial? AddOnMaterialSerNavigation { get; set; }

    [InverseProperty("BlockSerNavigation")]
    public virtual ICollection<FieldStructure> FieldStructure { get; set; } = new List<FieldStructure>();

    [ForeignKey("MillingMachineResourceSer")]
    [InverseProperty("Block")]
    public virtual Resource? MillingMachineResourceSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("Block")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("TrayAddOnSer")]
    [InverseProperty("Block")]
    public virtual Tray? TrayAddOnSerNavigation { get; set; }
}
