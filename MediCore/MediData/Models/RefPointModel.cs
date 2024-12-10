using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("RefPointModel", Schema = "DWH")]
public partial class RefPointModel
{
    [StringLength(16)]
    public string? CourseId { get; set; }

    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    [StringLength(16)]
    public string? RefPointId { get; set; }

    [StringLength(64)]
    public string? RefPointName { get; set; }

    public double? CourseDosePlanned { get; set; }

    public double? CourseDoseDelivered { get; set; }

    public double? CourseDoseRemaining { get; set; }

    public double? OtherCourseDoseDelivered { get; set; }

    public double? DosePredictedInOtherCourses { get; set; }

    public double? DoseCorrection { get; set; }

    public double? TotalDoseLimit { get; set; }

    public double? DailyDoseLimit { get; set; }

    public double? SessionDoseLimit { get; set; }

    public double? BreakPointDose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BreakPointDate { get; set; }

    [StringLength(254)]
    public string? BreakPointNote { get; set; }

    public int? NoTxSessionRemaining { get; set; }

    public int? NoTxSessionPlanned { get; set; }

    public int? NoTxSessionDelivered { get; set; }

    public int? PrimaryFlag { get; set; }

    public int? FractionsDelivered { get; set; }

    public int? FractionsPlanned { get; set; }

    public int? FractionsRemaining { get; set; }

    public double? DosePerFraction { get; set; }

    public double? DoseDelivered { get; set; }

    public double? DoseRemainingInFraction { get; set; }

    public double? RunningPartial { get; set; }

    public double? DoseRemainingMax { get; set; }

    public double? DoseRemainingMin { get; set; }

    public double? DoseRemaining { get; set; }

    public double? DosePredictedMax { get; set; }

    public double? DosePredictedMin { get; set; }

    public double? DosePredicted { get; set; }

    public int? BreakPointNum { get; set; }

    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public long? RefPointSer { get; set; }

    public long? BreakPointSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }
}
