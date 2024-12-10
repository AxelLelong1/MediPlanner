using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SliceCT")]
public partial class SliceCt
{
    [Key]
    public long SliceSer { get; set; }

    public double? RescaleIntercept { get; set; }

    public double? RescaleSlope { get; set; }

    [Column("KVP")]
    public double? Kvp { get; set; }

    public int? AcquisitionNumber { get; set; }

    [StringLength(64)]
    public string? ScanOptions { get; set; }

    public double? DataCollectionDiameter { get; set; }

    public double? ReconstructionDiameter { get; set; }

    public double? SourceDetectorDist { get; set; }

    public double? SourcePatientDist { get; set; }

    public double? GantryTilt { get; set; }

    [StringLength(16)]
    public string? RotationDirection { get; set; }

    public int? ExposureTime { get; set; }

    [Column("XRayTubeCurrent")]
    public int? XrayTubeCurrent { get; set; }

    public int? Exposure { get; set; }

    [StringLength(32)]
    public string? FilterType { get; set; }

    public int? GeneratorPower { get; set; }

    public double? FocalSpot { get; set; }

    [StringLength(32)]
    public string? ConvolutionKernel { get; set; }

    [StringLength(254)]
    public string? Mode { get; set; }

    [StringLength(254)]
    public string? Norm { get; set; }

    [Column("CTDIvol")]
    public double? Ctdivol { get; set; }

    [Column("PhantomTypeDICOMCodeValueSer")]
    public long? PhantomTypeDicomcodeValueSer { get; set; }

    /// <summary>
    /// The x coordinate (in the patient coordinate system) of the center of the region in which data were collected in [mm]. Maps to DICOM tag (0018,9313).
    /// </summary>
    public double? DataCollectionCenterX { get; set; }

    /// <summary>
    /// The y coordinate (in the patient coordinate system) of the center of the region in which data were collected in [mm]. Maps to DICOM tag (0018,9313).
    /// </summary>
    public double? DataCollectionCenterY { get; set; }

    /// <summary>
    /// The z coordinate (in the patient coordinate system) of the center of the region in which data were collected in [mm]. Maps to DICOM tag (0018,9313).
    /// </summary>
    public double? DataCollectionCenterZ { get; set; }

    [ForeignKey("SliceSer")]
    [InverseProperty("SliceCt")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
