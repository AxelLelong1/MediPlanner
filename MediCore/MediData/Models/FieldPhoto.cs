using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PhotoSer", "RadiationSer")]
[Index("RadiationSer", Name = "XIF284FieldPhoto")]
public partial class FieldPhoto
{
    [Key]
    public long PhotoSer { get; set; }

    [Key]
    public long RadiationSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int DisplaySequence { get; set; }

    [ForeignKey("PhotoSer")]
    [InverseProperty("FieldPhoto")]
    public virtual Photo PhotoSerNavigation { get; set; } = null!;

    [ForeignKey("RadiationSer")]
    [InverseProperty("FieldPhoto")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;
}
