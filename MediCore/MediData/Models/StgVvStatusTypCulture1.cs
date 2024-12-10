using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_vv_status_typ_culture", Schema = "DWH")]
public partial class StgVvStatusTypCulture1
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }
}
