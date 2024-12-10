using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AddOnMaterialSer", "EnergyModeSer", "PrimaryFluenceModeSer", Name = "XAK1DosimetricData", IsUnique = true)]
[Index("EnergyModeSer", Name = "XIF513DosimetricData")]
[Index("PrimaryFluenceModeSer", Name = "XIF821DosimetricData")]
public partial class DosimetricData
{
    [Key]
    public long DosimetricDataSer { get; set; }

    public long AddOnMaterialSer { get; set; }

    public long EnergyModeSer { get; set; }

    public long? PrimaryFluenceModeSer { get; set; }

    public double? TransmissionFact { get; set; }

    public double? LinearAttenFact { get; set; }

    public double? WedgeFactor { get; set; }

    public double? DosimetricLeafGap { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnMaterialSer")]
    [InverseProperty("DosimetricData")]
    public virtual AddOnMaterial AddOnMaterialSerNavigation { get; set; } = null!;

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("DosimetricData")]
    public virtual EnergyMode EnergyModeSerNavigation { get; set; } = null!;

    [ForeignKey("PrimaryFluenceModeSer")]
    [InverseProperty("DosimetricData")]
    public virtual PrimaryFluenceMode? PrimaryFluenceModeSerNavigation { get; set; }
}
