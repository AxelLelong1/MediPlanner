using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", "RadiationType", "Energy", Name = "XAK1EnergyMode", IsUnique = true)]
public partial class EnergyMode
{
    [Key]
    public long EnergyModeSer { get; set; }

    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string RadiationType { get; set; } = null!;

    public int Energy { get; set; }

    public int? MaxEnergy { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int? MinDoseRate { get; set; }

    public int? MaxDoseRate { get; set; }

    public int? DefaultFlag { get; set; }

    [StringLength(32)]
    public string? DisplayCode { get; set; }

    public int? InternalCode { get; set; }

    public int? LevelCode { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public double? AbsDoseRefFieldSize { get; set; }

    [Column("AbsDoseCalibSPD")]
    public double? AbsDoseCalibSpd { get; set; }

    public double? AbsDoseCalibDepth { get; set; }

    public double? RefDoseGyAtCalibDepth { get; set; }

    [Column("RefDoseMUAtCalibDepth")]
    public double? RefDoseMuatCalibDepth { get; set; }

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<ApplicatorJawSize> ApplicatorJawSize { get; set; } = new List<ApplicatorJawSize>();

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<ConfiguredEmt> ConfiguredEmt { get; set; } = new List<ConfiguredEmt>();

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<DemExternalBeam> DemExternalBeam { get; set; } = new List<DemExternalBeam>();

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<DoseRate> DoseRate { get; set; } = new List<DoseRate>();

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<DosimetricData> DosimetricData { get; set; } = new List<DosimetricData>();

    [InverseProperty("PfdefaultEnergySerNavigation")]
    public virtual ICollection<ExternalBeam> ExternalBeam { get; set; } = new List<ExternalBeam>();

    [InverseProperty("EnergyModeSerNavigation")]
    public virtual ICollection<ExternalFieldCommon> ExternalFieldCommon { get; set; } = new List<ExternalFieldCommon>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("EnergyMode")]
    public virtual ExternalBeam ResourceSerNavigation { get; set; } = null!;
}
