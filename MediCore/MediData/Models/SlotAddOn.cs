using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AddOnSer", "SlotSer")]
[Index("SlotSer", Name = "XIF379SlotAddOn")]
public partial class SlotAddOn
{
    [Key]
    public long AddOnSer { get; set; }

    [Key]
    public long SlotSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int DefaultFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("SlotAddOn")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [ForeignKey("SlotSer")]
    [InverseProperty("SlotAddOn")]
    public virtual Slot SlotSerNavigation { get; set; } = null!;
}
