using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("StructureSetUid", Name = "XAK1StructureSet", IsUnique = true)]
[Index("SeriesSer", "StructureSetSer", Name = "XIE1StructureSet")]
[Index("ImageSer", Name = "XIF871StructureSet")]
[Index("EquipmentSer", Name = "XIF891StructureSet")]
public partial class StructureSet
{
    [Key]
    public long StructureSetSer { get; set; }

    public long SeriesSer { get; set; }

    public long ImageSer { get; set; }

    [Column("StructureSetUID")]
    [StringLength(64)]
    public string StructureSetUid { get; set; } = null!;

    [StringLength(16)]
    public string StructureSetId { get; set; } = null!;

    [StringLength(64)]
    public string? StructureSetName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public int? InstanceNumber { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("ROIMaterialVersion")]
    [StringLength(64)]
    public string? RoimaterialVersion { get; set; }

    [ForeignKey("EquipmentSer")]
    [InverseProperty("StructureSet")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("StructureSet")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [InverseProperty("StructureSetSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [InverseProperty("StructureSetSerNavigation")]
    public virtual ICollection<RtappExtensionLog> RtappExtensionLog { get; set; } = new List<RtappExtensionLog>();

    [ForeignKey("SeriesSer")]
    [InverseProperty("StructureSet")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("StructureSetSerNavigation")]
    public virtual ICollection<Structure> Structure { get; set; } = new List<Structure>();
}
