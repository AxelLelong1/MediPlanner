using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ImageSer", "RefPointSer")]
[Index("RefPointSer", Name = "XIF952RefPointLocation")]
public partial class RefPointLocation
{
    [Key]
    public long ImageSer { get; set; }

    [Key]
    public long RefPointSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(32)]
    public string? RefPointLocationType { get; set; }

    [MaxLength(24)]
    public byte[]? Location { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("RefPointLocation")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [ForeignKey("RefPointSer")]
    [InverseProperty("RefPointLocation")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;
}
