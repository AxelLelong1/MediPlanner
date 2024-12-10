using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDoseContribution
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    [StringLength(16)]
    public string RefPointId { get; set; } = null!;

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long RefPointSer { get; set; }

    public long? CacheKeySer { get; set; }

    public double? DosePerFraction { get; set; }

    public int PrimaryFlag { get; set; }

    public int DicomSeqNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
