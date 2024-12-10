using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("Temp_DoseRefPoint", Schema = "DWH")]
public partial class TempDoseRefPoint
{
    public long PatientSer { get; set; }

    public long? RefPointSer { get; set; }

    public double? DosePredicted { get; set; }

    public double? DoseDelivered { get; set; }

    public double? DoseCorrection { get; set; }

    public double? DoseRemaining { get; set; }

    public int? SessionsRemainingPrimary { get; set; }

    public int? SessionsRemainingAny { get; set; }
}
