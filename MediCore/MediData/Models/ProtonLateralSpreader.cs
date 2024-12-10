using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ProtonLateralSpreader
{
    [Key]
    public long AddOnSer { get; set; }

    public double? IsoLatSpreadDevDist { get; set; }

    [StringLength(32)]
    public string ProtonLatSpreaderType { get; set; } = null!;

    [ForeignKey("AddOnSer")]
    [InverseProperty("ProtonLateralSpreader")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;
}
