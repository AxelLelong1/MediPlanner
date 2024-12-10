using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Simulator
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    public double? BeamTime { get; set; }

    [Column("XRayUnit")]
    [StringLength(64)]
    public string? XrayUnit { get; set; }

    [InverseProperty("SimulatorResourceSerNavigation")]
    public virtual ICollection<Ctsimulator> Ctsimulator { get; set; } = new List<Ctsimulator>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Simulator")]
    public virtual RadiationDevice ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("SimulatorResourceSerNavigation")]
    public virtual SimulationImager? SimulationImager { get; set; }
}
