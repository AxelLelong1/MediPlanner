using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgEnergy", Schema = "DWH")]
public partial class StgEnergy1
{
    public long? EnergyModeSer { get; set; }
}
