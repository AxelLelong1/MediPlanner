using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DVHEstimationTrainingSetStructure")]
[Index("PlanningModelLibraryStructureGuid", Name = "XAK1DVHEstimationTrainingSetStructure", IsUnique = true)]
[Index("DvhestimationTrainingSetSer", Name = "XIF1DVHEstimationTrainingSetStructure")]
public partial class DvhestimationTrainingSetStructure
{
    [Key]
    [Column("DVHEstimationTrainingSetStructureSer")]
    public long DvhestimationTrainingSetStructureSer { get; set; }

    [Column("DVHEstimationTrainingSetSer")]
    public long DvhestimationTrainingSetSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public Guid? PlanningModelLibraryStructureGuid { get; set; }

    [InverseProperty("DvhestimationTrainingSetStructureSerNavigation")]
    public virtual ICollection<DvhestimationTrainingSetPlanSetupStructureMapping> DvhestimationTrainingSetPlanSetupStructureMapping { get; set; } = new List<DvhestimationTrainingSetPlanSetupStructureMapping>();

    [ForeignKey("DvhestimationTrainingSetSer")]
    [InverseProperty("DvhestimationTrainingSetStructure")]
    public virtual DvhestimationTrainingSet DvhestimationTrainingSetSerNavigation { get; set; } = null!;
}
