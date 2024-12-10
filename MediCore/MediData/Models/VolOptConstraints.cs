using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanSetupSer", Name = "XIF499VolOptConstraints")]
public partial class VolOptConstraints
{
    [Key]
    public long VolOptConstraintsSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string VolOptConstraintsId { get; set; } = null!;

    [StringLength(64)]
    public string? VolOptConstraintsName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public string? Parameters { get; set; }

    public int ParametersLen { get; set; }

    [StringLength(32)]
    public string ConstraintsType { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("VolOptConstraints")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [InverseProperty("VolOptConstraintsSerNavigation")]
    public virtual ICollection<VolOptMatrix> VolOptMatrix { get; set; } = new List<VolOptMatrix>();

    [InverseProperty("VolOptConstraintsSerNavigation")]
    public virtual ICollection<VolOptStruct> VolOptStruct { get; set; } = new List<VolOptStruct>();
}
