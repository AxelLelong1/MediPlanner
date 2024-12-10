using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VolOptConstraintsSer", Name = "XIF500VolOptStruct")]
[Index("StructureSer", Name = "XIF960VolOptStruct")]
public partial class VolOptStruct
{
    [Key]
    public long VolOptStructSer { get; set; }

    public long VolOptConstraintsSer { get; set; }

    public long StructureSer { get; set; }

    [StringLength(16)]
    public string VolOptStructId { get; set; } = null!;

    [StringLength(64)]
    public string? VolOptStructName { get; set; }

    public string? Parameters { get; set; }

    public int ParametersLen { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("StructureSer")]
    [InverseProperty("VolOptStruct")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;

    [ForeignKey("VolOptConstraintsSer")]
    [InverseProperty("VolOptStruct")]
    public virtual VolOptConstraints VolOptConstraintsSerNavigation { get; set; } = null!;

    [InverseProperty("VolOptStructSerNavigation")]
    public virtual ICollection<VolOptStructCstr> VolOptStructCstr { get; set; } = new List<VolOptStructCstr>();
}
