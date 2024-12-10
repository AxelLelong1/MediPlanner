using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class RangeModulator
{
    [Key]
    public long AddOnSer { get; set; }

    public double? IsocenterRangeModDist { get; set; }

    [StringLength(32)]
    public string RangeModulatorType { get; set; } = null!;

    [ForeignKey("AddOnSer")]
    [InverseProperty("RangeModulator")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;
}
