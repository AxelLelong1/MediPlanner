using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class RadioactiveSourceModel
{
    [Key]
    public long RadioactiveSourceModelSer { get; set; }

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

    [StringLength(254)]
    public string? AnisotropyTable { get; set; }

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
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(1024)]
    public string? LiteratureReference { get; set; }

    [StringLength(32)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [InverseProperty("RadioactiveSourceModelSerNavigation")]
    public virtual ICollection<RadioactiveSource> RadioactiveSource { get; set; } = new List<RadioactiveSource>();
}
