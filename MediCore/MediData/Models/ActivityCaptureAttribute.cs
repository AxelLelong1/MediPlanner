using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityAttributeSer", Name = "XIF635ActivityCaptureAttribute")]
[Index("ActivityCaptureSer", Name = "XIF636ActivityCaptureAttribute")]
[Index("ActivityCaptureSer", "ActivityCaptureRevCount", Name = "XIF901ActivityCaptureAttribute")]
public partial class ActivityCaptureAttribute
{
    [Key]
    public long ActivityCaptureAttributeSer { get; set; }

    public int ActivityCaptureAttrRevCount { get; set; }

    public long ActivityCaptureSer { get; set; }

    public int ActivityCaptureRevCount { get; set; }

    public long ActivityAttributeSer { get; set; }

    public int ActivityAttributeRevCount { get; set; }

    [StringLength(254)]
    public string? AttributeValue { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityAttributeSer")]
    [InverseProperty("ActivityCaptureAttribute")]
    public virtual ActivityAttribute ActivityAttributeSerNavigation { get; set; } = null!;

    [InverseProperty("ActivityCaptureAttributeSerNavigation")]
    public virtual ICollection<ActivityCaptureAttributeMh> ActivityCaptureAttributeMh { get; set; } = new List<ActivityCaptureAttributeMh>();

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("ActivityCaptureAttribute")]
    public virtual ActivityCapture ActivityCaptureSerNavigation { get; set; } = null!;
}
