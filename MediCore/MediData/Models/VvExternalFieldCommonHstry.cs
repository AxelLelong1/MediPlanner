using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvExternalFieldCommonHstry
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    public long RadiationHstrySer { get; set; }

    public double? PlannedMeterset { get; set; }

    public double? ActualMeterset { get; set; }

    public byte MetersetOverrideFlag { get; set; }

    [Column("SSD")]
    public double? Ssd { get; set; }

    public double? CouchCorrectionLat { get; set; }

    public double? CouchCorrectionLng { get; set; }

    public double? CouchCorrectionVrt { get; set; }

    public double? CouchLat { get; set; }

    public byte CouchLatOverrideFlag { get; set; }

    public double? CouchLatPlanned { get; set; }

    public double? CouchLng { get; set; }

    public byte CouchLngOverrideFlag { get; set; }

    public double? CouchLngPlanned { get; set; }

    public double? CouchVrt { get; set; }

    public byte CouchVrtOverrideFlag { get; set; }

    public double? CouchVrtPlanned { get; set; }

    public byte TableTopEccAngleOverFlag { get; set; }

    public double? TableTopEccentricAngle { get; set; }

    public double? PatientSupportAngle { get; set; }

    public byte PatientSupportAngleOverFlag { get; set; }

    public byte PatSupPitchOverrideFlag { get; set; }

    public double? PatSupportPitchAngle { get; set; }

    public double? PatSupportRollAngle { get; set; }

    public byte PatSupRollOverrideFlag { get; set; }

    [Column("PFFlag")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pfflag { get; set; }

    [Column("PFMUSubFlag")]
    public byte PfmusubFlag { get; set; }

    [Column("PIFlag")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Piflag { get; set; }

    public long? ToleranceSer { get; set; }

    public int? NominalEnergy { get; set; }

    public byte EnergyModeOverrideFlag { get; set; }

    [Column("SSDOverrideFlag")]
    public byte SsdoverrideFlag { get; set; }
}
