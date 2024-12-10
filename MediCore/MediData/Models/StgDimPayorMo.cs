using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPayor_MO", Schema = "DWH")]
public partial class StgDimPayorMo
{
    [Column("inst_id")]
    [StringLength(60)]
    public string? InstId { get; set; }

    [Column("ins_co_id")]
    public int? InsCoId { get; set; }
}
