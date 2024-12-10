using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AddOnSer", "RadiationSer")]
[Index("RadiationSer", Name = "XIF226FieldAddOn")]
[Index("SlotSer", Name = "XIF227FieldAddOn")]
public partial class FieldAddOn
{
    [Key]
    public long AddOnSer { get; set; }

    [Key]
    public long RadiationSer { get; set; }

    public long? CacheKeySer { get; set; }

    public long? SlotSer { get; set; }

    [StringLength(64)]
    public string? CustomCode { get; set; }

    public int? DicomSeqNumber { get; set; }

    public short UserPreselection { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("FieldAddOn")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [ForeignKey("RadiationSer")]
    [InverseProperty("FieldAddOn")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("SlotSer")]
    [InverseProperty("FieldAddOn")]
    public virtual Slot? SlotSerNavigation { get; set; }
}
