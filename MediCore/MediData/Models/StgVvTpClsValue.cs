using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_vv_tp_cls_value", Schema = "DWH")]
public partial class StgVvTpClsValue
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("lookuptype")]
    [StringLength(20)]
    public string? Lookuptype { get; set; }
}
