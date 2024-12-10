using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PrescriptionSer", Name = "XIF1PrescriptionAnatomy")]
public partial class PrescriptionAnatomy
{
    [Key]
    public long PrescriptionAnatomySer { get; set; }

    public long PrescriptionSer { get; set; }

    public short AnatomyRole { get; set; }

    [StringLength(256)]
    public string AnatomyName { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PrescriptionAnatomySerNavigation")]
    public virtual ICollection<PrescriptionAnatomyItem> PrescriptionAnatomyItem { get; set; } = new List<PrescriptionAnatomyItem>();

    [ForeignKey("PrescriptionSer")]
    [InverseProperty("PrescriptionAnatomy")]
    public virtual Prescription PrescriptionSerNavigation { get; set; } = null!;
}
