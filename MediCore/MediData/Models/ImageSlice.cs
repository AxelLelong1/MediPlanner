using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ImageSer", "SliceSer")]
[Index("SliceSer", Name = "XIF860ImageSlice")]
public partial class ImageSlice
{
    [Key]
    public long ImageSer { get; set; }

    [Key]
    public long SliceSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("ImageSlice")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [ForeignKey("SliceSer")]
    [InverseProperty("ImageSlice")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
