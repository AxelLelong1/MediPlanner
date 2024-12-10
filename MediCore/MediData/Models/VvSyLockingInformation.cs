using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyLockingInformation
{
    [Column("spid")]
    public int Spid { get; set; }

    [StringLength(128)]
    public string? Database { get; set; }

    [StringLength(128)]
    public string? Name { get; set; }

    public short Index { get; set; }

    [StringLength(32)]
    public string Description { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string ResourceType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string OwnerType { get; set; } = null!;

    [StringLength(29)]
    [Unicode(false)]
    public string LockRequestMode { get; set; } = null!;
}
