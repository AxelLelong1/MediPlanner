using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ResourceSer", "PatientSer")]
[Index("PatientSer", Name = "XIF2PatientStaff")]
public partial class PatientStaff
{
    [Key]
    public long ResourceSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientStaff")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("PatientStaff")]
    public virtual Staff ResourceSerNavigation { get; set; } = null!;
}
