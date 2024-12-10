using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AavLinkRttempTable1
{
    [Column("SPID")]
    public long Spid { get; set; }

    [Column("MLCPlanSer")]
    public long? MlcplanSer { get; set; }

    public double? IndexValues { get; set; }

    public long? PointCount { get; set; }

    public long? LeafNumber { get; set; }

    public double? DynamicPosTolerance { get; set; }

    public double? LeftLeafPosition { get; set; }

    public double? RightLeafPosition { get; set; }

    [StringLength(1)]
    public string? UpdateFlag { get; set; }
}
