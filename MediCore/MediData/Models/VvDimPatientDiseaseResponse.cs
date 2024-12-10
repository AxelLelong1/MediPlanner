using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientDiseaseResponse
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDate { get; set; }

    [Column("ctrcncr_status_id")]
    public int CtrcncrStatusId { get; set; }

    public string DiseaseResponse { get; set; } = null!;

    public int? DiseaseStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DiseaseStatusEffectiveDate { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrpt_tx_id")]
    public int? CtrptTxId { get; set; }

    [Column("ctrpt_dx_id")]
    public int CtrptDxId { get; set; }

    [StringLength(1)]
    public string? DiseaseStatusValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string? DiagnosisValidEntryIndicator { get; set; }
}
