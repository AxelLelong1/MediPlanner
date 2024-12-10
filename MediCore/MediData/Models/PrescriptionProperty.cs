using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionSer", Name = "XIF1PrescriptionProperty")]
public partial class PrescriptionProperty
{
    [Key]
    public long PrescriptionPropertySer { get; set; }

    public long PrescriptionSer { get; set; }

    public short PropertyType { get; set; }

    [StringLength(64)]
    public string PropertyValue { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PrescriptionPropertySerNavigation")]
    public virtual ICollection<PrescriptionPropertyItem> PrescriptionPropertyItem { get; set; } = new List<PrescriptionPropertyItem>();

    [ForeignKey("PrescriptionSer")]
    [InverseProperty("PrescriptionProperty")]
    public virtual Prescription PrescriptionSerNavigation { get; set; } = null!;
}
