using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("PlanModel", Schema = "DWH")]
public partial class PlanModel
{
    public long PatientSer { get; set; }

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    [StringLength(64)]
    public string? PlanSetupName { get; set; }

    [StringLength(16)]
    public string? TreatmentOrientation { get; set; }

    [StringLength(64)]
    public string? Status { get; set; }

    [StringLength(255)]
    public string? StatusUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StatusDate { get; set; }

    public double? DosePerFraction { get; set; }

    public int? IsActive { get; set; }

    [StringLength(16)]
    public string? TreatmentTechnique { get; set; }

    [StringLength(16)]
    public string? VolumeId { get; set; }

    public long? PrimaryRefPointSer { get; set; }

    [StringLength(16)]
    public string? PrimaryRefPointId { get; set; }

    public double? PrimaryRefPointDelivered { get; set; }

    public double? PrimaryRefPointPlanned { get; set; }

    public double? PrimaryRefPointRemaining { get; set; }

    public double? PrimaryRefPointDeliveredSum { get; set; }

    public double? PrimaryRefPointPlannedSum { get; set; }

    public double? PrimaryRefPointRemainingSum { get; set; }

    public int? NoFractionsPlanned { get; set; }

    public int? NoFractionsRemaining { get; set; }

    public int? NoFractionsTreated { get; set; }

    public int? NoFractionsPlannedSum { get; set; }

    public int? NoFractionsRemainingSum { get; set; }

    public int? NoFractionsTreatedSum { get; set; }

    public int? NoSessionRemaining { get; set; }

    [StringLength(1024)]
    public string? EnergyMode { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(16)]
    public string FractionId { get; set; } = null!;

    public int? StartDelay { get; set; }

    public int? FractionPatternDigitsPerDay { get; set; }

    [StringLength(64)]
    public string? FractionPattern { get; set; }

    [Column("PredecessorID")]
    [StringLength(16)]
    public string? PredecessorId { get; set; }

    public int? NoSessionPlanned { get; set; }

    public double? DoseCorrection { get; set; }

    [StringLength(254)]
    public string? PlanComment { get; set; }

    [StringLength(16)]
    public string? PlanIntent { get; set; }

    public long? PrescriptionSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastDayOfTreatment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FirstDayOfTreatment { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    public int? NoFractions { get; set; }

    public int? TreatmentOrder { get; set; }

    [Column("FirstRTPlanSer")]
    public long? FirstRtplanSer { get; set; }

    public int? Age { get; set; }

    public int? PlanRevision { get; set; }

    public long? PlanRelationshipSer { get; set; }

    [StringLength(16)]
    public string? RelationshipType { get; set; }

    [Column("RelatedRTPlanSer")]
    public long? RelatedRtplanSer { get; set; }

    [Column("RelatedPlanSOPClassSer")]
    public long? RelatedPlanSopclassSer { get; set; }

    [Column("PlanSOPClassSer")]
    public long PlanSopclassSer { get; set; }

    [Column("RelatedPlanUID")]
    [StringLength(64)]
    public string? RelatedPlanUid { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    public int? IsBrachy { get; set; }

    [Column("IMRTOrRapidArc")]
    [StringLength(16)]
    public string? ImrtorRapidArc { get; set; }

    [Column("RTTreatmentTechnique")]
    [StringLength(256)]
    public string? RttreatmentTechnique { get; set; }
}
