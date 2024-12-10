using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvRadiation
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

    public long RadiationSer { get; set; }

    public long? ResourceSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

    [StringLength(64)]
    public string? RadiationName { get; set; }

    [StringLength(32)]
    public string RadiationType { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int RadiationNumber { get; set; }

    [StringLength(64)]
    public string? TechniqueLabel { get; set; }

    public int? RadiationOrder { get; set; }

    public long? RefImageSer { get; set; }

    [StringLength(254)]
    public string? SetupNote { get; set; }

    [Column("RefImageUID")]
    [StringLength(64)]
    public string? RefImageUid { get; set; }

    [Column("RefImageSOPClassSer")]
    public long? RefImageSopclassSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }
}
