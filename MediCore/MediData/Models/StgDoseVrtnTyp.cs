using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_dose_vrtn_typ", Schema = "DWH")]
public partial class StgDoseVrtnTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("dose_vrtn_typ")]
    public int? DoseVrtnTyp { get; set; }
}
