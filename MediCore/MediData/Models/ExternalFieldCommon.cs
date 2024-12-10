using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ToleranceSer", Name = "XIF2ExternalFieldCommon")]
[Index("EnergyModeSer", Name = "XIF4ExternalFieldCommon")]
[Index("TechniqueSer", Name = "XIF5ExternalFieldCommon")]
public partial class ExternalFieldCommon
{
    [Key]
    public long RadiationSer { get; set; }

    public double? Meterset { get; set; }

    public double? TreatmentTime { get; set; }

    public int SetupFieldFlag { get; set; }

    [StringLength(254)]
    public string? MotionCompSource { get; set; }

    [StringLength(254)]
    public string? MotionCompTechnique { get; set; }

    [StringLength(16)]
    public string? SetupTechnique { get; set; }

    [Column("SSD")]
    public double? Ssd { get; set; }

    public double? SourceFieldEntryDistance { get; set; }

    public double? CouchLat { get; set; }

    public double? CouchLatDelta { get; set; }

    public double? CouchLng { get; set; }

    public double? CouchLngDelta { get; set; }

    public double? CouchVrt { get; set; }

    public double? CouchVrtDelta { get; set; }

    public double? PatientSupportAngle { get; set; }

    public double TableTopPitchAngle { get; set; }

    public double TableTopRollAngle { get; set; }

    [Column("IDUPosLat")]
    public double? IduposLat { get; set; }

    [Column("IDUPosLng")]
    public double? IduposLng { get; set; }

    [Column("IDUPosVrt")]
    public double? IduposVrt { get; set; }

    [Column("IDURtn")]
    public double? Idurtn { get; set; }

    public double? IsoCenterPositionX { get; set; }

    public double? IsoCenterPositionY { get; set; }

    public double? IsoCenterPositionZ { get; set; }

    public long? TechniqueSer { get; set; }

    public long? EnergyModeSer { get; set; }

    public long? ToleranceSer { get; set; }

    public int ImagingTreatmentFieldFlag { get; set; }

    public double? PrescribedMeterset { get; set; }

    [StringLength(16)]
    public string? ImagingFieldSetupTemplateId { get; set; }

    [StringLength(16)]
    public string? ImagingFieldTemplateId { get; set; }

    [StringLength(16)]
    public string? SessionProcedureTemplateId { get; set; }

    public double? AbsDoseRefFieldSize { get; set; }

    [Column("AbsDoseCalibSPD")]
    public double? AbsDoseCalibSpd { get; set; }

    public double? AbsDoseCalibDepth { get; set; }

    public double? RefDoseGyAtCalibDepth { get; set; }

    [Column("RefDoseMUAtCalibDepth")]
    public double? RefDoseMuatCalibDepth { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<Block> Block { get; set; } = new List<Block>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<Compensator> Compensator { get; set; } = new List<Compensator>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<ControlPoint> ControlPoint { get; set; } = new List<ControlPoint>();

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("ExternalFieldCommon")]
    public virtual EnergyMode? EnergyModeSerNavigation { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ExternalField? ExternalField { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<FieldAddOn> FieldAddOn { get; set; } = new List<FieldAddOn>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<FieldStructure> FieldStructure { get; set; } = new List<FieldStructure>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<Mlcplan> Mlcplan { get; set; } = new List<Mlcplan>();

    [ForeignKey("RadiationSer")]
    [InverseProperty("ExternalFieldCommon")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<RefWaveformField> RefWaveformField { get; set; } = new List<RefWaveformField>();

    [ForeignKey("TechniqueSer")]
    [InverseProperty("ExternalFieldCommon")]
    public virtual Technique? TechniqueSerNavigation { get; set; }

    [ForeignKey("ToleranceSer")]
    [InverseProperty("ExternalFieldCommon")]
    public virtual Tolerance? ToleranceSerNavigation { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<TrackingField> TrackingField { get; set; } = new List<TrackingField>();
}
