using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientPayorErrorData", Schema = "DWH")]
public partial class StgFactPatientPayorErrorData
{
    public long? PatientPayorSer { get; set; }

    public long? PatientSer { get; set; }
}
