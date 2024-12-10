using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

/// <summary>
/// Only one of the four FKs PlanSetupSer, RadiationSer, FieldVariationSer or PlanVariationSer may be not null in a single row.
/// </summary>
[Index("DoseUid", Name = "XAK1DoseMatrix", IsUnique = true)]
[Index("SeriesSer", Name = "XIF849DoseMatrix")]
[Index("EquipmentSer", Name = "XIF894DoseMatrix")]
[Index("PatientSer", Name = "XIF943DoseMatrix")]
[Index("PlanSetupSer", Name = "XIF975DoseMatrix")]
[Index("RadiationSer", Name = "XIF977DoseMatrix")]
[Index("FieldVariationSer", Name = "XIF978DoseMatrix")]
[Index("PlanVariationSer", Name = "XIFDoseMatrixPlanVariationSer")]
public partial class DoseMatrix
{
    [Key]
    public long DoseMatrixSer { get; set; }

    public long SeriesSer { get; set; }

    [StringLength(16)]
    public string DoseMatrixId { get; set; } = null!;

    [StringLength(64)]
    public string? DoseMatrixName { get; set; }

    public long? PatientSer { get; set; }

    public int? SizeX { get; set; }

    public int? SizeY { get; set; }

    public int? SizeZ { get; set; }

    public double? ResX { get; set; }

    public double? ResY { get; set; }

    public double? ResZ { get; set; }

    [MaxLength(96)]
    public byte[]? Transformation { get; set; }

    [StringLength(254)]
    public string? DoseMatrixFile { get; set; }

    [StringLength(32)]
    public string? DoseDistributionType { get; set; }

    [StringLength(16)]
    public string? Unit { get; set; }

    public double? Scaler { get; set; }

    [StringLength(16)]
    public string? Location { get; set; }

    [StringLength(32)]
    public string? Medium { get; set; }

    [Column(TypeName = "image")]
    public byte[]? IsodoseLevels { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(254)]
    public string? CreationNote { get; set; }

    public int? Offset { get; set; }

    public int BitsAllocated { get; set; }

    [Column("DoseUID")]
    [StringLength(64)]
    public string DoseUid { get; set; } = null!;

    [StringLength(64)]
    public string? DoseComment { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    /// <summary>
    /// Internal Identification (Serial Number which is the Primary Key to the Table). 
    /// The vp_syGetNextKey procedure retrieves the key from the NextKeyTable. If not null, this DoseMatrix 
    /// is the field dose of a Radiation.
    /// </summary>
    public long? RadiationSer { get; set; }

    /// <summary>
    /// Internal Identification (Serial Number which is the Primary Key to the Table). 
    /// The vp_syGetNextKey procedure retrieves the key from the NextKeyTable. If not null, this DoseMatrix 
    /// is the plan dose of a PlanSetup.
    /// </summary>
    public long? PlanSetupSer { get; set; }

    public long? FieldVariationSer { get; set; }

    /// <summary>
    /// Foreign key to PlanVariation table. If not null, this DoseMatrix is the plan dose of a PlanVariation.
    /// </summary>
    public long? PlanVariationSer { get; set; }

    [ForeignKey("EquipmentSer")]
    [InverseProperty("DoseMatrix")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [ForeignKey("FieldVariationSer")]
    [InverseProperty("DoseMatrix")]
    public virtual FieldVariation? FieldVariationSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("DoseMatrix")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("DoseMatrix")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("PlanVariationSer")]
    [InverseProperty("DoseMatrix")]
    public virtual PlanVariation? PlanVariationSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("DoseMatrix")]
    public virtual Radiation? RadiationSerNavigation { get; set; }

    [ForeignKey("SeriesSer")]
    [InverseProperty("DoseMatrix")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;
}
