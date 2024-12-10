using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SliceUid", Name = "XAK1Slice", IsUnique = true)]
[Index("SliceFormat", "IsLockedFlag", "SliceSer", Name = "XAK2Slice", IsUnique = true)]
[Index("SliceSer", "SliceType", "SliceModality", "SliceFormat", "SliceCharacteristics", Name = "XIE2Slice")]
[Index("SeriesSer", Name = "XIF861Slice")]
[Index("DctransferSyntaxSer", Name = "XIF863Slice")]
[Index("EquipmentSer", Name = "XIF892Slice")]
[Index("ContributingEquipmentSer", Name = "XIF893Slice")]
[Index("SopclassSer", Name = "XIF894Slice")]
[Index("ResourceSer", Name = "XIF895Slice")]
public partial class Slice
{
    [Key]
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

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<ContrastBolus> ContrastBolus { get; set; } = new List<ContrastBolus>();

    [ForeignKey("ContributingEquipmentSer")]
    [InverseProperty("SliceContributingEquipmentSerNavigation")]
    public virtual Equipment? ContributingEquipmentSerNavigation { get; set; }

    [ForeignKey("DctransferSyntaxSer")]
    [InverseProperty("Slice")]
    public virtual DctransferSyntax? DctransferSyntaxSerNavigation { get; set; }

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<DerivedImageCode> DerivedImageCode { get; set; } = new List<DerivedImageCode>();

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<DerivedInstanceUid> DerivedInstanceUid { get; set; } = new List<DerivedInstanceUid>();

    [ForeignKey("EquipmentSer")]
    [InverseProperty("SliceEquipmentSerNavigation")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<ImageRelatedInstance> ImageRelatedInstance { get; set; } = new List<ImageRelatedInstance>();

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<ImageSlice> ImageSlice { get; set; } = new List<ImageSlice>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Slice")]
    public virtual Machine? ResourceSerNavigation { get; set; }

    [ForeignKey("SeriesSer")]
    [InverseProperty("Slice")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("SliceSerNavigation")]
    public virtual SliceCt? SliceCt { get; set; }

    [InverseProperty("SliceSerNavigation")]
    public virtual SliceMr? SliceMr { get; set; }

    [InverseProperty("SliceSerNavigation")]
    public virtual ICollection<SlicePortalDoseAnalysis> SlicePortalDoseAnalysis { get; set; } = new List<SlicePortalDoseAnalysis>();

    [InverseProperty("SliceSerNavigation")]
    public virtual SliceRt? SliceRt { get; set; }

    [ForeignKey("SopclassSer")]
    [InverseProperty("Slice")]
    public virtual Sopclass SopclassSerNavigation { get; set; } = null!;
}
