using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("DoseContributionModel", Schema = "DWH")]
public partial class DoseContributionModel
{
    public long PatientSer { get; set; }

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long RefPointSer { get; set; }

    [StringLength(16)]
    public string RefPointId { get; set; } = null!;

    public int? PrimaryRefPoint { get; set; }

    public long RadiationSer { get; set; }

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

    public double? PlannedFieldDose { get; set; }

    public double? DeliveredFieldDose { get; set; }

    public double? DoseCorrection { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CorrectionDateTime { get; set; }

    public long? RefPointLogSer { get; set; }

    public long? DoseCorrectionLogSer { get; set; }

    [StringLength(254)]
    public string? CorrectionNote { get; set; }
}
