using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionPropertySer", Name = "XIF1PrescriptionPropertyItem")]
public partial class PrescriptionPropertyItem
{
    [Key]
    public long PrescriptionPropertyItemSer { get; set; }

    public long PrescriptionPropertySer { get; set; }

    public short ItemType { get; set; }

    [StringLength(64)]
    public string ItemValue { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PrescriptionPropertySer")]
    [InverseProperty("PrescriptionPropertyItem")]
    public virtual PrescriptionProperty PrescriptionPropertySerNavigation { get; set; } = null!;
}
