using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RadiationSer", "RadioactiveSourceSer", Name = "XIE1SourcePosition")]
[Index("RadioactiveSourceSer", Name = "XIF412SourcePosition")]
[Index("StructureSer", Name = "XIF700SourcePosition")]
public partial class SourcePosition
{
    [Key]
    public long SourcePositionSer { get; set; }

    public long RadiationSer { get; set; }

    public long? RadioactiveSourceSer { get; set; }

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

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    /// <summary>
    /// Identifies if the dwell time of this dwell position is locked. 1 = locked; it is not allowed to change the dwell time, 
    /// unless the plan is e.g. normalized, or dwell times are rounded to machine resolution. 0 = unlocked; it is allowed to change the dwell time.
    /// </summary>
    public int DwellTimeLockedFlag { get; set; }

    public double? DwellTimeMaxLimit { get; set; }

    public double? DwellTimeMinLimit { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("SourcePosition")]
    public virtual BrachyField RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("RadioactiveSourceSer")]
    [InverseProperty("SourcePosition")]
    public virtual RadioactiveSource? RadioactiveSourceSerNavigation { get; set; }

    [ForeignKey("StructureSer")]
    [InverseProperty("SourcePosition")]
    public virtual Structure? StructureSerNavigation { get; set; }
}
