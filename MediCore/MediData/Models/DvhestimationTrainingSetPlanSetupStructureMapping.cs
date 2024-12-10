using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DvhestimationTrainingSetSer", "PlanSetupSer", "StructureSer")]
[Table("DVHEstimationTrainingSetPlanSetupStructureMapping")]
[Index("DvhestimationTrainingSetPlanSetupStructureMappingGuid", Name = "XAK1DVHEstimationTrainingSetPlanSetupStructureMapping", IsUnique = true)]
[Index("DvhestimationTrainingSetStructureSer", Name = "XIF2DVHEstimationTrainingSetPlanSetupStructureMapping")]
[Index("StructureSer", Name = "XIF3DVHEstimationTrainingSetPlanSetupStructureMapping")]
[Index("DvhestimationTrainingSetSer", "PlanSetupSer", Name = "XIF6DVHEstimationTrainingSetPlanSetupStructureMapping")]
public partial class DvhestimationTrainingSetPlanSetupStructureMapping
{
    [Key]
    [Column("DVHEstimationTrainingSetSer")]
    public long DvhestimationTrainingSetSer { get; set; }

    [Key]
    public long PlanSetupSer { get; set; }

    [Key]
    public long StructureSer { get; set; }

    [Column("DVHEstimationTrainingSetStructureSer")]
    public long DvhestimationTrainingSetStructureSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DVHEstimationTrainingSetPlanSetupStructureMappingGuid")]
    public Guid? DvhestimationTrainingSetPlanSetupStructureMappingGuid { get; set; }

    [ForeignKey("DvhestimationTrainingSetSer, PlanSetupSer")]
    [InverseProperty("DvhestimationTrainingSetPlanSetupStructureMapping")]
    public virtual DvhestimationTrainingSetPlanSetup DvhestimationTrainingSetPlanSetup { get; set; } = null!;

    [ForeignKey("DvhestimationTrainingSetStructureSer")]
    [InverseProperty("DvhestimationTrainingSetPlanSetupStructureMapping")]
    public virtual DvhestimationTrainingSetStructure DvhestimationTrainingSetStructureSerNavigation { get; set; } = null!;

    [ForeignKey("StructureSer")]
    [InverseProperty("DvhestimationTrainingSetPlanSetupStructureMapping")]
    public virtual Structure StructureSerNavigation { get; set; } = null!;
}
