using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDoseOverrideView
{
    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(16)]
    public string SiteId { get; set; } = null!;

    [StringLength(64)]
    public string? SiteName { get; set; }

    public double? TotalDose { get; set; }

    public double? DailyDose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DoseOverDateTime { get; set; }

    [StringLength(32)]
    public string DoseOverType { get; set; } = null!;

    [StringLength(255)]
    public string? DoseOverAuthName { get; set; }

    [StringLength(254)]
    public string? DoseUnits { get; set; }
}
