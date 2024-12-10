using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("Image")]
[Index("SeriesSer", "ImageId", Name = "XIE1Image")]
[Index("HstryDateTime", Name = "XIE3Image")]
[Index("CreationDate", Name = "XIE4Image")]
[Index("Image4Dser", "ImageSer", Name = "XIE5Image")]
[Index("SeriesSer", "ImageSer", Name = "XIE6Image")]
[Index("ImageSer", "PatientSer", "ImageType", "Status", "CreationDate", Name = "XIE7Image")]
[Index("PatientSer", Name = "XIE8Image")]
[Index("PatientSer", Name = "XIF948Image")]
[Index("DefaultProcessingSer", Name = "XIF949Image")]
[Index("OtherProcessingSer", Name = "XIF950Image")]
[Index("GeometricParentSer", Name = "XIF951Image")]
public partial class Image1
{
    [Key]
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

    public long? PatientSer { get; set; }

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

    [ForeignKey("DefaultProcessingSer")]
    [InverseProperty("Image1DefaultProcessingSerNavigation")]
    public virtual Processing? DefaultProcessingSerNavigation { get; set; }

    [InverseProperty("BaselinePortalDoseSerNavigation")]
    public virtual ICollection<ExternalField> ExternalField { get; set; } = new List<ExternalField>();

    [ForeignKey("GeometricParentSer")]
    [InverseProperty("InverseGeometricParentSerNavigation")]
    public virtual Image1? GeometricParentSerNavigation { get; set; }

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<GraphicAnnotation> GraphicAnnotation { get; set; } = new List<GraphicAnnotation>();

    [ForeignKey("Image4Dser")]
    [InverseProperty("Image1")]
    public virtual Image4D? Image4DserNavigation { get; set; }

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<ImageMatchResult> ImageMatchResult { get; set; } = new List<ImageMatchResult>();

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<ImageSlice> ImageSlice { get; set; } = new List<ImageSlice>();

    [InverseProperty("GeometricParentSerNavigation")]
    public virtual ICollection<Image1> InverseGeometricParentSerNavigation { get; set; } = new List<Image1>();

    [ForeignKey("OtherProcessingSer")]
    [InverseProperty("Image1OtherProcessingSerNavigation")]
    public virtual Processing? OtherProcessingSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("Image1")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<PlanSum> PlanSum { get; set; } = new List<PlanSum>();

    [InverseProperty("RefImageSerNavigation")]
    public virtual ICollection<Radiation> Radiation { get; set; } = new List<Radiation>();

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<RefPointLocation> RefPointLocation { get; set; } = new List<RefPointLocation>();

    [ForeignKey("SeriesSer")]
    [InverseProperty("Image1")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("DoubleExposureSerNavigation")]
    public virtual ICollection<SliceRt> SliceRt { get; set; } = new List<SliceRt>();

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<SpatialRegistrationImage> SpatialRegistrationImage { get; set; } = new List<SpatialRegistrationImage>();

    [InverseProperty("ImageSerNavigation")]
    public virtual StructureDetectionData? StructureDetectionData { get; set; }

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<StructureSet> StructureSet { get; set; } = new List<StructureSet>();

    [InverseProperty("ImageSerNavigation")]
    public virtual ICollection<TrackingImage> TrackingImage { get; set; } = new List<TrackingImage>();
}
