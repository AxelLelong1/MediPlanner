using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyExternalFieldHstryAddOn
{
    [StringLength(16)]
    public string? BeamCurrentModulationId { get; set; }

    [StringLength(64)]
    public string? BeamModifiersSet { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    public double? CollRtn { get; set; }

    public byte CollRtnOverrideFlag { get; set; }

    public double? CollX1 { get; set; }

    [Column("CollX1OverrideFlag")]
    public byte CollX1overrideFlag { get; set; }

    public double? CollX2 { get; set; }

    [Column("CollX2OverrideFlag")]
    public byte CollX2overrideFlag { get; set; }

    public double? CollY1 { get; set; }

    [Column("CollY1OverrideFlag")]
    public byte CollY1overrideFlag { get; set; }

    public double? CollY2 { get; set; }

    [Column("CollY2OverrideFlag")]
    public byte CollY2overrideFlag { get; set; }

    public double? DistalEndEnergy { get; set; }

    public int? DoseRate { get; set; }

    public byte DoseRateOverrideFlag { get; set; }

    public double? FixLightAzimuthAngle { get; set; }

    public double? FixLightPolarPos { get; set; }

    public double? GantryRtn { get; set; }

    [StringLength(16)]
    public string? GantryRtnDirection { get; set; }

    [StringLength(16)]
    public string? GantryRtnExt { get; set; }

    public byte GantryRtnOverrideFlag { get; set; }

    public int? IntendedNumOfPaintings { get; set; }

    [Column("MUpDeg")]
    public double? MupDeg { get; set; }

    [Column("MUpDegOverrideFlag")]
    public byte MupDegOverrideFlag { get; set; }

    public byte NumOfPaintOverrideFlag { get; set; }

    public double? OffPlaneAngle { get; set; }

    [Column("PSACorrection")]
    public double? Psacorrection { get; set; }

    public long RadiationHstrySer { get; set; }

    public long? ResourceSer { get; set; }

    [Column("SOBPWidth")]
    public double? Sobpwidth { get; set; }

    public byte SnoutPosOverrideFlag { get; set; }

    public double? SnoutPosition { get; set; }

    public double? StopAngle { get; set; }

    [StringLength(16)]
    public string? Technique { get; set; }

    public double? WedgeAngle { get; set; }

    public double? WedgeAngle2 { get; set; }

    public double? WedgeDirection { get; set; }

    public double? WedgeDirection2 { get; set; }

    public double? WedgeDose { get; set; }

    public byte WedgeDoseOverrideFlag { get; set; }

    public int? WedgeNumber1 { get; set; }

    public int? WedgeNumber2 { get; set; }

    [StringLength(16)]
    public string? AddOnId1 { get; set; }

    [StringLength(16)]
    public string? AddOnId2 { get; set; }

    [StringLength(16)]
    public string? AddOnId3 { get; set; }

    [StringLength(16)]
    public string? AddOnId4 { get; set; }

    [StringLength(16)]
    public string? AddOnId5 { get; set; }

    [StringLength(16)]
    public string? AddOnId6 { get; set; }

    [StringLength(16)]
    public string? AddOnId7 { get; set; }

    [StringLength(16)]
    public string? AddOnId8 { get; set; }

    [StringLength(16)]
    public string? AddOnId9 { get; set; }

    [StringLength(16)]
    public string? AddOnId10 { get; set; }

    [StringLength(30)]
    public string? AddOnType1 { get; set; }

    [StringLength(30)]
    public string? AddOnType2 { get; set; }

    [StringLength(30)]
    public string? AddOnType3 { get; set; }

    [StringLength(30)]
    public string? AddOnType4 { get; set; }

    [StringLength(30)]
    public string? AddOnType5 { get; set; }

    [StringLength(30)]
    public string? AddOnType6 { get; set; }

    [StringLength(30)]
    public string? AddOnType7 { get; set; }

    [StringLength(30)]
    public string? AddOnType8 { get; set; }

    [StringLength(30)]
    public string? AddOnType9 { get; set; }

    [StringLength(30)]
    public string? AddOnType10 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType1 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType2 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType3 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType4 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType5 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType6 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType7 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType8 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType9 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType10 { get; set; }
}
