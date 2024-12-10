using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class StandardWedge
{
    [Key]
    public long AddOnSer { get; set; }

    public int? MotorizedFlag { get; set; }

    public double? SourceWedgeDist { get; set; }

    public int OmniWedgeFlag { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("StandardWedge")]
    public virtual Wedge AddOnSerNavigation { get; set; } = null!;
}
