using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TemplateSer", Name = "XIF524TemplateCycle")]
[Index("CycleSer", Name = "XIF561TemplateCycle")]
public partial class TemplateCycle
{
    [Key]
    public long TemplateCycleSer { get; set; }

    public int TemplateCycleRevCount { get; set; }

    public long TemplateSer { get; set; }

    public int TemplateRevCount { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long CycleSer { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("TemplateCycleSerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstance { get; set; } = new List<ActivityInstance>();

    [ForeignKey("CycleSer")]
    [InverseProperty("TemplateCycle")]
    public virtual TreatmentCycle CycleSerNavigation { get; set; } = null!;

    [InverseProperty("TemplateCycleSerNavigation")]
    public virtual ICollection<TemplateCycleMh> TemplateCycleMh { get; set; } = new List<TemplateCycleMh>();

    [ForeignKey("TemplateSer")]
    [InverseProperty("TemplateCycle")]
    public virtual Template TemplateSerNavigation { get; set; } = null!;
}
