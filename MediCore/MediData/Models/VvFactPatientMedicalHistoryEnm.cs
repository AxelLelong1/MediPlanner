using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientMedicalHistoryEnm
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    public int? MpauseReasonType { get; set; }

    [Column("DimDateID_DiagnosisDate")]
    public long DimDateIdDiagnosisDate { get; set; }

    [Column("DimDateID_MrPapDate")]
    public long DimDateIdMrPapDate { get; set; }

    [Column("DimDateID_MrMammogramDate")]
    public long DimDateIdMrMammogramDate { get; set; }

    [StringLength(255)]
    public string? ProblemDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiagnosisDate { get; set; }

    [StringLength(1)]
    public string? ActiveDiagnosisIndicator { get; set; }

    [StringLength(1)]
    public string? TreatmentIndicator { get; set; }

    [Column("ICDCode")]
    [StringLength(16)]
    public string? Icdcode { get; set; }

    public int? Gravida { get; set; }

    public int? Para { get; set; }

    public int? NoAbortions { get; set; }

    public int? AgeAtFirstBirth { get; set; }

    public int? MensesStartAge { get; set; }

    [StringLength(1)]
    public string? MpauseCode { get; set; }

    [StringLength(15)]
    public string MpauseDescription { get; set; } = null!;

    public int? MpauseCycle { get; set; }

    public int? MpauseAge { get; set; }

    [StringLength(1)]
    public string? OcpUseIndicator { get; set; }

    public int? OcpUseDuration { get; set; }

    [StringLength(1)]
    public string? MpauseHormoneIndicator { get; set; }

    public int? MpauseHormoneDuration { get; set; }

    [StringLength(1)]
    public string? OtherHormoneUseIndicator { get; set; }

    public int? OtherHormoneDuration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MrPapDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MrMammogramDate { get; set; }

    [StringLength(1)]
    public string? CurrentEntryIndicator { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [Column("ctrPatientMedicalId")]
    public int? CtrPatientMedicalId { get; set; }

    [Column("ctrGyneHistoryId")]
    public int? CtrGyneHistoryId { get; set; }

    public int? DiagnosisScheme { get; set; }

    [StringLength(255)]
    public string? MenopauseReason { get; set; }

    [StringLength(255)]
    public string? GyneHistoryOptionalDetails { get; set; }

    [StringLength(255)]
    public string? HormonesDescription { get; set; }

    [StringLength(1024)]
    public string? GyneHistoryDetails { get; set; }

    [StringLength(255)]
    public string? RecentMammogramComment { get; set; }

    [StringLength(255)]
    public string? RecentPapSmearComment { get; set; }

    [StringLength(255)]
    public string? MenstrualDetails { get; set; }

    [StringLength(255)]
    public string? LatestTestDescription { get; set; }

    [StringLength(1024)]
    public string? MedicalProblemDetails { get; set; }

    [StringLength(100)]
    public string? TreatmentDescription { get; set; }

    public int? AgeAtProcedure { get; set; }

    [StringLength(1)]
    public string? MedicalHistoryValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string? HormoneUseIndicator { get; set; }
}
