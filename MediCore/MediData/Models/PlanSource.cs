using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PlanSource
{
    [Key]
    public long PlanSourceSer { get; set; }

    [StringLength(254)]
    public string Description { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PlanSourceSerNavigation")]
    public virtual ICollection<PlanTypes> PlanTypes { get; set; } = new List<PlanTypes>();
}
