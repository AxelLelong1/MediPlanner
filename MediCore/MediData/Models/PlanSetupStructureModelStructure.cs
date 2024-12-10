using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PlanSetupSer", "StructureSer")]
[Index("PlanSetupSer", Name = "XIF1PlanSetupStructureModelStructure")]
[Index("StructureSer", Name = "XIF2PlanSetupStructureModelStructure")]
public partial class PlanSetupStructureModelStructure
{
    [Key]
    public long PlanSetupSer { get; set; }

    [Key]
    public long StructureSer { get; set; }

    public Guid PlanningModelLibraryStructureGuid { get; set; }

    [StringLength(16)]
    public string StructureType { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("PlanSetupStructureModelStructure")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSer")]
    [InverseProperty("PlanSetupStructureModelStructure")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;
}
