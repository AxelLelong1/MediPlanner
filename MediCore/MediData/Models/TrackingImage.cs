using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrackingSer", "ImageSer")]
[Index("ImageSer", Name = "XIF890TrackingImage")]
public partial class TrackingImage
{
    [Key]
    public long TrackingSer { get; set; }

    [Key]
    public long ImageSer { get; set; }

    public long? CacheKeySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ImageAcquisitionTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("TrackingImage")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [ForeignKey("TrackingSer")]
    [InverseProperty("TrackingImage")]
    public virtual Tracking TrackingSerNavigation { get; set; } = null!;
}
