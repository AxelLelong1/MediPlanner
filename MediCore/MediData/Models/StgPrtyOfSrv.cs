using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_prty_of_srv", Schema = "DWH")]
public partial class StgPrtyOfSrv
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("prty_of_srv")]
    public int? PrtyOfSrv { get; set; }
}
