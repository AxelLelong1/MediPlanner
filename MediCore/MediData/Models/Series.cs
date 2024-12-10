using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SeriesUid", Name = "XAK1Series", IsUnique = true)]
[Index("FrameOfReferenceUid", "SeriesSer", Name = "XIE2Series")]
[Index("StudySer", "SeriesSer", Name = "XIE3Series")]
[Index("ResourceSer", Name = "XIF943Series")]
[Index("RelatedCourseSer", Name = "XIF946Series")]
[Index("RelatedPlanSetupSer", Name = "XIF947Series")]
[Index("RelatedRadiationSer", Name = "XIF948Series")]
public partial class Series
{
    [Key]
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

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<Image1> Image1 { get; set; } = new List<Image1>();

    [ForeignKey("RelatedCourseSer")]
    [InverseProperty("Series")]
    public virtual Course? RelatedCourseSerNavigation { get; set; }

    [ForeignKey("RelatedPlanSetupSer")]
    [InverseProperty("Series")]
    public virtual PlanSetup? RelatedPlanSetupSerNavigation { get; set; }

    [ForeignKey("RelatedRadiationSer")]
    [InverseProperty("Series")]
    public virtual ExternalField? RelatedRadiationSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Series")]
    public virtual Machine? ResourceSerNavigation { get; set; }

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<Rtplan> Rtplan { get; set; } = new List<Rtplan>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<SessionProcedure> SessionProcedure { get; set; } = new List<SessionProcedure>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<Slice> Slice { get; set; } = new List<Slice>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<SpatialRegistrationIod> SpatialRegistrationIod { get; set; } = new List<SpatialRegistrationIod>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<StructureSet> StructureSet { get; set; } = new List<StructureSet>();

    [ForeignKey("StudySer")]
    [InverseProperty("Series")]
    public virtual Study? StudySerNavigation { get; set; }

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<Tracking> Tracking { get; set; } = new List<Tracking>();

    [InverseProperty("SeriesSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecord { get; set; } = new List<TreatmentRecord>();
}
