using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("CourseSer", Name = "XIF1TreatmentPhase")]
[Index("RelTreatmentPhaseSer", Name = "XIF2TreatmentPhase")]
public partial class TreatmentPhase
{
    [Key]
    public long TreatmentPhaseSer { get; set; }

    public long CourseSer { get; set; }

    public long? RelTreatmentPhaseSer { get; set; }

    [StringLength(32)]
    public string? TimeGapType { get; set; }

    public int? PhaseGapNumberOfDays { get; set; }

    [StringLength(256)]
    public string? OtherInfo { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("TreatmentPhase")]
    public virtual Course CourseSerNavigation { get; set; } = null!;

    [InverseProperty("RelTreatmentPhaseSerNavigation")]
    public virtual ICollection<TreatmentPhase> InverseRelTreatmentPhaseSerNavigation { get; set; } = new List<TreatmentPhase>();

    [InverseProperty("TreatmentPhaseSerNavigation")]
    public virtual ICollection<Prescription> Prescription { get; set; } = new List<Prescription>();

    [ForeignKey("RelTreatmentPhaseSer")]
    [InverseProperty("InverseRelTreatmentPhaseSerNavigation")]
    public virtual TreatmentPhase? RelTreatmentPhaseSerNavigation { get; set; }
}
