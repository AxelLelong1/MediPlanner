using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_vv_lookup_typ_culture")]
public partial class StgVvLookupTypCulture
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("lookup_typ")]
    public int? LookupTyp { get; set; }
}
