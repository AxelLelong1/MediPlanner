using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyDoseFiguresApp
{
    public long PatientSer { get; set; }

    public long CourseSer { get; set; }

    public long PlanSetupSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("FirstRTPlanSer")]
    public long FirstRtplanSer { get; set; }

    public long? RefPointSer { get; set; }

    public int? PrimaryFlag { get; set; }

    public int FractionsDelivered { get; set; }

    public int FractionsPlanned { get; set; }

    public int FractionsRemaining { get; set; }

    public double? DosePerFraction { get; set; }

    public double? DoseDelivered { get; set; }

    public double? DoseRemainingInFraction { get; set; }

    public int? RunningPartial { get; set; }

    public double? DoseRemainingMax { get; set; }

    public double? DoseRemainingMin { get; set; }

    public double? DoseRemaining { get; set; }

    public double? DosePredictedMax { get; set; }

    public double? DosePredictedMin { get; set; }

    public double? DosePredicted { get; set; }
}
