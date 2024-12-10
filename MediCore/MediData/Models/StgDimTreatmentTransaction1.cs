using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimTreatmentTransaction", Schema = "DWH")]
public partial class StgDimTreatmentTransaction1
{
    public long RadiationHstrySer { get; set; }
}
