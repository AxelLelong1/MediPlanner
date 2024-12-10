using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionAnatomySer", Name = "XIF1PrescriptionAnatomyItem")]
public partial class PrescriptionAnatomyItem
{
    [Key]
    public long PrescriptionAnatomyItemSer { get; set; }

    public long PrescriptionAnatomySer { get; set; }

    [StringLength(64)]
    public string ItemType { get; set; } = null!;

    [StringLength(64)]
    public string ItemValue { get; set; } = null!;

    [StringLength(16)]
    public string? ItemValueUnit { get; set; }

    [StringLength(64)]
    public string? Param1Value { get; set; }

    [StringLength(16)]
    public string? Param1ValueUnit { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PrescriptionAnatomySer")]
    [InverseProperty("PrescriptionAnatomyItem")]
    public virtual PrescriptionAnatomy PrescriptionAnatomySerNavigation { get; set; } = null!;
}
