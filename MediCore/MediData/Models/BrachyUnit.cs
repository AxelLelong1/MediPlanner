using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class BrachyUnit
{
    [Key]
    public long ResourceSer { get; set; }

    public double? MaxDwellTimePerChannel { get; set; }

    public double? MaxDwellTimePerPos { get; set; }

    public double? MaxDwellTimePerTreatment { get; set; }

    public double? TimeResolution { get; set; }

    [StringLength(16)]
    public string? SourceMovementType { get; set; }

    public double? MinStepSize { get; set; }

    public double? MaxStepSize { get; set; }

    public int? NumOfDwellPosPerChannel { get; set; }

    public double? StepSizeResolution { get; set; }

    public double? PosToSourceDist { get; set; }

    [StringLength(16)]
    public string? DoseRateMode { get; set; }

    [StringLength(254)]
    public string? ExportDirectory { get; set; }

    [StringLength(254)]
    public string? ExportPostProcessor { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Channel> Channel { get; set; } = new List<Channel>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("BrachyUnit")]
    public virtual RadiationDevice ResourceSerNavigation { get; set; } = null!;
}
