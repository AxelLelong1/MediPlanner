using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_xref_tp_cls", Schema = "DWH")]
public partial class StgXrefTpCls1
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("lookup_cd")]
    [StringLength(20)]
    public string? LookupCd { get; set; }

    [Column("tp_cls_value_to")]
    public int? TpClsValueTo { get; set; }
}
