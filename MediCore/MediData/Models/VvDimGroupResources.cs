using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimGroupResources
{
    [Column("ctrGroupResourceSer")]
    public long CtrGroupResourceSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [Column("ctrResourceGroupSer")]
    public long CtrResourceGroupSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
