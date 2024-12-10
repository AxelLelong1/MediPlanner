using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ExtBeamResourceSer", Name = "XIF739PortImager")]
public partial class PortImager
{
    [Key]
    public long ResourceSer { get; set; }

    public long ExtBeamResourceSer { get; set; }

    public int DefaultFlag { get; set; }

    [Column("SAD")]
    public double? Sad { get; set; }

    public double? Gantry { get; set; }

    public double? GantryPitch { get; set; }

    public double? RadSourceGantryDelta { get; set; }

    [ForeignKey("ExtBeamResourceSer")]
    [InverseProperty("PortImager")]
    public virtual ExternalBeam ExtBeamResourceSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("PortImager")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;
}
