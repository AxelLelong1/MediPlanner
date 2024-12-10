using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlnTpAbbrvtn", Name = "XAK1PlanTypes", IsUnique = true)]
[Index("PlanSourceSer", Name = "XIF1PlanTypes")]
public partial class PlanTypes
{
    [Key]
    public long PlanTypeSer { get; set; }

    [StringLength(32)]
    public string PlnTpAbbrvtn { get; set; } = null!;

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? PlanSourceSer { get; set; }

    [InverseProperty("PlanTypeSerNavigation")]
    public virtual ICollection<Payor> Payor { get; set; } = new List<Payor>();

    [ForeignKey("PlanSourceSer")]
    [InverseProperty("PlanTypes")]
    public virtual PlanSource? PlanSourceSerNavigation { get; set; }
}
