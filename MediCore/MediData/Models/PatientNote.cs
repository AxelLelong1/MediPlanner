using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DisplayDateTime", Name = "XIE1PatientNote")]
[Index("PatientSer", Name = "XIF340PatientNote")]
public partial class PatientNote
{
    [Key]
    public long PatientNoteSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(512)]
    public string? Note { get; set; }

    [StringLength(64)]
    public string? PatientNoteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DisplayDateTime { get; set; }

    [StringLength(255)]
    public string WrittenByAppUserName { get; set; } = null!;

    [StringLength(255)]
    public string? ReadByAppUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadDateTime { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientNote")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
