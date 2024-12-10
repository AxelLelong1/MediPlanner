using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimActivityAttribute
{
    public long ActivitySer { get; set; }

    public int ActivityRevCount { get; set; }

    public long ActivityAttributeSer { get; set; }

    public int ActivityAttributeRevCount { get; set; }

    [StringLength(16)]
    public string ActivityAttributeObjectStatus { get; set; } = null!;

    public long UserDefActAttrSer { get; set; }

    public int UserDefActAttrRevCount { get; set; }

    [StringLength(16)]
    public string UserDefActAttrId { get; set; } = null!;

    [StringLength(254)]
    public string? Description { get; set; }
}
