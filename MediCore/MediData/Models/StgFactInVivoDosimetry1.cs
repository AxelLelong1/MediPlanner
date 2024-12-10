using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactInVivoDosimetry", Schema = "DWH")]
public partial class StgFactInVivoDosimetry1
{
    public long? InVivoDosimetrySer { get; set; }

    public long? PatientSer { get; set; }
}
