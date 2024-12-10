using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvImage
{
    public long PatientSer { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

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

    public long ImageSer { get; set; }

    public long SeriesSer { get; set; }

    [StringLength(16)]
    public string ImageId { get; set; } = null!;

    [StringLength(64)]
    public string? ImageName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [StringLength(30)]
    public string? ImageType { get; set; }

    [StringLength(64)]
    public string Status { get; set; } = null!;

    public int? VolumetricPixelOffset { get; set; }

    public int ProcessedFlag { get; set; }

    public long? DefaultProcessingSer { get; set; }

    public long? OtherProcessingSer { get; set; }

    public long? GeometricParentSer { get; set; }

    public int ImageSizeX { get; set; }

    public int ImageSizeY { get; set; }

    public int ImageSizeZ { get; set; }

    public double ImageResX { get; set; }

    public double ImageResY { get; set; }

    public double ImageResZ { get; set; }

    public int InverseSliceOrder { get; set; }

    public double? FocusX { get; set; }

    public double? FocusY { get; set; }

    public double? FocusZ { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(16)]
    public string? PatientOrientation { get; set; }

    [StringLength(64)]
    public string? UsageType { get; set; }

    public int? ActWindow { get; set; }

    public int? ActLevel { get; set; }

    public double? VolumetricPixelSlope { get; set; }

    [StringLength(32)]
    public string? PixelUnit { get; set; }

    public int ImageNotesLen { get; set; }

    public string? ImageNotes { get; set; }

    [MaxLength(96)]
    public byte[]? Transformation { get; set; }

    [MaxLength(96)]
    public byte[]? VolumeTransformation { get; set; }

    [MaxLength(24)]
    public byte[]? UserOrigin { get; set; }

    [StringLength(254)]
    public string? UserOriginComment { get; set; }

    [MaxLength(96)]
    public byte[]? DisplayTransformation { get; set; }

    public string? ProcessingDefinition { get; set; }

    public int ProcessingDefinitionLen { get; set; }

    public int? FractionNumber { get; set; }

    public int? RefDicomSeqNumber { get; set; }

    [Column("Image4DSer")]
    public long? Image4Dser { get; set; }

    public int Flags4D { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
