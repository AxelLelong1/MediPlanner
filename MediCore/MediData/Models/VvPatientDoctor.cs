using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPatientDoctor
{
    public long PatientSer { get; set; }

    public long? ResourceSer { get; set; }

    public int? PrimaryFlag { get; set; }

    public int? OncologistFlag { get; set; }
}
