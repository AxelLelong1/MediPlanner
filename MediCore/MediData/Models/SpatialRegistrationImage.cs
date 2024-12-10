using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ImageSer", "SpatialRegistrationSer", Name = "XIE1SpatialRegistrationImage")]
[Index("ImageInstanceUid", Name = "XIE3SpatialRegistrationImage")]
[Index("SpatialRegistrationSer", Name = "XIF840SpatialRegistrationImage")]
public partial class SpatialRegistrationImage
{
    [Key]
    public long SpatialRegistrationImageSer { get; set; }

    public long SpatialRegistrationSer { get; set; }

    public long? ImageSer { get; set; }

    [Column("ImageClassUID")]
    [StringLength(64)]
    public string ImageClassUid { get; set; } = null!;

    [Column("ImageInstanceUID")]
    [StringLength(64)]
    public string ImageInstanceUid { get; set; } = null!;

    [Column("StudyUID")]
    [StringLength(64)]
    public string? StudyUid { get; set; }

    [Column("SeriesUID")]
    [StringLength(64)]
    public string? SeriesUid { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("SpatialRegistrationImage")]
    public virtual Image1? ImageSerNavigation { get; set; }

    [ForeignKey("SpatialRegistrationSer")]
    [InverseProperty("SpatialRegistrationImage")]
    public virtual SpatialRegistration SpatialRegistrationSerNavigation { get; set; } = null!;
}
