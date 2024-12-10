using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SimulatorResourceSer", Name = "XIF738SimulationImager", IsUnique = true)]
public partial class SimulationImager
{
    [Key]
    public long ResourceSer { get; set; }

    public long SimulatorResourceSer { get; set; }

    [StringLength(32)]
    public string? CalibrationAccuracy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalibrationDate { get; set; }

    public double? ExposureTime { get; set; }

    [StringLength(64)]
    public string? VideoBoard { get; set; }

    [Column("NoOfXLines")]
    public int? NoOfXlines { get; set; }

    [Column("NoOfYLines")]
    public int? NoOfYlines { get; set; }

    public double ResolutionX { get; set; }

    public double ResolutionY { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("SimulationImager")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;

    [ForeignKey("SimulatorResourceSer")]
    [InverseProperty("SimulationImager")]
    public virtual Simulator SimulatorResourceSerNavigation { get; set; } = null!;
}
