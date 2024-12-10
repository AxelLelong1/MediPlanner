using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSeries
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string StudyId { get; set; } = null!;

    public long SeriesSer { get; set; }

    public long? StudySer { get; set; }

    [StringLength(16)]
    public string SeriesId { get; set; } = null!;

    [StringLength(64)]
    public string? SeriesName { get; set; }

    public int? SeriesNumber { get; set; }

    [Column("SeriesUID")]
    [StringLength(64)]
    public string SeriesUid { get; set; } = null!;

    [StringLength(30)]
    public string SeriesType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(32)]
    public string? BodyPartExamined { get; set; }

    [StringLength(32)]
    public string? PatientOrientation { get; set; }

    [StringLength(16)]
    public string SeriesModality { get; set; } = null!;

    [StringLength(32)]
    public string? AcquisitionType { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(64)]
    public string? ReconstructionType4D { get; set; }

    public double? ReconstructionPhase4D { get; set; }

    [StringLength(64)]
    public string? PositionReferenceIndicator { get; set; }

    [Column("FrameOfReferenceUID")]
    [StringLength(64)]
    public string? FrameOfReferenceUid { get; set; }

    public int ResampledSeriesFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? ResourceSer { get; set; }

    public long? RelatedCourseSer { get; set; }

    public long? RelatedPlanSetupSer { get; set; }

    public long? RelatedRadiationSer { get; set; }

    public long? RelatedDiagnosisSer { get; set; }
}
