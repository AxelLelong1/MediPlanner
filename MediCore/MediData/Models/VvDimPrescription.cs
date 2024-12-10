using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPrescription
{
    [StringLength(64)]
    public string PrescriptionName { get; set; } = null!;

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(31)]
    public string? Revision { get; set; }

    [StringLength(64)]
    public string? Site { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? NumberOfFractions { get; set; }

    [StringLength(64)]
    public string? Technique { get; set; }

    [StringLength(1024)]
    public string? Notes { get; set; }

    [StringLength(32)]
    public string? TimeGapType { get; set; }

    public int? PhaseGapNumberOfDays { get; set; }

    [StringLength(16)]
    public string? PhaseType { get; set; }

    [StringLength(32)]
    public string? Gating { get; set; }

    [StringLength(64)]
    public string? BolusFrequency { get; set; }

    [StringLength(64)]
    public string? BolusThickness { get; set; }

    public int? SimulationNeeded { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedOn { get; set; }

    [StringLength(255)]
    public string? ApprovedBy { get; set; }

    [StringLength(4000)]
    public string? History { get; set; }

    [StringLength(256)]
    public string? LinkedPlans { get; set; }

    public long? RelPrescriptionSer { get; set; }

    [Column("ctrPrescriptionSer")]
    public long CtrPrescriptionSer { get; set; }
}
