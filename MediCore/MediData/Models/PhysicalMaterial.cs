using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PhysicalMaterial
{
    [Key]
    public long PhysicalMaterialSer { get; set; }

    [StringLength(16)]
    public string PhysicalMaterialId { get; set; } = null!;

    public double DefaultMassDensity { get; set; }

    public double? MinimumMassDensity { get; set; }

    public double? MaximumMassDensity { get; set; }

    public int LookupFlag { get; set; }

    public int ReadOnlyFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string PhysicalMaterialVersion { get; set; } = null!;
}
