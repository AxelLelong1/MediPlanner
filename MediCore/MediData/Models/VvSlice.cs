using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSlice
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string StudyId { get; set; } = null!;

    public long StudySer { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [StringLength(16)]
    public string SeriesId { get; set; } = null!;

    [Column("SeriesUID")]
    [StringLength(64)]
    public string SeriesUid { get; set; } = null!;

    [StringLength(16)]
    public string SeriesModality { get; set; } = null!;

    public long SliceSer { get; set; }

    public long SeriesSer { get; set; }

    [Column("SliceUID")]
    [StringLength(64)]
    public string SliceUid { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    public int? SliceNumber { get; set; }

    public double? Position { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(30)]
    public string? SliceType { get; set; }

    [StringLength(16)]
    public string SliceModality { get; set; } = null!;

    public long? ResourceSer { get; set; }

    [StringLength(32)]
    public string? SliceFormat { get; set; }

    public int HeaderSize { get; set; }

    public int SizeX { get; set; }

    public int SizeY { get; set; }

    public int? AcqWindow { get; set; }

    public int? AcqLevel { get; set; }

    public double ResolutionX { get; set; }

    public double ResolutionY { get; set; }

    public int CalibratedFlag { get; set; }

    public int? PixelOffset { get; set; }

    public double? PixelSlope { get; set; }

    [MaxLength(96)]
    public byte[]? Transformation { get; set; }

    [StringLength(254)]
    public string? SliceCharacteristics { get; set; }

    [StringLength(16)]
    public string? PhotometricInterpretation { get; set; }

    public int BitsAllocated { get; set; }

    public int? BitsStored { get; set; }

    public double? CouchVrt { get; set; }

    public double? CouchLng { get; set; }

    public double? CouchLat { get; set; }

    public double? PatientSupportAngle { get; set; }

    public double? TableTopEccentricAngle { get; set; }

    [StringLength(16)]
    public string? ConversionType { get; set; }

    public int HighBit { get; set; }

    public double? PatSupportPitchAngle { get; set; }

    public double? PatSupportRollAngle { get; set; }

    public double? Thickness { get; set; }

    public long? EquipmentSer { get; set; }

    public int? NumberOfFrames { get; set; }

    [Column("DCTransferSyntaxSer")]
    public long? DctransferSyntaxSer { get; set; }

    public int IsLockedFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? PixelIntensityRel { get; set; }

    public int? PixelIntensitySign { get; set; }

    public int PixelRepresentation { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    public double? ActualPatientWeight { get; set; }

    public double? ActualPatientHeight { get; set; }

    public long? ContributingEquipmentSer { get; set; }

    [Column("SOPClassSer")]
    public long SopclassSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcquisitionDateTime { get; set; }

    [Column("IrradiationEventUID")]
    public string? IrradiationEventUid { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }
}
