using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AddOnSer", Name = "XIF721ControlPointProton")]
public partial class ControlPointProton
{
    [Key]
    public long ControlPointSer { get; set; }

    public long? AddOnSer { get; set; }

    public double? SnoutPosition { get; set; }

    public double? NozzleEquivalentRange { get; set; }

    public double? PeakRange { get; set; }

    public int? NumberOfSpots { get; set; }

    public int? NumberOfPaintings { get; set; }

    public double? SpotSizeX { get; set; }

    public double? SpotSizeY { get; set; }

    public double? RangeMod1InterruptStart { get; set; }

    public double? RangeMod1InterruptStop { get; set; }

    [Column("RangeMod1WeTStart")]
    public double? RangeMod1WeTstart { get; set; }

    [Column("RangeMod1WeTStop")]
    public double? RangeMod1WeTstop { get; set; }

    public int? RangeMod1DicomSeqNumb { get; set; }

    public double? RangeMod2InterruptStart { get; set; }

    public double? RangeMod2InterruptStop { get; set; }

    [Column("RangeMod2WeTStart")]
    public double? RangeMod2WeTstart { get; set; }

    [Column("RangeMod2WeTStop")]
    public double? RangeMod2WeTstop { get; set; }

    public int? RangeMod2DicomSeqNumb { get; set; }

    public double? IsocenterToRangeMod1Dist { get; set; }

    public double? IsocenterToRangeMod2Dist { get; set; }

    [StringLength(64)]
    public string? LateralSpreadDev1Setting { get; set; }

    public double? LateralSpreadDev1WeT { get; set; }

    public double? IsoToLatSpreadDev1Dist { get; set; }

    public int? LatSpreadDev1DcmSeqNumb { get; set; }

    [StringLength(64)]
    public string? LateralSpreadDev2Setting { get; set; }

    public double? LateralSpreadDev2WeT { get; set; }

    public double? IsoToLatSpreadDev2Dist { get; set; }

    public int? LatSpreadDev2DcmSeqNumb { get; set; }

    [StringLength(64)]
    public string? LateralSpreadDev3Setting { get; set; }

    public double? LateralSpreadDev3WeT { get; set; }

    public double? IsoToLatSpreadDev3Dist { get; set; }

    public int? LatSpreadDev3DcmSeqNumb { get; set; }

    [StringLength(64)]
    public string? RangeShifter1Setting { get; set; }

    public double? RangeShifter1WeT { get; set; }

    public double? IsoToRangeShifter1Dist { get; set; }

    public int? RangeShifter1DcmSeqNumb { get; set; }

    [StringLength(64)]
    public string? RangeShifter2Setting { get; set; }

    public double? RangeShifter2WeT { get; set; }

    public double? IsoToRangeShifter2Dist { get; set; }

    public int? RangeShifter2DcmSeqNumb { get; set; }

    [StringLength(64)]
    public string? RangeShifter3Setting { get; set; }

    public double? RangeShifter3WeT { get; set; }

    public double? IsoToRangeShifter3Dist { get; set; }

    public int? RangeShifter3DcmSeqNumb { get; set; }

    public int UserPreselectEnergy { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ApertureShape { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("ControlPointProton")]
    public virtual AddOn? AddOnSerNavigation { get; set; }

    [ForeignKey("ControlPointSer")]
    [InverseProperty("ControlPointProton")]
    public virtual ControlPoint ControlPointSerNavigation { get; set; } = null!;
}
