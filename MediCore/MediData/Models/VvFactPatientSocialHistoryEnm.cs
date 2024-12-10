using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientSocialHistoryEnm
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    public int? NoAlcoholUsePerWeek { get; set; }

    public int? NoAlcoholUsePerDay { get; set; }

    public double? NoPacksPerDay { get; set; }

    public int? NoYearsQuitAlcohol { get; set; }

    public int? NoYearsQuitSmoking { get; set; }

    public int? NoYearsActiveSmoker { get; set; }

    [StringLength(1)]
    public string? HazardMaterialContactIndicator { get; set; }

    [StringLength(18)]
    public string? AlcoholUseStatus { get; set; }

    [StringLength(19)]
    public string? SmokingUseStatus { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [Column("ctrPatientSocialHistoryId")]
    public int CtrPatientSocialHistoryId { get; set; }
}
