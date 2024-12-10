using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactCourseDiagnosis", Schema = "DWH")]
public partial class StgFactCourseDiagnosis1
{
    public long? CourseSer { get; set; }

    public long? DiagnosisSer { get; set; }

    public long? PatientSer { get; set; }
}
