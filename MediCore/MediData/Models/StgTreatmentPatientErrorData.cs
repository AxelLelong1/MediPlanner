using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgTreatmentPatientErrorData", Schema = "DWH")]
public partial class StgTreatmentPatientErrorData
{
    public long? PatientSer { get; set; }

    public int? IsDuplicateSer { get; set; }
}
