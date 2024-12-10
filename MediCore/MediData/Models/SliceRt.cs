using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SliceRT")]
[Index("PlanSetupSer", Name = "XIF1013SliceRT")]
[Index("RadiationSer", Name = "XIF1014SliceRT")]
[Index("DoubleExposureSer", Name = "XIF1015SliceRT")]
public partial class SliceRt
{
    [Key]
    public long SliceSer { get; set; }

    public long? DoubleExposureSer { get; set; }

    [StringLength(16)]
    public string? ReportedValuesOrigin { get; set; }

    [Column("IDUPosLat")]
    public double? IduposLat { get; set; }

    [Column("IDUPosLng")]
    public double? IduposLng { get; set; }

    [Column("IDUSID")]
    public double? Idusid { get; set; }

    [Column("IDURtn")]
    public double? Idurtn { get; set; }

    public int? Energy { get; set; }

    [Column("SAD")]
    public double? Sad { get; set; }

    [StringLength(16)]
    public string? PrimaryDosimeterUnit { get; set; }

    public double? MetersetExposure { get; set; }

    public int? ExposureTime { get; set; }

    public double? CollX1 { get; set; }

    public double? CollX2 { get; set; }

    public double? CollY1 { get; set; }

    public double? CollY2 { get; set; }

    [Column("SliceRTType")]
    [StringLength(30)]
    public string SliceRttype { get; set; } = null!;

    public int OpenField { get; set; }

    public int? DoseRate { get; set; }

    public double? StartCumulativeMeterset { get; set; }

    public double? EndCumulativeMeterset { get; set; }

    [StringLength(1024)]
    public string? AcqNote { get; set; }

    public double? GantryAngle { get; set; }

    public double? CollRtn { get; set; }

    public double? BladeX1 { get; set; }

    public double? BladeX2 { get; set; }

    public double? BladeY1 { get; set; }

    public double? BladeY2 { get; set; }

    [Column("IDUCorrectionLat")]
    public double? IducorrectionLat { get; set; }

    [Column("IDUCorrectionLng")]
    public double? IducorrectionLng { get; set; }

    [Column("XRayTubeCurrent")]
    public int? XrayTubeCurrent { get; set; }

    [Column("RTImagePositionX")]
    public double? RtimagePositionX { get; set; }

    [Column("RTImagePositionY")]
    public double? RtimagePositionY { get; set; }

    public double? OffPlaneAngle { get; set; }

    public double? IsoCenterPositionX { get; set; }

    public double? IsoCenterPositionY { get; set; }

    public double? IsoCenterPositionZ { get; set; }

    [StringLength(16)]
    public string? PrimaryFluenceModeId { get; set; }

    public long? RadiationSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public int UpdateOnBeamChange { get; set; }

    public int ReferenceImage { get; set; }

    [StringLength(16)]
    public string? RadiationMachineName { get; set; }

    [ForeignKey("DoubleExposureSer")]
    [InverseProperty("SliceRt")]
    public virtual Image1? DoubleExposureSerNavigation { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("SliceRt")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("SliceRt")]
    public virtual Radiation? RadiationSerNavigation { get; set; }

    [ForeignKey("SliceSer")]
    [InverseProperty("SliceRt")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
