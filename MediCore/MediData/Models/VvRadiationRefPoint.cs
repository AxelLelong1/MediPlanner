using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvRadiationRefPoint
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

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

    [StringLength(16)]
    public string RefPointId { get; set; } = null!;

    public long RadiationSer { get; set; }

    public long RefPointSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long? CacheKeySer { get; set; }

    public double? FieldDose { get; set; }

    public int DoseSpecificationFlag { get; set; }

    public double? Depth { get; set; }

    [Column("PSSD")]
    public double? Pssd { get; set; }

    public int DominantFieldFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int NominalFlag { get; set; }
}
