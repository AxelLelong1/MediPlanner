using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Tray
{
    [Key]
    public long AddOnSer { get; set; }

    public int CompensatorDefault { get; set; }

    public double? ProtonWaterEquiThickness { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Tray")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("TrayAddOnSerNavigation")]
    public virtual ICollection<Block> Block { get; set; } = new List<Block>();

    [InverseProperty("TrayAddOnSerNavigation")]
    public virtual ICollection<Compensator> Compensator { get; set; } = new List<Compensator>();
}
