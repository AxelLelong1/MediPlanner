using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimTreatmentDateRangeController", Schema = "DWH")]
public partial class StgDimTreatmentDateRangeController1
{
    public long? TreatmentRecordSer { get; set; }
}
