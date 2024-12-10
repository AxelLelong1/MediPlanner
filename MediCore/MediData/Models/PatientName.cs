using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PatientName
{
    [Key]
    public long PatientNameSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(16)]
    public string? NameType { get; set; }

    [StringLength(16)]
    public string? NameRepresentationCode { get; set; }

    public int? NameSelectedForDisplay { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    public byte[] HstryTimeStamp { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientName")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
