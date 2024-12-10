using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_calc_typ", Schema = "DWH")]
public partial class StgCalcTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("calc_typ")]
    public int? CalcTyp { get; set; }
}
