using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimMachine
{
    [StringLength(64)]
    public string? MachineFullName { get; set; }

    [StringLength(16)]
    public string MachineAliasName { get; set; } = null!;

    [StringLength(16)]
    public string MachineId { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Schedulable { get; set; }

    [StringLength(64)]
    public string MachineModel { get; set; } = null!;

    [StringLength(16)]
    public string? MachineScale { get; set; }

    [StringLength(30)]
    public string MachineType { get; set; } = null!;

    public int ResourceTypeNum { get; set; }

    [StringLength(16)]
    public string ResourceObjectStatus { get; set; } = null!;

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [StringLength(30)]
    public string? RadiationDeviceType { get; set; }

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
    public string? BrachyExportPostProcessor { get; set; }
}
