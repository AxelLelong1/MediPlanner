using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSpatialRegistrationImage
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

    [Column("SpatialRegistrationIODId")]
    [StringLength(16)]
    public string SpatialRegistrationIodid { get; set; } = null!;

    [Column("SpatialRegistrationUID")]
    [StringLength(64)]
    public string SpatialRegistrationUid { get; set; } = null!;

    public long SpatialRegistrationSer { get; set; }

    [Column("SpatialRegistrationIODSer")]
    public long SpatialRegistrationIodser { get; set; }

    [Column("FrameOfReferenceUID")]
    [StringLength(64)]
    public string? FrameOfReferenceUid { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(16)]
    public string? RegTypeCodeValue { get; set; }

    [StringLength(64)]
    public string? RegTypeCodeMeaning { get; set; }

    [StringLength(16)]
    public string? RegTypeCodeDesignator { get; set; }

    [StringLength(16)]
    public string? RegTypeCodeVersion { get; set; }

    [StringLength(64)]
    public string? RegSubType { get; set; }

    [MaxLength(96)]
    public byte[] Transformation { get; set; } = null!;

    public double? AverageErrorDist { get; set; }

    public double? MaxErrorDist { get; set; }

    [StringLength(64)]
    public string? MatchAlgorithm { get; set; }

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
}
