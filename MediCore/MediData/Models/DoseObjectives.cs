using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

/// <summary>
/// This table links a set of dose objectives between a structure and a plan or plan sum. The link to structure 
/// is optional to allow defining plan or plan sum specific objectives that are not related to any structure.
/// </summary>
[Index("PlanSetupSer", Name = "XIFDoseObjectivesPlanSetupSer")]
[Index("PlanSumSer", Name = "XIFDoseObjectivesPlanSumSer")]
[Index("StructureSer", Name = "XIFDoseObjectivesStructureSer")]
public partial class DoseObjectives
{
    /// <summary>
    /// Primary key of the table.
    /// </summary>
    [Key]
    public long DoseObjectivesSer { get; set; }

    /// <summary>
    /// Parent plan of this Dose objective set. The context in which the dose objectives are to be interpreted.
    /// </summary>
    public long? PlanSetupSer { get; set; }

    /// <summary>
    /// Parent plan sum of this Dose objective set. The context in which the dose objectives are to be interpreted.
    /// </summary>
    public long? PlanSumSer { get; set; }

    /// <summary>
    /// Parent structure of this Dose objective set. The structure to which the dose objectives belong to.
    /// </summary>
    public long? StructureSer { get; set; }

    /// <summary>
    /// Objectives field which replaces the storage of plan objectives inside a clinical protocol instance. 
    /// Objectives are stored as XML. The schema for the objectives is defined in DoseObjectives.xsd schema.
    /// </summary>
    public string? Objectives { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("DoseObjectives")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [ForeignKey("PlanSumSer")]
    [InverseProperty("DoseObjectives")]
    public virtual PlanSum? PlanSumSerNavigation { get; set; }

    [ForeignKey("StructureSer")]
    [InverseProperty("DoseObjectives")]
    public virtual Structure? StructureSerNavigation { get; set; }
}
