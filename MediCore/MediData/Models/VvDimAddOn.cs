using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimAddOn
{
    [StringLength(16)]
    public string AddOnId { get; set; } = null!;

    [StringLength(64)]
    public string? AddOnName { get; set; }

    [StringLength(30)]
    public string? AddOnType { get; set; }

    [StringLength(64)]
    public string? AddOnSubType { get; set; }

    [Column("ctrAddOnSer")]
    public long CtrAddOnSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }
}
