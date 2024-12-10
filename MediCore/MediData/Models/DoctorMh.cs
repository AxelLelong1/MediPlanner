using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ResourceSer", "ResourceRevCount")]
[Table("DoctorMH")]
[Index("ResourceSer", Name = "XIF1DoctorMH")]
public partial class DoctorMh
{
    [Key]
    public long ResourceSer { get; set; }

    [Key]
    public int ResourceRevCount { get; set; }

    [StringLength(16)]
    public string DoctorId { get; set; } = null!;

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(64)]
    public string FirstName { get; set; } = null!;

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(64)]
    public string AliasName { get; set; } = null!;

    [StringLength(64)]
    public string? Specialty { get; set; }

    [StringLength(64)]
    public string? Institution { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int OncologistFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    public int ExternalMedOncFlag { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("DoctorMh")]
    public virtual Doctor ResourceSerNavigation { get; set; } = null!;
}
