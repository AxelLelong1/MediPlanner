using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrackingSer", "RadiationSer")]
[Index("RadiationSer", Name = "XIF957TrackingField")]
public partial class TrackingField
{
    [Key]
    public long TrackingSer { get; set; }

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

    [ForeignKey("RadiationSer")]
    [InverseProperty("TrackingField")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("TrackingSer")]
    [InverseProperty("TrackingField")]
    public virtual Tracking TrackingSerNavigation { get; set; } = null!;
}
