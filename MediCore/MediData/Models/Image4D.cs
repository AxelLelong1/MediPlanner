using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", "Image4Dser", Name = "XIE1Image4D")]
public partial class Image4D
{
    [Key]
    [Column("Image4DSer")]
    public long Image4Dser { get; set; }

    [Column("Image4DId")]
    [StringLength(16)]
    public string Image4Did { get; set; } = null!;

    [Column("Image4DName")]
    [StringLength(64)]
    public string Image4Dname { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("Image4DserNavigation")]
    public virtual ICollection<Image1> Image1 { get; set; } = new List<Image1>();

    [ForeignKey("PatientSer")]
    [InverseProperty("Image4D")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
