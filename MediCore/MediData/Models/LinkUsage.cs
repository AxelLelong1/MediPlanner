using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class LinkUsage
{
    [Key]
    [StringLength(254)]
    public string StoredProcedureName { get; set; } = null!;

    public int UsageCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateStartedUse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastDateUsed { get; set; }
}
