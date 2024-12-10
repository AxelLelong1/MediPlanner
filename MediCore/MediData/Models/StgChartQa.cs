using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgChartQA", Schema = "DWH")]
public partial class StgChartQa
{
    [Column("ctrChartQATreatmentSer")]
    public long CtrChartQatreatmentSer { get; set; }
}
