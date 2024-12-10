using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", Name = "XIF1ObsoleteObject")]
public partial class ObsoleteObject
{
    [Key]
    public long ObsoleteObjectSer { get; set; }

    [StringLength(32)]
    public string DirLabel { get; set; } = null!;

    [StringLength(254)]
    public string ObjectPath { get; set; } = null!;

    [StringLength(64)]
    public string? ErrorReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastAccessDate { get; set; }

    public long? PatientSer { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("ObsoleteObject")]
    public virtual Patient? PatientSerNavigation { get; set; }
}
