using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientAllergyIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrallergy_id")]
    public int CtrallergyId { get; set; }

    public int AllergyType { get; set; }

    public int? AllergySeverity { get; set; }

    [Column("DimDateID_AllergyStarted")]
    public int DimDateIdAllergyStarted { get; set; }

    [StringLength(1024)]
    public string? AllergicResponse { get; set; }

    [StringLength(1024)]
    public string? AllergyDescription { get; set; }

    [StringLength(10)]
    public string? AllergicDrugDescription { get; set; }

    [StringLength(16)]
    public string? AllergicReaction { get; set; }

    [StringLength(40)]
    public string AllergyTypeDesc { get; set; } = null!;

    [StringLength(5)]
    public string? AllergyCode { get; set; }

    [StringLength(5)]
    public string? AllergySeverityCode { get; set; }

    [StringLength(40)]
    public string? AllergySeverityDescripton { get; set; }

    [StringLength(50)]
    public string? AllergyAgentName { get; set; }

    [StringLength(255)]
    public string? AllergyComment { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }
}
