using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Snout
{
    [Key]
    public long AddOnSer { get; set; }

    public double? MaxRadius { get; set; }

    public double? MaxX { get; set; }

    public double? MaxY { get; set; }

    public int RectangularFlag { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Snout")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;
}
