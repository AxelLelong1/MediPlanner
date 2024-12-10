using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimRadioactiveModelSource
{
    [StringLength(16)]
    public string RadioactiveSourceId { get; set; } = null!;

    [StringLength(64)]
    public string? RadioactiveSourceName { get; set; }

    public int? SourceNumber { get; set; }

    [StringLength(64)]
    public string? SourceSerialNo { get; set; }

    public double? SourceStrength { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalibrationDate { get; set; }

    [StringLength(254)]
    public string? RadioactiveSourceComment { get; set; }

    [StringLength(16)]
    public string RadioactiveSourceObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string RadioactiveSourceHstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RadioactiveSourceHstryDateTime { get; set; }

    [StringLength(16)]
    public string RadioactiveSourceModelId { get; set; } = null!;

    [StringLength(64)]
    public string? RadioactiveSourceModelName { get; set; }

    [StringLength(64)]
    public string? RadioIsotopType { get; set; }

    public double? HalfTime { get; set; }

    [StringLength(64)]
    public string? ManufacturerName { get; set; }

    [StringLength(16)]
    public string? SourceType { get; set; }

    public double? ActivityConversionFact { get; set; }

    public double? DoseRateConstant { get; set; }

    [MaxLength(24)]
    public byte[]? ActiveSize { get; set; }

    [MaxLength(24)]
    public byte[]? TotalSize { get; set; }

    [StringLength(16)]
    public string? DoseCalcModel { get; set; }

    [StringLength(32)]
    public string? RadDoseFunctionType { get; set; }

    public int? RadDoseFunctionNoOfValues { get; set; }

    [MaxLength(240)]
    public byte[]? RadDoseFunctionValuesX { get; set; }

    [MaxLength(240)]
    public byte[]? RadDoseFunctionValuesY { get; set; }

    [StringLength(254)]
    public string? RadioactiveSourceModelComment { get; set; }

    [StringLength(1024)]
    public string? LiteratureReference { get; set; }

    [StringLength(32)]
    public string RadioactiveSourceModelStatus { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RadioactiveSourceModelStatusDate { get; set; }

    [StringLength(255)]
    public string RadioactiveSourceModelHstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RadioactiveSourceModelHstryDateTime { get; set; }

    [Column("ctrRadioactiveSourceModelSer")]
    public long CtrRadioactiveSourceModelSer { get; set; }

    [Column("ctrRadioactiveSourceSer")]
    public long CtrRadioactiveSourceSer { get; set; }

    [Column("ctrResourceSer")]
    public long? CtrResourceSer { get; set; }
}
