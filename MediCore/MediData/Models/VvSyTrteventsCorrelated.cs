using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyTrteventsCorrelated
{
    public long RadiationHstrySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentStartTime { get; set; }

    public int? IsImage { get; set; }

    public int? FractionNumber { get; set; }

    public int? FractionNumberCalc { get; set; }

    public int? EventNumber { get; set; }

    public int? CorrelatedEventNumber { get; set; }

    public int? LastFractionNumber { get; set; }

    public int? LastFractionNumberCalc { get; set; }

    public int? LastEventNumber { get; set; }

    public int? LastCorrelatedEventNumber { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("FirstRTPlanSer")]
    public long FirstRtplanSer { get; set; }

    public long PatientSer { get; set; }
}
