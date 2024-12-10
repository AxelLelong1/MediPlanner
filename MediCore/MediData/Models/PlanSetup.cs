using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", Name = "XIE5PlanSetup")]
[Index("CourseSer", "PlanSetupSer", "Status", Name = "XIE7PlanSetup")]
[Index("PatientSupportDeviceSer", Name = "XIF731PlanSetup")]
[Index("EquipmentSer", Name = "XIF950PlanSetup")]
[Index("StructureSetSer", Name = "XIF953PlanSetup")]
[Index("ImageSer", Name = "XIF954PlanSetup")]
[Index("PrimaryPtvser", Name = "XIF955PlanSetup")]
[Index("PrescriptionSer", Name = "XIF956PlanSetup")]
public partial class PlanSetup
{
    [Key]
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

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<BrachySolidApplicator> BrachySolidApplicator { get; set; } = new List<BrachySolidApplicator>();

    [ForeignKey("CourseSer")]
    [InverseProperty("PlanSetup")]
    public virtual Course CourseSerNavigation { get; set; } = null!;

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<DoseObjectives> DoseObjectives { get; set; } = new List<DoseObjectives>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<Dvh> Dvh { get; set; } = new List<Dvh>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<DvhestimationTrainingSetPlanSetup> DvhestimationTrainingSetPlanSetup { get; set; } = new List<DvhestimationTrainingSetPlanSetup>();

    [ForeignKey("EquipmentSer")]
    [InverseProperty("PlanSetup")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<EstimatedDvh> EstimatedDvh { get; set; } = new List<EstimatedDvh>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<FieldSpecificTargetParameters> FieldSpecificTargetParameters { get; set; } = new List<FieldSpecificTargetParameters>();

    [ForeignKey("ImageSer")]
    [InverseProperty("PlanSetup")]
    public virtual Image1? ImageSerNavigation { get; set; }

    [ForeignKey("PatientSupportDeviceSer")]
    [InverseProperty("PlanSetup")]
    public virtual PatientSupportDevice? PatientSupportDeviceSerNavigation { get; set; }

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<PlanSetupStructureDoseLevel> PlanSetupStructureDoseLevel { get; set; } = new List<PlanSetupStructureDoseLevel>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<PlanSetupStructureModelStructure> PlanSetupStructureModelStructure { get; set; } = new List<PlanSetupStructureModelStructure>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<PlanSumPlanSetup> PlanSumPlanSetup { get; set; } = new List<PlanSumPlanSetup>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<PlanVariation> PlanVariation { get; set; } = new List<PlanVariation>();

    [ForeignKey("PrescriptionSer")]
    [InverseProperty("PlanSetup")]
    public virtual Prescription? PrescriptionSerNavigation { get; set; }

    [ForeignKey("PrimaryPtvser")]
    [InverseProperty("PlanSetup")]
    public virtual PatientVolume? PrimaryPtvserNavigation { get; set; }

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<Radiation> Radiation { get; set; } = new List<Radiation>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<RtappExtensionLog> RtappExtensionLog { get; set; } = new List<RtappExtensionLog>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<Rtplan> Rtplan { get; set; } = new List<Rtplan>();

    [InverseProperty("RelatedPlanSetupSerNavigation")]
    public virtual ICollection<Series> Series { get; set; } = new List<Series>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<SliceRt> SliceRt { get; set; } = new List<SliceRt>();

    [ForeignKey("StructureSetSer")]
    [InverseProperty("PlanSetup")]
    public virtual StructureSet? StructureSetSerNavigation { get; set; }

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<Tracking> Tracking { get; set; } = new List<Tracking>();

    [InverseProperty("PlanSetupSerNavigation")]
    public virtual ICollection<VolOptConstraints> VolOptConstraints { get; set; } = new List<VolOptConstraints>();
}
