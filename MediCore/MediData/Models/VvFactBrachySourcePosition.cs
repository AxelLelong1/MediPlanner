using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactBrachySourcePosition
{
    [StringLength(16)]
    public string SourcePositionId { get; set; } = null!;

    [StringLength(64)]
    public string? SourcePositionName { get; set; }

    public double? DwellPosition { get; set; }

    public double? DwellTime { get; set; }

    public long? StructureSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int DwellTimeLockedFlag { get; set; }

    public double? DwellTimeMaxLimit { get; set; }

    public double? DwellTimeMinLimit { get; set; }

    [Column("ctrSourcePositionSer")]
    public long CtrSourcePositionSer { get; set; }

    [Column("ctrRadiationSer")]
    public long CtrRadiationSer { get; set; }

    [Column("ctrRadioactiveSourceSer")]
    public long? CtrRadioactiveSourceSer { get; set; }
}
