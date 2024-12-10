using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class MillingMachine
{
    [Key]
    public long ResourceSer { get; set; }

    public int DefaultFlag { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<DrillBit> DrillBit { get; set; } = new List<DrillBit>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("MillingMachine")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;
}
