using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DemGroupSer", Name = "XIF986DemExternalBeam")]
[Index("EnergyModeSer", Name = "XIF987DemExternalBeam")]
[Index("PrimaryFluenceModeSer", Name = "XIF988DemExternalBeam")]
[Index("TechniqueSer", Name = "XIF989DemExternalBeam")]
public partial class DemExternalBeam
{
    [Key]
    public long DemExternalBeamSer { get; set; }

    public long DemGroupSer { get; set; }

    public long EnergyModeSer { get; set; }

    public long? PrimaryFluenceModeSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? TechniqueSer { get; set; }

    [ForeignKey("DemGroupSer")]
    [InverseProperty("DemExternalBeam")]
    public virtual DemGroup DemGroupSerNavigation { get; set; } = null!;

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("DemExternalBeam")]
    public virtual EnergyMode EnergyModeSerNavigation { get; set; } = null!;

    [ForeignKey("PrimaryFluenceModeSer")]
    [InverseProperty("DemExternalBeam")]
    public virtual PrimaryFluenceMode? PrimaryFluenceModeSerNavigation { get; set; }

    [ForeignKey("TechniqueSer")]
    [InverseProperty("DemExternalBeam")]
    public virtual Technique? TechniqueSerNavigation { get; set; }
}
