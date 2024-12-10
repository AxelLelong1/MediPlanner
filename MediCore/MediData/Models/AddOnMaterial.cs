using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class AddOnMaterial
{
    [Key]
    public long AddOnMaterialSer { get; set; }

    [StringLength(16)]
    public string AddOnMaterialId { get; set; } = null!;

    [StringLength(64)]
    public string? AddOnMaterialName { get; set; }

    [StringLength(32)]
    public string? UsageType { get; set; }

    public double? Thickness { get; set; }

    public double? BaseplateThickness { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("AddOnMaterialSerNavigation")]
    public virtual ICollection<AddOn> AddOn { get; set; } = new List<AddOn>();

    [InverseProperty("AddOnMaterialSerNavigation")]
    public virtual ICollection<Block> Block { get; set; } = new List<Block>();

    [InverseProperty("AddOnMaterialSerNavigation")]
    public virtual ICollection<Compensator> Compensator { get; set; } = new List<Compensator>();

    [InverseProperty("AddOnMaterialSerNavigation")]
    public virtual ICollection<DosimetricData> DosimetricData { get; set; } = new List<DosimetricData>();
}
