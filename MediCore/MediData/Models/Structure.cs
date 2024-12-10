using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("MaterialSer", Name = "XIF855Structure")]
[Index("StructureSetSer", Name = "XIF856Structure")]
[Index("StructureTypeSer", Name = "XIF864Structure")]
[Index("PatientVolumeSer", Name = "XIF955Structure")]
public partial class Structure
{
    [Key]
    public long StructureSer { get; set; }

    public long StructureSetSer { get; set; }

    public long? PatientVolumeSer { get; set; }

    public long StructureTypeSer { get; set; }

    [StringLength(16)]
    public string StructureId { get; set; } = null!;

    [StringLength(64)]
    public string? StructureName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column("ROINumber")]
    public int Roinumber { get; set; }

    [Column("ROIObservationNumber")]
    public int RoiobservationNumber { get; set; }

    [StringLength(16)]
    public string? GenerationAlgorithm { get; set; }

    [StringLength(64)]
    public string? GenAlgoComment { get; set; }

    [Column("DVHLineColor")]
    public int DvhlineColor { get; set; }

    [Column("DVHLineStyle")]
    public int DvhlineStyle { get; set; }

    [Column("DVHLineWidth")]
    public double DvhlineWidth { get; set; }

    public int? FirstSlice { get; set; }

    public int? LastSlice { get; set; }

    [Column("MaterialCTValue")]
    public double? MaterialCtvalue { get; set; }

    public long? MaterialSer { get; set; }

    [Column("ROIPhysicalProperty")]
    [StringLength(254)]
    public string? RoiphysicalProperty { get; set; }

    [Column("ROIPhysicalPropertyValue")]
    [StringLength(254)]
    public string? RoiphysicalPropertyValue { get; set; }

    [Column("SearchCTHigh")]
    public double? SearchCthigh { get; set; }

    [Column("SearchCTLow")]
    public double? SearchCtlow { get; set; }

    [Column("EUDAlpha")]
    public double? Eudalpha { get; set; }

    [Column("TCPAlpha")]
    public double? Tcpalpha { get; set; }

    [Column("TCPBeta")]
    public double? Tcpbeta { get; set; }

    [Column("TCPGamma")]
    public double? Tcpgamma { get; set; }

    public double? ThicknessCm { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(255)]
    public string? Interpreter { get; set; }

    [Column("ROIObservationId")]
    [StringLength(16)]
    public string? RoiobservationId { get; set; }

    [Column("ROIMaterialId")]
    [StringLength(16)]
    public string? RoimaterialId { get; set; }

    [StringLength(16)]
    public string? VolumeCodeDesignator { get; set; }

    [StringLength(16)]
    public string? VolumeCodeVersion { get; set; }

    [StringLength(16)]
    public string? VolumeCodeValue { get; set; }

    [StringLength(64)]
    public string? VolumeCodeMeaning { get; set; }

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int IsVisible { get; set; }

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<DoseObjectives> DoseObjectives { get; set; } = new List<DoseObjectives>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<DvhestimationTrainingSetPlanSetupStructureMapping> DvhestimationTrainingSetPlanSetupStructureMapping { get; set; } = new List<DvhestimationTrainingSetPlanSetupStructureMapping>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<EstimatedDvh> EstimatedDvh { get; set; } = new List<EstimatedDvh>();

    [InverseProperty("BaseStructureSerNavigation")]
    public virtual ICollection<FieldSpecificTargetParameters> FieldSpecificTargetParametersBaseStructureSerNavigation { get; set; } = new List<FieldSpecificTargetParameters>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<FieldSpecificTargetParameters> FieldSpecificTargetParametersStructureSerNavigation { get; set; } = new List<FieldSpecificTargetParameters>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<FieldStructure> FieldStructure { get; set; } = new List<FieldStructure>();

    [ForeignKey("MaterialSer")]
    [InverseProperty("Structure")]
    public virtual Material? MaterialSerNavigation { get; set; }

    [ForeignKey("PatientVolumeSer")]
    [InverseProperty("Structure")]
    public virtual PatientVolume? PatientVolumeSerNavigation { get; set; }

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<PlanSetupStructureDoseLevel> PlanSetupStructureDoseLevel { get; set; } = new List<PlanSetupStructureDoseLevel>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<PlanSetupStructureModelStructure> PlanSetupStructureModelStructure { get; set; } = new List<PlanSetupStructureModelStructure>();

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<SourcePosition> SourcePosition { get; set; } = new List<SourcePosition>();

    [ForeignKey("StructureSetSer")]
    [InverseProperty("Structure")]
    public virtual StructureSet StructureSetSerNavigation { get; set; } = null!;

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<StructureStructureCode> StructureStructureCode { get; set; } = new List<StructureStructureCode>();

    [ForeignKey("StructureTypeSer")]
    [InverseProperty("Structure")]
    public virtual StructureType StructureTypeSerNavigation { get; set; } = null!;

    [InverseProperty("StructureSerNavigation")]
    public virtual ICollection<VolOptStruct> VolOptStruct { get; set; } = new List<VolOptStruct>();
}
