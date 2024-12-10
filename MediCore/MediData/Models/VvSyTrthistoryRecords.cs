using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyTrthistoryRecords
{
    public long PatientSer { get; set; }

    public long CourseSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long RadiationSer { get; set; }

    public long RadiationHstrySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentStartTime { get; set; }

    public int? FractionNumber { get; set; }

    [Column("RecordMUActual")]
    public double? RecordMuactual { get; set; }

    [Column("FieldMUActual")]
    public double? FieldMuactual { get; set; }

    [Column("FieldMUPlanned")]
    public double? FieldMuplanned { get; set; }

    [StringLength(16)]
    public string? RecordStatus { get; set; }

    [StringLength(16)]
    public string? FieldStatus { get; set; }

    [StringLength(16)]
    public string? TreatmentDeliveryType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentStartTimeFirst { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentStartTimeLast { get; set; }
}
