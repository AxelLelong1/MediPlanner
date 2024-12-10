using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_vv_stage_def_culture", Schema = "DWH")]
public partial class StgVvStageDefCulture1
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("stage_cd")]
    [StringLength(40)]
    public string? StageCd { get; set; }
}
