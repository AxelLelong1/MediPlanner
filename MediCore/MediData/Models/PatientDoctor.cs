using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ResourceSer", "PatientSer")]
[Index("PatientSer", Name = "XIF349PatientOncologist")]
public partial class PatientDoctor
{
    [Key]
    public long ResourceSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int OncologistFlag { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int PrimaryCarePhysicianFlag { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientDoctor")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("PatientDoctor")]
    public virtual Doctor ResourceSerNavigation { get; set; } = null!;
}
