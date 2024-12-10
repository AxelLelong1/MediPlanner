using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivitySer", "ActivityRevCount", "UserDefActAttrSer", "UserDefActAttrRevCount", Name = "XIE1ActivityAttribute")]
[Index("UserDefActAttrSer", Name = "XIF659ActivityAttribute")]
public partial class ActivityAttribute
{
    [Key]
    public long ActivityAttributeSer { get; set; }

    public int ActivityAttributeRevCount { get; set; }

    public long ActivitySer { get; set; }

    public int ActivityRevCount { get; set; }

    public long UserDefActAttrSer { get; set; }

    public int UserDefActAttrRevCount { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ActivityAttributeSerNavigation")]
    public virtual ICollection<ActivityAttributeMh> ActivityAttributeMh { get; set; } = new List<ActivityAttributeMh>();

    [InverseProperty("ActivityAttributeSerNavigation")]
    public virtual ICollection<ActivityCaptureAttribute> ActivityCaptureAttribute { get; set; } = new List<ActivityCaptureAttribute>();

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityAttribute")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;

    [ForeignKey("UserDefActAttrSer")]
    [InverseProperty("ActivityAttribute")]
    public virtual UserDefActAttr UserDefActAttrSerNavigation { get; set; } = null!;
}
