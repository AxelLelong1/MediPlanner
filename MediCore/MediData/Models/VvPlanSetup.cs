using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPlanSetup
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    public long? PatientSupportDeviceSer { get; set; }

    public long? PrescriptionSer { get; set; }

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    [StringLength(64)]
    public string? PlanSetupName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    public double? PlanNormFactor { get; set; }

    [StringLength(64)]
    public string? PlanNormMethod { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(16)]
    public string? TreatmentTechnique { get; set; }

    [StringLength(16)]
    public string? ApplicationSetupType { get; set; }

    public int? ApplicationSetupNumber { get; set; }

    [StringLength(16)]
    public string TreatmentType { get; set; } = null!;

    public string? CalcModelOptions { get; set; }

    public int CalcModelOptionsLen { get; set; }

    [StringLength(16)]
    public string? TreatmentOrientation { get; set; }

    public double? PrescribedPercentage { get; set; }

    [Column("PrimaryPTVSer")]
    public long? PrimaryPtvser { get; set; }

    public int IrregFlag { get; set; }

    public string? FieldRules { get; set; }

    public int FieldRulesLen { get; set; }

    public double? SkinFlashMargin { get; set; }

    [StringLength(64)]
    public string? ProtocolPhaseId { get; set; }

    public int MultiFieldOptFlag { get; set; }

    public long? CopyOfSer { get; set; }

    public long? StructureSetSer { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? RaySearchPrivateData { get; set; }

    public int RaySearchPrivateDataLen { get; set; }

    [StringLength(16)]
    public string? Intent { get; set; }

    [MaxLength(96)]
    public byte[]? ViewingPlane { get; set; }

    [Column("ViewingPlaneULCorner")]
    [MaxLength(24)]
    public byte[]? ViewingPlaneUlcorner { get; set; }

    [Column("ViewingPlaneLRCorner")]
    [MaxLength(24)]
    public byte[]? ViewingPlaneLrcorner { get; set; }

    public double? BrachyPdrPulseInterval { get; set; }

    public int? BrachyPdrNoOfPulses { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    public long? ImageSer { get; set; }
}
