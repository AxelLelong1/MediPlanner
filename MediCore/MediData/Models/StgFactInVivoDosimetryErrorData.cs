using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactInVivoDosimetryErrorData", Schema = "DWH")]
public partial class StgFactInVivoDosimetryErrorData
{
    public long? InVivoDosimetrySer { get; set; }

    public long? PatientSer { get; set; }
}
