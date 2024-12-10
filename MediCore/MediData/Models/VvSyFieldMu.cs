using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyFieldMu
{
    public long RadiationSer { get; set; }

    public long PlanSetupSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("MU")]
    public double? Mu { get; set; }

    [Column("MURounded", TypeName = "numeric(18, 4)")]
    public decimal? Murounded { get; set; }
}
