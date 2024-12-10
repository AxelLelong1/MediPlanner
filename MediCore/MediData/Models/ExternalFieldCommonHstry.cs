using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ToleranceSer", Name = "XIF2ExternalFieldCommonHstry")]
public partial class ExternalFieldCommonHstry
{
    [Key]
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

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ExternalFieldHstry? ExternalFieldHstry { get; set; }

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("ExternalFieldCommonHstry")]
    public virtual RadiationHstry RadiationHstrySerNavigation { get; set; } = null!;

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ICollection<TfhaddOn> TfhaddOn { get; set; } = new List<TfhaddOn>();

    [ForeignKey("ToleranceSer")]
    [InverseProperty("ExternalFieldCommonHstry")]
    public virtual Tolerance? ToleranceSerNavigation { get; set; }
}
