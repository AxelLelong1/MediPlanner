using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("FrameOfReferenceUid", Name = "XIE2SpatialRegistration")]
[Index("SpatialRegistrationIodser", Name = "XIF841SpatialRegistration")]
public partial class SpatialRegistration
{
    [Key]
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

    [InverseProperty("SpatialRegistrationSerNavigation")]
    public virtual ICollection<SpatialRegistrationImage> SpatialRegistrationImage { get; set; } = new List<SpatialRegistrationImage>();

    [ForeignKey("SpatialRegistrationIodser")]
    [InverseProperty("SpatialRegistration")]
    public virtual SpatialRegistrationIod SpatialRegistrationIodserNavigation { get; set; } = null!;
}
