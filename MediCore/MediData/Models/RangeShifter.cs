using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class RangeShifter
{
    [Key]
    public long AddOnSer { get; set; }

    public double? IsoRangeShifterDist { get; set; }

    [StringLength(32)]
    public string RangeShifterType { get; set; } = null!;

    public int MovesWithSnout { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("RangeShifter")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;
}
