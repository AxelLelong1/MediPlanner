using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityInstanceLinkSer", "ActivityInstanceLinkRevCount")]
[Table("ActivityInstanceLinkMH")]
public partial class ActivityInstanceLinkMh
{
    [Key]
    public long ActivityInstanceLinkSer { get; set; }

    [Key]
    public int ActivityInstanceLinkRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public long PredecessorSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityInstanceLinkSer")]
    [InverseProperty("ActivityInstanceLinkMh")]
    public virtual ActivityInstanceLink ActivityInstanceLinkSerNavigation { get; set; } = null!;
}
