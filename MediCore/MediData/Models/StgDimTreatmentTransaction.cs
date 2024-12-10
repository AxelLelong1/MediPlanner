using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimTreatmentTransaction")]
public partial class StgDimTreatmentTransaction
{
    public long RadiationHstrySer { get; set; }
}
