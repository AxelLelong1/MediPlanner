using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimMedOncPlan
{
    [Column("ctrtp_name")]
    [StringLength(20)]
    public string? CtrtpName { get; set; }

    [Column("ctrtp_vers_no")]
    [StringLength(10)]
    public string? CtrtpVersNo { get; set; }

    [StringLength(1)]
    public string? PlanStatus { get; set; }

    [StringLength(8)]
    public string? PlanStatusDesc { get; set; }

    public int? PlanType { get; set; }

    [StringLength(50)]
    public string? PlanTypeDescription { get; set; }

    [StringLength(80)]
    public string? TreatmentPlanDisplayName { get; set; }

    [StringLength(1024)]
    public string? PlanSummary { get; set; }

    [StringLength(200)]
    public string? PlanBriefDesc { get; set; }

    public int? PlanClassification { get; set; }

    [StringLength(1)]
    public string? ClinicalTrialIndicator { get; set; }

    [StringLength(1)]
    public string? ActiveIndicator { get; set; }

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    public int? AgeStart { get; set; }

    public int? AgeEnd { get; set; }
}
