using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ProtonCompensator
{
    [Key]
    public long CompensatorSer { get; set; }

    public int BolusFlag { get; set; }

    public double? CompMillingToolDiameter { get; set; }

    public double? CompStoppingPowerRatio { get; set; }

    [StringLength(16)]
    public string? MillingMachineId { get; set; }

    [ForeignKey("CompensatorSer")]
    [InverseProperty("ProtonCompensator")]
    public virtual Compensator CompensatorSerNavigation { get; set; } = null!;
}
