using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimOperatingLimit
{
    [StringLength(32)]
    public string ParameterType { get; set; } = null!;

    [StringLength(64)]
    public string? ParameterName { get; set; }

    public double? MinValue { get; set; }

    public double? MaxValue { get; set; }

    public double? DefValue { get; set; }

    public int? LimitPrecision { get; set; }

    public int? TolerancePossible { get; set; }

    [StringLength(64)]
    public string? MotionMode { get; set; }

    public double? MaxSpeed { get; set; }

    [Column("ctrOperatingLimitSer")]
    public long CtrOperatingLimitSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }
}
