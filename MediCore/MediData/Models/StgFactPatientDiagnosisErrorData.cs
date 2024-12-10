using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientDiagnosisErrorData", Schema = "DWH")]
public partial class StgFactPatientDiagnosisErrorData
{
    [Column("diagnosis_ser")]
    public long? DiagnosisSer { get; set; }

    public long? PatientSer { get; set; }
}
