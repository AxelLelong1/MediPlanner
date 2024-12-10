using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class TreatmentCycle
{
    [Key]
    public long CycleSer { get; set; }

    [Column("TreatmentCycle")]
    [StringLength(32)]
    public string TreatmentCycle1 { get; set; } = null!;

    public int NoEditFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int SortOrder { get; set; }

    [InverseProperty("TreatmentCycleSerNavigation")]
    public virtual ICollection<Activity> Activity { get; set; } = new List<Activity>();

    [InverseProperty("CycleSerNavigation")]
    public virtual ICollection<TemplateCycle> TemplateCycle { get; set; } = new List<TemplateCycle>();
}
