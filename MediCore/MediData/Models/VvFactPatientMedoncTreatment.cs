using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientMedoncTreatment
{
    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentPlanInitTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentPlanEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TreatmentStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentEndDate { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("userid_link")]
    [StringLength(255)]
    public string? UseridLink { get; set; }

    [StringLength(1)]
    public string? ClinicalTrialTreatmentIndicator { get; set; }

    [StringLength(1)]
    public string? ClinicalTrialFlag { get; set; }

    public int? NumberOfCycles { get; set; }

    public int? NoOfCyclesCompleted { get; set; }

    public int? CycleLength { get; set; }

    public int? StartCycle { get; set; }

    public int? StartDay { get; set; }

    public int? TreatmentLine { get; set; }

    [StringLength(40)]
    public string? TreatmentIntent { get; set; }

    [StringLength(40)]
    public string? TreatmentUse { get; set; }

    public string? TreatmentComments { get; set; }

    public int? TreatmentModality { get; set; }

    [StringLength(255)]
    public string? TreatmentDescription { get; set; }

    [StringLength(30)]
    public string? DiseaseSite { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("ctrpt_tx_id")]
    public int CtrptTxId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtTxLastModifiedDate { get; set; }

    [StringLength(255)]
    public string? PtTxLastModifiedByUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtTpLastModifiedDate { get; set; }

    [StringLength(255)]
    public string? PtTpLastModifiedByUser { get; set; }

    [Column("ctrpt_dx_id")]
    public int? CtrptDxId { get; set; }

    public int? PtTreatmentIntent { get; set; }

    public int? PtTreatmentUse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PtTreatmentPlanInitDate { get; set; }
}
