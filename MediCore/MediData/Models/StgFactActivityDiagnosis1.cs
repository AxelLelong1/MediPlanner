using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactActivityDiagnosis", Schema = "DWH")]
public partial class StgFactActivityDiagnosis1
{
    public long? ActivityInstanceSer { get; set; }

    public long? DiagnosisSer { get; set; }

    public long? ActivityCaptureSer { get; set; }

    public int? ActivityCaptureRevCount { get; set; }

    public long? PatientSer { get; set; }
}
