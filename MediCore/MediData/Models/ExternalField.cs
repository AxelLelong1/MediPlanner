using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TrackingSer", Name = "XIF2ExternalField")]
[Index("BaselinePortalDoseSer", Name = "XIF4ExternalField")]
public partial class ExternalField
{
    [Key]
    public long RadiationSer { get; set; }

    public double? GantryRtn { get; set; }

    public double? CollRtn { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    public double? CollX1 { get; set; }

    public double? CollY1 { get; set; }

    public double? CollX2 { get; set; }

    public double? CollY2 { get; set; }

    public double? TimepGy { get; set; }

    [StringLength(16)]
    public string? GantryRtnDirection { get; set; }

    [StringLength(16)]
    public string? GantryRtnExt { get; set; }

    public int? DoseRate { get; set; }

    public double? StopAngle { get; set; }

    public double? WedgeDose { get; set; }

    [Column("BEVMarginFlag")]
    public int BevmarginFlag { get; set; }

    public double? CollMarginBottom { get; set; }

    public string? CalculationLog { get; set; }

    public int CalculationLogLen { get; set; }

    public double? DirectionPointDistance { get; set; }

    public int EllipticalMarginFlag { get; set; }

    public double? FldNormFactor { get; set; }

    [StringLength(64)]
    public string? FldNormMethod { get; set; }

    public double? CollMarginLeft { get; set; }

    [Column("MUCoeff")]
    public double? Mucoeff { get; set; }

    [Column("MUCoeffMWOpen")]
    public double? MucoeffMwopen { get; set; }

    [Column("MUCoeffMWWedged")]
    public double? MucoeffMwwedged { get; set; }

    [Column("MUCoeffMWVirtual")]
    public double? MucoeffMwvirtual { get; set; }

    public int OptimizeCollRtnFlag { get; set; }

    public int SkinFlashFlag { get; set; }

    [Column("DRRTemplateFileName")]
    [StringLength(254)]
    public string? DrrtemplateFileName { get; set; }

    public double? RefDose { get; set; }

    [Column("RefDoseMWOpen")]
    public double? RefDoseMwopen { get; set; }

    [Column("RefDoseMWWedged")]
    public double? RefDoseMwwedged { get; set; }

    [Column("RefDoseMWVirtual")]
    public double? RefDoseMwvirtual { get; set; }

    public double? CollMarginRight { get; set; }

    public double? CollMarginTop { get; set; }

    public double? WedgeWeightFactor { get; set; }

    public double? WeightFactor { get; set; }

    public long? TrackingSer { get; set; }

    public double? DesiredDoseAtIsocenter { get; set; }

    [StringLength(16)]
    public string? MuCoeffUnit { get; set; }

    public long? BaselinePortalDoseSer { get; set; }

    [ForeignKey("BaselinePortalDoseSer")]
    [InverseProperty("ExternalField")]
    public virtual Image1? BaselinePortalDoseSerNavigation { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual FieldProton? FieldProton { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<Matrix> Matrix { get; set; } = new List<Matrix>();

    [ForeignKey("RadiationSer")]
    [InverseProperty("ExternalField")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [InverseProperty("RelatedRadiationSerNavigation")]
    public virtual ICollection<Series> Series { get; set; } = new List<Series>();

    [ForeignKey("TrackingSer")]
    [InverseProperty("ExternalField")]
    public virtual Tracking? TrackingSerNavigation { get; set; }
}
