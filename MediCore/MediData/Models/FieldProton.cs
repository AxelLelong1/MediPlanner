using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrimaryRadiationSer", Name = "XIF2FieldProton")]
public partial class FieldProton
{
    [Key]
    public long RadiationSer { get; set; }

    public double? AirGap { get; set; }

    [StringLength(64)]
    public string? FieldModifiersSet { get; set; }

    public double? DistalEndDistance { get; set; }

    public double? DistalEndEnergy { get; set; }

    public int IsocenterMarginFlag { get; set; }

    public long? PrimaryRadiationSer { get; set; }

    public double? ProximalEndDistance { get; set; }

    public int SnoutPositionInputFlag { get; set; }

    public double? TargetUncertaintyMarginX1 { get; set; }

    public double? TargetUncertaintyMarginX2 { get; set; }

    public double? TargetUncertaintyMarginY1 { get; set; }

    public double? TargetUncertaintyMarginY2 { get; set; }

    [Column("VirtualSADX")]
    public double VirtualSadx { get; set; }

    [Column("VirtualSADY")]
    public double VirtualSady { get; set; }

    [StringLength(16)]
    public string? BeamCurrModulationId { get; set; }

    [StringLength(16)]
    public string? BeamlineDataTableVers { get; set; }

    [StringLength(64)]
    public string? BeamlineSettingsId { get; set; }

    [Column("SOBPWidth")]
    public double? Sobpwidth { get; set; }

    public double? HeadFixationAngle { get; set; }

    public double? FixLightPolarPos { get; set; }

    public double? FixLightAzimuthAngle { get; set; }

    public double? WedgeOrientation { get; set; }

    public double? WedgeThinEdgePos { get; set; }

    public int Status { get; set; }

    public double? SnoutFitPosition { get; set; }

    [Column("UserPreselectedSOBP")]
    public short UserPreselectedSobp { get; set; }

    public short UserPreselectedRange { get; set; }

    [StringLength(254)]
    public string? SpotListFile { get; set; }

    public short? ScanningTechnique { get; set; }

    [InverseProperty("PrimaryRadiationSerNavigation")]
    public virtual ICollection<FieldProton> InversePrimaryRadiationSerNavigation { get; set; } = new List<FieldProton>();

    [ForeignKey("PrimaryRadiationSer")]
    [InverseProperty("InversePrimaryRadiationSerNavigation")]
    public virtual FieldProton? PrimaryRadiationSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("FieldProton")]
    public virtual ExternalField RadiationSerNavigation { get; set; } = null!;
}
