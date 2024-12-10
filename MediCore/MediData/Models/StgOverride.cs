using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgOverride")]
public partial class StgOverride
{
    public long? PatientSer { get; set; }

    public long? CourseSer { get; set; }

    public long? PlanSetupSer { get; set; }
}
