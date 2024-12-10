using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("CourseModel", Schema = "DWH")]
public partial class CourseModel
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string? CourseId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CourseStartDateTime { get; set; }

    [StringLength(16)]
    public string? ClinicalStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FirstTreatmentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastTreatmentDate { get; set; }

    public int? NoTxSessionPlanned { get; set; }

    public int? NoTxSessionDelivered { get; set; }

    public int? NoTxSessionRemaining { get; set; }

    public double? DoseDelivered { get; set; }

    public int? CourseDuration { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string? CompletedByUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [StringLength(64)]
    public string? TreatmentIntentType { get; set; }

    public long? PhysicianIntentSer { get; set; }

    public long? DiagnosisSer { get; set; }
}
