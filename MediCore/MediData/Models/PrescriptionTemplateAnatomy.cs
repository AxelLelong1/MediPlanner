using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionTemplateSer", Name = "XIF1PrescriptionTemplateAnatomy")]
public partial class PrescriptionTemplateAnatomy
{
    [Key]
    public long PrescriptionTemplateAnatomySer { get; set; }

    [StringLength(64)]
    public string? PrescriptionAnatomyTemplateName { get; set; }

    public long? PrescriptionTemplateSer { get; set; }

    public short? AnatomyRole { get; set; }

    [StringLength(256)]
    public string? AnatomyName { get; set; }

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

    [InverseProperty("PrescriptionTemplateAnatomySerNavigation")]
    public virtual ICollection<PrescriptionTemplateAnatomyItem> PrescriptionTemplateAnatomyItem { get; set; } = new List<PrescriptionTemplateAnatomyItem>();

    [ForeignKey("PrescriptionTemplateSer")]
    [InverseProperty("PrescriptionTemplateAnatomy")]
    public virtual PrescriptionTemplate? PrescriptionTemplateSerNavigation { get; set; }
}
