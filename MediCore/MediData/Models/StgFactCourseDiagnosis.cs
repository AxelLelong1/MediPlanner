using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactCourseDiagnosis")]
public partial class StgFactCourseDiagnosis
{
    public long? CourseSer { get; set; }

    public long? DiagnosisSer { get; set; }
}
