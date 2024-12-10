using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPatientPayorInfo
{
    public long PlanTypeSer { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    public long PatientSer { get; set; }

    public long PlanSourceSer { get; set; }
}
