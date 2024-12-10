using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class WeightTestResult
{
    public long? PatientSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MeasurementDate { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? MeasurementValue { get; set; }

    [StringLength(40)]
    public string? Unit { get; set; }

    [StringLength(30)]
    public string MeasurementType { get; set; } = null!;
}
