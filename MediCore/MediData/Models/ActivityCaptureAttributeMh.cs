using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityCaptureAttributeSer", "ActivityCaptureAttrRevCount")]
[Table("ActivityCaptureAttributeMH")]
public partial class ActivityCaptureAttributeMh
{
    [Key]
    public long ActivityCaptureAttributeSer { get; set; }

    [Key]
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

    [ForeignKey("ActivityCaptureAttributeSer")]
    [InverseProperty("ActivityCaptureAttributeMh")]
    public virtual ActivityCaptureAttribute ActivityCaptureAttributeSerNavigation { get; set; } = null!;
}
