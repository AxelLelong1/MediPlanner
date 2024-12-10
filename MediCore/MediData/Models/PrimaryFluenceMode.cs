using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PrimaryFluenceMode
{
    [Key]
    public long AddOnSer { get; set; }

    public double? MaxCollX { get; set; }

    public double? MaxCollY { get; set; }

    public double? MaxX1 { get; set; }

    public double? MaxX2 { get; set; }

    public double? MaxY1 { get; set; }

    public double? MaxY2 { get; set; }

    public double? MinCollX { get; set; }

    public double? MinCollY { get; set; }

    public double? MinX1 { get; set; }

    public double? MinX2 { get; set; }

    public double? MinY1 { get; set; }

    public double? MinY2 { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("PrimaryFluenceMode")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("PrimaryFluenceModeSerNavigation")]
    public virtual ICollection<DemExternalBeam> DemExternalBeam { get; set; } = new List<DemExternalBeam>();

    [InverseProperty("PrimaryFluenceModeSerNavigation")]
    public virtual ICollection<DoseRate> DoseRate { get; set; } = new List<DoseRate>();

    [InverseProperty("PrimaryFluenceModeSerNavigation")]
    public virtual ICollection<DosimetricData> DosimetricData { get; set; } = new List<DosimetricData>();

    [InverseProperty("PrimaryFluenceModeSerNavigation")]
    public virtual ICollection<OperatingLimit> OperatingLimit { get; set; } = new List<OperatingLimit>();
}
