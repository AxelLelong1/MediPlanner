using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_vv_lookup_cd_culture")]
public partial class StgVvLookupCdCulture
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("lookup_cd")]
    [StringLength(20)]
    public string? LookupCd { get; set; }
}
