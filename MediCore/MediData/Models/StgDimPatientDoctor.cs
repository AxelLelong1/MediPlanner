using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientDoctor")]
public partial class StgDimPatientDoctor
{
    public long? ResourceSer { get; set; }

    public long? PatientSer { get; set; }
}
