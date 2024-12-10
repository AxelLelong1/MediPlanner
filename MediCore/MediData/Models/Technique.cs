using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", "TechniqueId", Name = "XAK1Technique", IsUnique = true)]
public partial class Technique
{
    [Key]
    public long TechniqueSer { get; set; }

    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string TechniqueId { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int? DefaultFlag { get; set; }

    [StringLength(32)]
    public string? DisplayCode { get; set; }

    public int? InternalCode { get; set; }

    public int? LevelCode { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("TechniqueSerNavigation")]
    public virtual ICollection<ConfiguredEmt> ConfiguredEmt { get; set; } = new List<ConfiguredEmt>();

    [InverseProperty("TechniqueSerNavigation")]
    public virtual ICollection<DemExternalBeam> DemExternalBeam { get; set; } = new List<DemExternalBeam>();

    [InverseProperty("TechniqueSerNavigation")]
    public virtual ICollection<ExternalFieldCommon> ExternalFieldCommon { get; set; } = new List<ExternalFieldCommon>();

    [InverseProperty("TechniqueSerNavigation")]
    public virtual ICollection<OperatingLimit> OperatingLimit { get; set; } = new List<OperatingLimit>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Technique")]
    public virtual ExternalBeam ResourceSerNavigation { get; set; } = null!;
}
