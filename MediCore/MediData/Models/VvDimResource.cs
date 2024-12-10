using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimResource
{
    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [StringLength(40)]
    public string? ResourceType { get; set; }

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string CtrstkhId { get; set; } = null!;
}
