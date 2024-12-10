using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvResourceName
{
    public long ResourceSer { get; set; }

    [StringLength(208)]
    public string ResourceName { get; set; } = null!;
}
