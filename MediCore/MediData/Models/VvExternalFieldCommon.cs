using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvExternalFieldCommon
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

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

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

    public int? ImagingTreatmentFieldFlag { get; set; }

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
}
