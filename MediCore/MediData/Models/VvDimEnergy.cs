using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimEnergy
{
    [StringLength(16)]
    public string RadiationType { get; set; } = null!;

    public int Energy { get; set; }

    public int? MaxEnergy { get; set; }

    public int? MinDoseRate { get; set; }

    public int? MaxDoseRate { get; set; }

    [Column("ctrEnergyModeSer")]
    public long CtrEnergyModeSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }
}
