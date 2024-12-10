using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_dose_level", Schema = "DWH")]
public partial class StgDoseLevel
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("dose_level")]
    public int? DoseLevel { get; set; }
}
