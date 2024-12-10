using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvArchiveMediaStatus
{
    [StringLength(32)]
    public string ListSelector { get; set; } = null!;

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(64)]
    public string LookupValue { get; set; } = null!;

    [StringLength(64)]
    public string? Expression1 { get; set; }
}
