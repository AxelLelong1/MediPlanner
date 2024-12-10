using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("CTSimulator")]
[Index("SimulatorResourceSer", Name = "XIF737CTSimulator")]
public partial class Ctsimulator
{
    [Key]
    public long ResourceSer { get; set; }

    public long SimulatorResourceSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalibrationDate { get; set; }

    [StringLength(64)]
    public string? CollimatorType { get; set; }

    [StringLength(64)]
    public string? MaterialType { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Ctsimulator")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;

    [ForeignKey("SimulatorResourceSer")]
    [InverseProperty("Ctsimulator")]
    public virtual Simulator SimulatorResourceSerNavigation { get; set; } = null!;
}
