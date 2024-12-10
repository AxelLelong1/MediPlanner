using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("EnergyModeSer", "DoseRateValue", "PrimaryFluenceModeSer", Name = "XAK1DoseRate", IsUnique = true)]
[Index("PrimaryFluenceModeSer", Name = "XIF815DoseRate")]
public partial class DoseRate
{
    [Key]
    public long DoseRateSer { get; set; }

    public long EnergyModeSer { get; set; }

    public int DoseRateValue { get; set; }

    public int? RepRate { get; set; }

    public int? DefaultFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public long? PrimaryFluenceModeSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int DefPortalImagingFlag { get; set; }

    public int LowPortalImagingFlag { get; set; }

    public int ConeBeamFlag { get; set; }

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("DoseRate")]
    public virtual EnergyMode EnergyModeSerNavigation { get; set; } = null!;

    [ForeignKey("PrimaryFluenceModeSer")]
    [InverseProperty("DoseRate")]
    public virtual PrimaryFluenceMode? PrimaryFluenceModeSerNavigation { get; set; }
}
