using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

/// <summary>
/// MLCPlanSer, RadiationSer, CompensatorSer, and FieldVariationSer are mutually exclusive.
/// </summary>
[Index("MlcplanSer", Name = "XIF1Matrix")]
[Index("RadiationSer", Name = "XIF2Matrix")]
[Index("CompensatorSer", Name = "XIF3Matrix")]
[Index("FieldVariationSer", Name = "XIFMatrixFieldVariationSer")]
public partial class Matrix
{
    [Key]
    public long MatrixSer { get; set; }

    [StringLength(16)]
    public string MatrixId { get; set; } = null!;

    [StringLength(64)]
    public string? MatrixName { get; set; }

    [StringLength(30)]
    public string MatrixType { get; set; } = null!;

    /// <summary>
    /// Describes the data type of the matrix. Defined values are 
    /// Transmission/Thickness/Energy/Compensator Distal End/Target Distal End/Target Proximal End/Fluence
    /// </summary>
    [StringLength(32)]
    public string MatrixDataType { get; set; } = null!;

    [StringLength(64)]
    public string? UsageType { get; set; }

    [StringLength(254)]
    public string? MatrixFileName { get; set; }

    public int? SizeX { get; set; }

    public int? SizeY { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(32)]
    public string? ContextDetails { get; set; }

    public int GantryCoordinates { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    /// <summary>
    /// Identifies the MLC plan to which this transmission matrix belongs. Foreign key to MLCPLan.MLCPlanSer.
    /// </summary>
    [Column("MLCPlanSer")]
    public long? MlcplanSer { get; set; }

    /// <summary>
    /// Identifies the field to which this transmission matrix belongs. Foreign key to ExternalField.RadiationSer
    /// </summary>
    public long? RadiationSer { get; set; }

    /// <summary>
    /// Identifies the compensator to which this transmission matrix belongs. Foreign key to Compensator.CompensatorSer.
    /// </summary>
    public long? CompensatorSer { get; set; }

    /// <summary>
    /// This FK relation allows storing IMRT fluence matrices specific to a field variation. This allows a field variation to represent variation in fluence space.
    /// </summary>
    public long? FieldVariationSer { get; set; }

    [ForeignKey("CompensatorSer")]
    [InverseProperty("Matrix")]
    public virtual Compensator? CompensatorSerNavigation { get; set; }

    [ForeignKey("FieldVariationSer")]
    [InverseProperty("Matrix")]
    public virtual FieldVariation? FieldVariationSerNavigation { get; set; }

    [ForeignKey("MlcplanSer")]
    [InverseProperty("Matrix")]
    public virtual Mlcplan? MlcplanSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("Matrix")]
    public virtual ExternalField? RadiationSerNavigation { get; set; }
}
