using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvRpTfhCourse
{
    public long RadiationHstrySer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string CourseId { get; set; } = null!;
}
