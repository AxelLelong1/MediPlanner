using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_CancerType", Schema = "DWH")]
public partial class StgCancerType
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("tp_cls_value_id")]
    public int? TpClsValueId { get; set; }
}
