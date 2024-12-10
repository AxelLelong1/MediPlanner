using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("MaterialId", Name = "XAK1Material", IsUnique = true)]
public partial class Material
{
    [Key]
    public long MaterialSer { get; set; }

    [StringLength(16)]
    public string MaterialId { get; set; } = null!;

    [StringLength(64)]
    public string? MaterialName { get; set; }

    public int UseSpecularFlag { get; set; }

    [MaxLength(4)]
    public byte[]? Color2D { get; set; }

    [Column("Rendering3DModel")]
    [StringLength(32)]
    public string? Rendering3Dmodel { get; set; }

    [Column("Rendering2DModel")]
    [StringLength(32)]
    public string? Rendering2Dmodel { get; set; }

    public int ShadowFlag { get; set; }

    public double? Translucency3D { get; set; }

    public double? Translucency2D { get; set; }

    public double? LineThickness { get; set; }

    [MaxLength(32)]
    public byte[]? LinePattern { get; set; }

    [MaxLength(4)]
    public byte[]? SpecularColor { get; set; }

    [MaxLength(4)]
    public byte[]? DiffuseColor { get; set; }

    [MaxLength(4)]
    public byte[]? AmbientColor { get; set; }

    public double? SpecularPower { get; set; }

    public double? SpecularAngular { get; set; }

    public double? TransparencyFolding { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<GraphicAnnotation> GraphicAnnotation { get; set; } = new List<GraphicAnnotation>();

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<GraphicAnnotationType> GraphicAnnotationType { get; set; } = new List<GraphicAnnotationType>();

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<Structure> Structure { get; set; } = new List<Structure>();

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<StructureType> StructureType { get; set; } = new List<StructureType>();

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<VolumeCode> VolumeCode { get; set; } = new List<VolumeCode>();

    [InverseProperty("MaterialSerNavigation")]
    public virtual ICollection<VolumeType> VolumeType { get; set; } = new List<VolumeType>();
}
