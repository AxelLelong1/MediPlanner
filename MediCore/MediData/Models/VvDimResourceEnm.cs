using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimResourceEnm
{
    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    public long? ResourceSer { get; set; }

    [StringLength(40)]
    public string? ResourceType { get; set; }

    [Column("usercuid")]
    [StringLength(64)]
    public string? Usercuid { get; set; }
}
