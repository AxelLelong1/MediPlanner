using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DepartmentSer", Name = "XIF470ActivityPttrn")]
[Index("ActivitySer", Name = "XIF614ActivityPttrn")]
public partial class ActivityPttrn
{
    [Key]
    public long ActivityPttrnSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? ActivitySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternEndDateTime { get; set; }

    public int? WeeksPerCycle { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ActivityPttrnSerNavigation")]
    public virtual ICollection<ActivityPttrnPerCycle> ActivityPttrnPerCycle { get; set; } = new List<ActivityPttrnPerCycle>();

    [InverseProperty("ActivityPttrnSerNavigation")]
    public virtual ICollection<ActivityPttrnResrc> ActivityPttrnResrc { get; set; } = new List<ActivityPttrnResrc>();

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityPttrn")]
    public virtual Activity? ActivitySerNavigation { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ActivityPttrn")]
    public virtual Department? DepartmentSerNavigation { get; set; }
}
