using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ApplicatorSer", "EnergyModeSer", Name = "XIE1ApplicatorJawSize")]
[Index("EnergyModeSer", Name = "XIF734Applicator")]
public partial class ApplicatorJawSize
{
    [Key]
    public long ApplicatorJawSizeSer { get; set; }

    public long ApplicatorSer { get; set; }

    public long EnergyModeSer { get; set; }

    public double? CollX { get; set; }

    public double? CollY { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ApplicatorSer")]
    [InverseProperty("ApplicatorJawSize")]
    public virtual Applicator ApplicatorSerNavigation { get; set; } = null!;

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("ApplicatorJawSize")]
    public virtual EnergyMode EnergyModeSerNavigation { get; set; } = null!;
}
