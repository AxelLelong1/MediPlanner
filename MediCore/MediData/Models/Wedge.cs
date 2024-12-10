using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Wedge
{
    [Key]
    public long AddOnSer { get; set; }

    [StringLength(30)]
    public string? WedgeType { get; set; }

    public double? WedgeAngle { get; set; }

    [Column("ThinEdgeToX1Flag")]
    public int ThinEdgeToX1flag { get; set; }

    [Column("ThinEdgeToX2Flag")]
    public int ThinEdgeToX2flag { get; set; }

    [Column("ThinEdgeToY1Flag")]
    public int ThinEdgeToY1flag { get; set; }

    [Column("ThinEdgeToY2Flag")]
    public int ThinEdgeToY2flag { get; set; }

    public double? MaxCollX { get; set; }

    public double? MinCollX { get; set; }

    public double? MaxCollY { get; set; }

    public double? MinCollY { get; set; }

    public double? MaxX1 { get; set; }

    public double? MinX1 { get; set; }

    public double? MaxY1 { get; set; }

    public double? MinY1 { get; set; }

    public double? MaxX2 { get; set; }

    public double? MinX2 { get; set; }

    public double? MaxY2 { get; set; }

    public double? MinY2 { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Wedge")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("AddOnSerNavigation")]
    public virtual DynamicWedge? DynamicWedge { get; set; }

    [InverseProperty("AddOnSerNavigation")]
    public virtual StandardWedge? StandardWedge { get; set; }
}
