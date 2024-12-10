using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", Name = "XIF352Photo")]
public partial class Photo
{
    [Key]
    public long PhotoSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(32)]
    public string PhotoType { get; set; } = null!;

    public byte[]? Picture { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public byte[]? Thumbnail { get; set; }

    [InverseProperty("PhotoSerNavigation")]
    public virtual ICollection<FieldPhoto> FieldPhoto { get; set; } = new List<FieldPhoto>();

    [ForeignKey("PatientSer")]
    [InverseProperty("Photo")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
