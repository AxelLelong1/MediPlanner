using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionTemplateSer", Name = "XIF1PrescriptionTemplateProperty")]
public partial class PrescriptionTemplateProperty
{
    [Key]
    public long PrescriptionTemplatePropertySer { get; set; }

    [StringLength(64)]
    public string? PrescriptionPropertyTemplateName { get; set; }

    public long? PrescriptionTemplateSer { get; set; }

    public short PropertyType { get; set; }

    [StringLength(64)]
    public string PropertyValue { get; set; } = null!;

    [Column("UserCUID")]
    [StringLength(64)]
    public string? UserCuid { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PrescriptionTemplatePropertySerNavigation")]
    public virtual ICollection<PrescriptionTemplatePropertyItem> PrescriptionTemplatePropertyItem { get; set; } = new List<PrescriptionTemplatePropertyItem>();

    [ForeignKey("PrescriptionTemplateSer")]
    [InverseProperty("PrescriptionTemplateProperty")]
    public virtual PrescriptionTemplate? PrescriptionTemplateSerNavigation { get; set; }
}
