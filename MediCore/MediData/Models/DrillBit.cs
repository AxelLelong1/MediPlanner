using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", Name = "XIF1DrillBit")]
public partial class DrillBit
{
    [Key]
    public long DrillBitSer { get; set; }

    public long ResourceSer { get; set; }

    public double? Diameter { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    public int DefaultFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("DrillBit")]
    public virtual MillingMachine ResourceSerNavigation { get; set; } = null!;
}
