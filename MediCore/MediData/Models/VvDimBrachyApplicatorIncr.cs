using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimBrachyApplicatorIncr
{
    [Column("ctrBrachyApplicatorSer")]
    public long CtrBrachyApplicatorSer { get; set; }

    [StringLength(16)]
    public string BrachyApplicatorId { get; set; } = null!;

    [StringLength(64)]
    public string? BrachyApplicatorName { get; set; }

    [StringLength(16)]
    public string? BrachyApplicatorTypeInfo { get; set; }

    public double? DefaultLength { get; set; }

    [StringLength(254)]
    public string? ManufacturerName { get; set; }

    public int? NoOfShapePoints { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Shape { get; set; }

    public int? NoOfSourceGeom { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SourceGeometry { get; set; }

    [StringLength(16)]
    public string? WallMaterialId { get; set; }

    public double? WallNominalTransmission { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public double? StepSize { get; set; }

    public double? FirstSourcePosition { get; set; }

    public double? LastSourcePosition { get; set; }

    public int SeparateSources { get; set; }

    public int? DefaultChannelNumber { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public double? DeadSpace { get; set; }
}
