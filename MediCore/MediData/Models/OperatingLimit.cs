using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ParameterType", "ResourceSer", "TechniqueSer", "PrimaryFluenceModeSer", Name = "XAKOperatingLimit", IsUnique = true)]
[Index("TechniqueSer", Name = "XIF1010OperatingLimit")]
[Index("PrimaryFluenceModeSer", Name = "XIF1011OperatingLimit")]
public partial class OperatingLimit
{
    [Key]
    public long OperatingLimitSer { get; set; }

    public long ResourceSer { get; set; }

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

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? PrimaryFluenceModeSer { get; set; }

    public long? TechniqueSer { get; set; }

    [ForeignKey("PrimaryFluenceModeSer")]
    [InverseProperty("OperatingLimit")]
    public virtual PrimaryFluenceMode? PrimaryFluenceModeSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("OperatingLimit")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;

    [ForeignKey("TechniqueSer")]
    [InverseProperty("OperatingLimit")]
    public virtual Technique? TechniqueSerNavigation { get; set; }
}
