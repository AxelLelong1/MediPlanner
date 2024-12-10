using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PfdefaultEnergySer", Name = "XIF249ExternalBeam")]
public partial class ExternalBeam
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(30)]
    public string? ExternalBeamType { get; set; }

    public int CobaltFlag { get; set; }

    public double? BeamAngle { get; set; }

    public double? StopAngle { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    [Column("SAD")]
    public double? Sad { get; set; }

    [Column("SPD")]
    public double? Spd { get; set; }

    [Column("PFDefaultEnergySer")]
    public long? PfdefaultEnergySer { get; set; }

    [Column("PFMaxMuAllow")]
    public int? PfmaxMuAllow { get; set; }

    public int FixedBeamFlag { get; set; }

    public int ImagerAutoCorrFlag { get; set; }

    public double? ImagerAutoCorrTolerance { get; set; }

    public int UserPreselectableBeamLine { get; set; }

    public long? DefPortalImagingEnergySer { get; set; }

    public long? LowPortalImagingEnergySer { get; set; }

    public long? ConeBeamEnergySer { get; set; }

    [StringLength(16)]
    public string PrimaryDosimeterUnit { get; set; } = null!;

    public double? ShutterError { get; set; }

    [Column("MLCAndBlockInTheSameFieldFlag")]
    public int MlcandBlockInTheSameFieldFlag { get; set; }

    public int VirtualConeFlag { get; set; }

    /// <summary>
    /// Couch Representation on the User Interface. Defaults to IsocentricStdVar if null.
    /// See Imaging SyRS for descriptions of different couch representations.
    /// Defined Terms are IEC61217, IsocentricStdVar.
    /// The terms are extensible if support of a new representation is covered in system wide requirements.
    /// IsocentricStdVar means &quot;Isocentric Standard&quot;, except from cases where application logic along the 
    /// Imaging SyRS defines a fallback to the legacy &quot;Isocentric Varian&quot;. This is the case for older versions of OBI or PVA.
    /// 
    /// </summary>
    [StringLength(16)]
    public string? CouchRepresentation { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<AddOn> AddOn { get; set; } = new List<AddOn>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<EnergyMode> EnergyMode { get; set; } = new List<EnergyMode>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ExternalFieldHstry> ExternalFieldHstry { get; set; } = new List<ExternalFieldHstry>();

    [ForeignKey("PfdefaultEnergySer")]
    [InverseProperty("ExternalBeam")]
    public virtual EnergyMode? PfdefaultEnergySerNavigation { get; set; }

    [InverseProperty("ExtBeamResourceSerNavigation")]
    public virtual ICollection<PortImager> PortImager { get; set; } = new List<PortImager>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("ExternalBeam")]
    public virtual RadiationDevice ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Technique> Technique { get; set; } = new List<Technique>();
}
