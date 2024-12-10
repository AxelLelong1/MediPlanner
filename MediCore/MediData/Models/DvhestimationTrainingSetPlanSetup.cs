using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DvhestimationTrainingSetSer", "PlanSetupSer")]
[Table("DVHEstimationTrainingSetPlanSetup")]
[Index("DvhestimationTrainingSetPlanSetupGuid", Name = "XAK1DVHEstimationTrainingSetPlanSetup", IsUnique = true)]
[Index("DvhestimationTrainingSetSer", Name = "XIF1DVHEstimationTrainingSetPlanSetup")]
[Index("PlanSetupSer", Name = "XIF2DVHEstimationTrainingSetPlanSetup")]
public partial class DvhestimationTrainingSetPlanSetup
{
    [Key]
    [Column("DVHEstimationTrainingSetSer")]
    public long DvhestimationTrainingSetSer { get; set; }

    [Key]
    public long PlanSetupSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DVHEstimationTrainingSetPlanSetupGuid")]
    public Guid? DvhestimationTrainingSetPlanSetupGuid { get; set; }

    [InverseProperty("DvhestimationTrainingSetPlanSetup")]
    public virtual ICollection<DvhestimationTrainingSetPlanSetupStructureMapping> DvhestimationTrainingSetPlanSetupStructureMapping { get; set; } = new List<DvhestimationTrainingSetPlanSetupStructureMapping>();

    [ForeignKey("DvhestimationTrainingSetSer")]
    [InverseProperty("DvhestimationTrainingSetPlanSetup")]
    public virtual DvhestimationTrainingSet DvhestimationTrainingSetSerNavigation { get; set; } = null!;

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("DvhestimationTrainingSetPlanSetup")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;
}
