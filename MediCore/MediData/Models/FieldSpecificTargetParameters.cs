using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanSetupSer", Name = "XIF1FieldSpecificTargetParameters")]
[Index("StructureSer", Name = "XIF2FieldSpecificTargetParameters")]
[Index("BaseStructureSer", Name = "XIF3FieldSpecificTargetParameters")]
public partial class FieldSpecificTargetParameters
{
    [Key]
    public long FieldSpecificTargetParametersSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public long? StructureSer { get; set; }

    public long? BaseStructureSer { get; set; }

    public int SetupErrorSymmetricFlag { get; set; }

    public double? SetupErrorX1 { get; set; }

    public double? SetupErrorX2 { get; set; }

    public double? SetupErrorY1 { get; set; }

    public double? SetupErrorY2 { get; set; }

    public double? SetupErrorZ1 { get; set; }

    public double? SetupErrorZ2 { get; set; }

    public int InternalTargetMotionSymmetricFlag { get; set; }

    public double? InternalTargetMotionX1 { get; set; }

    public double? InternalTargetMotionX2 { get; set; }

    public double? InternalTargetMotionY1 { get; set; }

    public double? InternalTargetMotionY2 { get; set; }

    public double? InternalTargetMotionZ1 { get; set; }

    public double? InternalTargetMotionZ2 { get; set; }

    public int SmearingMarginOverrideFlag { get; set; }

    public int SmearingMarginSymmetricFlag { get; set; }

    public double? SmearingMarginX1 { get; set; }

    public double? SmearingMarginX2 { get; set; }

    public double? SmearingMarginY1 { get; set; }

    public double? SmearingMarginY2 { get; set; }

    public double? RangeUncertaintyPercentage { get; set; }

    public double? ProximalSafetyMargin { get; set; }

    public double? DistalSafetyMargin { get; set; }

    public double? GantryRtn { get; set; }

    public double? PatientSupportAngle { get; set; }

    public double? IsoCenterX { get; set; }

    public double? IsoCenterY { get; set; }

    public double? IsoCenterZ { get; set; }

    [Column("SAD")]
    public double? Sad { get; set; }

    [StringLength(16)]
    public string? PlanTreatmentOrientation { get; set; }

    public double? SnoutMaxRadius { get; set; }

    public double? SnoutMaxX { get; set; }

    public double? SnoutMaxY { get; set; }

    public int? SnoutRectangularFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("BaseStructureSer")]
    [InverseProperty("FieldSpecificTargetParametersBaseStructureSerNavigation")]
    public virtual Structure? BaseStructureSerNavigation { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("FieldSpecificTargetParameters")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("StructureSer")]
    [InverseProperty("FieldSpecificTargetParametersStructureSerNavigation")]
    public virtual Structure? StructureSerNavigation { get; set; }
}
