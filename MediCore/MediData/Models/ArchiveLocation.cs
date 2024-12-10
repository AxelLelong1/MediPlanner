using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ArchiveLocation
{
    [Key]
    public long ArchiveLocationSer { get; set; }

    [StringLength(254)]
    public string ArchiveLocationPath { get; set; } = null!;

    [StringLength(64)]
    public string ArchiveMediaType { get; set; } = null!;

    [StringLength(64)]
    public string ArchiveMediaStatus { get; set; } = null!;

    [StringLength(254)]
    public string ArchiveMediaLabel { get; set; } = null!;

    [StringLength(254)]
    public string? ArchiveMediaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ArchiveMediaStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArchiveMediaCloseDate { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ArchiveLocationSerNavigation")]
    public virtual ICollection<LtascheduledTask> LtascheduledTask { get; set; } = new List<LtascheduledTask>();

    [InverseProperty("ArchiveLocationSerNavigation")]
    public virtual ICollection<TrackingInformation> TrackingInformation { get; set; } = new List<TrackingInformation>();
}
