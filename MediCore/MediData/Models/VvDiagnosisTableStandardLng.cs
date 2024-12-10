using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDiagnosisTableStandardLng
{
    [StringLength(64)]
    public string? LookupValue { get; set; }

    [StringLength(64)]
    public string? Expression1 { get; set; }

    public int DefaultFlag { get; set; }
}
