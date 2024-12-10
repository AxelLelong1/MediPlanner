using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimStakeHolderKeys", Schema = "DWH")]
public partial class StgDimStakeHolderKeys
{
    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("stkh_key_id")]
    public int? StkhKeyId { get; set; }

    [Column("stkh_key_cd")]
    public int? StkhKeyCd { get; set; }
}
