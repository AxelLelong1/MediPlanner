using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientPayor", Schema = "DWH")]
public partial class StgFactPatientPayor1
{
    public long? PatientPayorSer { get; set; }
}
