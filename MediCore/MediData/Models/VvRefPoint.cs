using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvRefPoint
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string PatientVolumeId { get; set; } = null!;

    public long RefPointSer { get; set; }

    public long PatientVolumeSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string RefPointId { get; set; } = null!;

    [StringLength(64)]
    public string? RefPointName { get; set; }

    [Column("RefPointUID")]
    [StringLength(64)]
    public string RefPointUid { get; set; } = null!;

    [StringLength(16)]
    public string? RefPointType { get; set; }

    public double? TotalDoseLimit { get; set; }

    public double? DailyDoseLimit { get; set; }

    public double? SessionDoseLimit { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
