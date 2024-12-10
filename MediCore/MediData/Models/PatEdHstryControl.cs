using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Index("GroupId", "AttribName", "OldValue", Name = "XIE1PatEdHstryControl")]
public partial class PatEdHstryControl
{
    public int GroupId { get; set; }

    [StringLength(64)]
    public string AttribName { get; set; } = null!;

    [StringLength(254)]
    public string? OldValue { get; set; }

    [StringLength(254)]
    public string? NewValue { get; set; }
}
