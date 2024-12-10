using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientProcedureHistoryIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrprocedure_id")]
    public int CtrprocedureId { get; set; }

    [StringLength(16)]
    public string? IcdCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcedureDate { get; set; }

    [StringLength(255)]
    public string? ProcedureName { get; set; }

    public string? TreatmentDescription { get; set; }

    public string? ProcedureOutcome { get; set; }

    [StringLength(1)]
    public string? DateApproxIndicator { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [Column("ctrproc_id")]
    public int? CtrprocId { get; set; }

    public int? RevisionNumber { get; set; }

    public int? AgeAtProcedure { get; set; }

    public int? DiagnosisScheme { get; set; }

    [StringLength(1)]
    public string? ProcedureValidEntryIndicator { get; set; }

    [Column("SnomedCTCode")]
    public long? SnomedCtcode { get; set; }
}
