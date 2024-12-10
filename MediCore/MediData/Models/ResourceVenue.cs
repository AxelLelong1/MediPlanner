using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ResourceSer", "VenueResourceSer")]
[Index("VenueResourceSer", Name = "XIF494AuxiliaryVenue")]
public partial class ResourceVenue
{
    [Key]
    public long ResourceSer { get; set; }

    [Key]
    public long VenueResourceSer { get; set; }

    public long? CacheKeySer { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("ResourceVenue")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;

    [ForeignKey("VenueResourceSer")]
    [InverseProperty("ResourceVenue")]
    public virtual Venue VenueResourceSerNavigation { get; set; } = null!;
}
