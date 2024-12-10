using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("OverrideModel", Schema = "DWH")]
public partial class OverrideModel
{
    public long? PatientSer { get; set; }

    [StringLength(32)]
    public string? OverrideParameters { get; set; }

    [StringLength(255)]
    public string? AuthorizedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizationDate { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string? CourseId { get; set; }

    public long? PlanSetupSer { get; set; }

    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    public long? RadiationSer { get; set; }

    public double? DoseDelta { get; set; }

    public long? PatientVolumeSer { get; set; }

    public long? RefPointSer { get; set; }

    public long? RefPointLogSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }
}
