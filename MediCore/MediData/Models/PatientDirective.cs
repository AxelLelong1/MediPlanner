using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DirectiveSer", Name = "XIF1003PatientDirective")]
[Index("PatientSer", Name = "XIF1004PatientDirective")]
public partial class PatientDirective
{
    [Key]
    public long PatientDirectiveSer { get; set; }

    public long PatientSer { get; set; }

    public long DirectiveSer { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int ActiveFlag { get; set; }

    public int ValidEntryFlag { get; set; }

    [StringLength(254)]
    public string? ErrorReason { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DirectiveSer")]
    [InverseProperty("PatientDirective")]
    public virtual Directive DirectiveSerNavigation { get; set; } = null!;

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientDirective")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
