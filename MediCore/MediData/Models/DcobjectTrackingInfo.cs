using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DCObjectTrackingInfo")]
[Index("TrackingInformationSer", Name = "XIF823DCObjectTrackingInfo")]
[Index("ObjectPointerSer", Name = "XIF824DCObjectTrackingInfo")]
public partial class DcobjectTrackingInfo
{
    [Key]
    [Column("DCObjectTrackingInfoSer")]
    public long DcobjectTrackingInfoSer { get; set; }

    public long ObjectPointerSer { get; set; }

    public long TrackingInformationSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ObjectPointerSer")]
    [InverseProperty("DcobjectTrackingInfo")]
    public virtual ObjectPointer ObjectPointerSerNavigation { get; set; } = null!;

    [ForeignKey("TrackingInformationSer")]
    [InverseProperty("DcobjectTrackingInfo")]
    public virtual TrackingInformation TrackingInformationSerNavigation { get; set; } = null!;
}
