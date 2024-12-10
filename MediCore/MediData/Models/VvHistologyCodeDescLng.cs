using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvHistologyCodeDescLng
{
    [StringLength(64)]
    public string? HistologyTableName { get; set; }

    [StringLength(16)]
    public string HistologyCode { get; set; } = null!;

    [StringLength(16)]
    public string? LanguageId { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }
}
