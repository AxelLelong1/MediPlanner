using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetChartQatreatment
{
    [Column("LastChartQADate", TypeName = "datetime")]
    public DateTime LastChartQadate { get; set; }

    [Column("ctrChartQATreatmentSer")]
    public long CtrChartQatreatmentSer { get; set; }

    public long RadiationHstrySer { get; set; }
}
