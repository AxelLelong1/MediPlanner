using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientDiagnosis")]
public partial class StgFactPatientDiagnosis
{
    [Column("diagnosis_ser")]
    public long? DiagnosisSer { get; set; }
}
