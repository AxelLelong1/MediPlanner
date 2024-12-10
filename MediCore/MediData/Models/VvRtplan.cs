using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvRtplan
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("PlanSOPClassSer")]
    public long PlanSopclassSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    public int? NoFractions { get; set; }

    public int? StartDelay { get; set; }

    public int DicomSeqNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int? InterfaceStamp { get; set; }

    public double? PrescribedDose { get; set; }

    public long SeriesSer { get; set; }

    public byte[]? PlanIntegrityHash { get; set; }

    public int? PlanHashVersion { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? TreatmentOrder { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    public int? FractionPatternDigitsPerDay { get; set; }

    [StringLength(64)]
    public string? FractionPattern { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }
}
