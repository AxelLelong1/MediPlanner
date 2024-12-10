using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionTemplatePropertySer", Name = "XIF1PrescriptionTemplatePropertyItem")]
public partial class PrescriptionTemplatePropertyItem
{
    [Key]
    public long PrescriptionTemplatePropertyItemSer { get; set; }

    public long PrescriptionTemplatePropertySer { get; set; }

    public short ItemType { get; set; }

    [StringLength(64)]
    public string? ItemValue { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PrescriptionTemplatePropertySer")]
    [InverseProperty("PrescriptionTemplatePropertyItem")]
    public virtual PrescriptionTemplateProperty PrescriptionTemplatePropertySerNavigation { get; set; } = null!;
}
