using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimMedoncPlanInterval
{
    [StringLength(20)]
    public string? TreatmentPlanName { get; set; }

    [StringLength(10)]
    public string? TreatmentPlanVersionNumber { get; set; }

    [Column("intv_id")]
    public int IntvId { get; set; }

    [StringLength(1)]
    public string EventType { get; set; } = null!;

    [StringLength(40)]
    public string? EventName { get; set; }

    [StringLength(100)]
    public string? EventDescription { get; set; }

    [StringLength(255)]
    public string? InterventionName { get; set; }

    [StringLength(1024)]
    public string? InterventionDetailText { get; set; }

    public int? PhaseSequenceNumber { get; set; }

    [Column("TPCycleNumber")]
    public int? TpcycleNumber { get; set; }

    public int? CycleDay { get; set; }

    [StringLength(1)]
    public string? CyclicIndicator { get; set; }

    [Column("PRNIndicator")]
    [StringLength(1)]
    public string? Prnindicator { get; set; }

    [StringLength(50)]
    public string? AgentName { get; set; }

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [StringLength(40)]
    public string? DoseLevelDescription { get; set; }

    [Column(TypeName = "decimal(11, 4)")]
    public decimal? AdminDosage { get; set; }

    public int? AdminDosageUnit { get; set; }

    [StringLength(1024)]
    public string? SpecialInstructions { get; set; }

    [StringLength(50)]
    public string? ReminderShortDescription { get; set; }

    [StringLength(1024)]
    public string? ReminderDescription { get; set; }

    [StringLength(40)]
    public string? ReceipentDisciplineType { get; set; }

    [StringLength(20)]
    public string? TypeOfTest { get; set; }

    [StringLength(30)]
    public string? ComponentName { get; set; }

    [StringLength(20)]
    public string? QuestionnaireName { get; set; }

    public int? GradingSchemeAuthor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [StringLength(30)]
    public string? ToxicityType { get; set; }

    [StringLength(30)]
    public string? ToxicityComponentName { get; set; }

    [StringLength(1024)]
    public string? ToxicityReason { get; set; }

    [StringLength(60)]
    public string? ToxicitySubComponentName { get; set; }
}
