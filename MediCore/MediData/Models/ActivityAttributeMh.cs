using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityAttributeSer", "ActivityAttributeRevCount")]
[Table("ActivityAttributeMH")]
public partial class ActivityAttributeMh
{
    [Key]
    public long ActivityAttributeSer { get; set; }

    [Key]
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

    [ForeignKey("ActivityAttributeSer")]
    [InverseProperty("ActivityAttributeMh")]
    public virtual ActivityAttribute ActivityAttributeSerNavigation { get; set; } = null!;
}
