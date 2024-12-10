using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", Name = "IX_ActivityInstanceLink_HstryDatetime")]
[Index("ActivityInstanceSer", Name = "XIF1ActivityInstanceLink")]
[Index("PredecessorSer", Name = "XIF2ActivityInstanceLink")]
public partial class ActivityInstanceLink
{
    [Key]
    public long ActivityInstanceLinkSer { get; set; }

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

    [InverseProperty("ActivityInstanceLinkSerNavigation")]
    public virtual ICollection<ActivityInstanceLinkMh> ActivityInstanceLinkMh { get; set; } = new List<ActivityInstanceLinkMh>();

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ActivityInstanceLinkActivityInstanceSerNavigation")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("PredecessorSer")]
    [InverseProperty("ActivityInstanceLinkPredecessorSerNavigation")]
    public virtual ActivityInstance PredecessorSerNavigation { get; set; } = null!;
}
