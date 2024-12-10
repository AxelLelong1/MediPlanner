using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DVHEstimationTrainingSet")]
[Index("PlanningModelLibraryModelGuid", Name = "XAK1DVHEstimationTrainingSet", IsUnique = true)]
public partial class DvhestimationTrainingSet
{
    [Key]
    [Column("DVHEstimationTrainingSetSer")]
    public long DvhestimationTrainingSetSer { get; set; }

    public Guid? PlanningModelLibraryModelGuid { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DvhestimationTrainingSetSerNavigation")]
    public virtual ICollection<DvhestimationTrainingSetPlanSetup> DvhestimationTrainingSetPlanSetup { get; set; } = new List<DvhestimationTrainingSetPlanSetup>();

    [InverseProperty("DvhestimationTrainingSetSerNavigation")]
    public virtual ICollection<DvhestimationTrainingSetStructure> DvhestimationTrainingSetStructure { get; set; } = new List<DvhestimationTrainingSetStructure>();
}
