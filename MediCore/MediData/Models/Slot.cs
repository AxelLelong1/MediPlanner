using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Slot
{
    [Key]
    public long SlotSer { get; set; }

    public long ResourceSer { get; set; }

    public int SlotNumber { get; set; }

    [StringLength(64)]
    public string? SlotName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int? InternalCode { get; set; }

    public double? SourceSlotDist { get; set; }

    public double? MaxCompThickness { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("SlotSerNavigation")]
    public virtual ICollection<FieldAddOn> FieldAddOn { get; set; } = new List<FieldAddOn>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Slot")]
    public virtual RadiationDevice ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("SlotSerNavigation")]
    public virtual ICollection<SlotAddOn> SlotAddOn { get; set; } = new List<SlotAddOn>();
}
