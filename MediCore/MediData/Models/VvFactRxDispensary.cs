using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactRxDispensary
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrrx_id")]
    public int CtrrxId { get; set; }

    [Column("ctritem_no")]
    public int CtritemNo { get; set; }

    [Column("ctrdisp_id")]
    public int CtrdispId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RxDispDate { get; set; } = null!;

    [Column("RxDispBy_userid")]
    [StringLength(255)]
    public string? RxDispByUserid { get; set; }

    [Column("RxDispBy_inst_id")]
    [StringLength(30)]
    public string? RxDispByInstId { get; set; }

    [StringLength(255)]
    public string? RxDispComment { get; set; }

    [StringLength(1)]
    public string? RxDispApproved { get; set; }

    [StringLength(1)]
    public string? RxDispValidEntry { get; set; }

    [Column("RxDispEnteredBy_userid")]
    [StringLength(255)]
    public string? RxDispEnteredByUserid { get; set; }

    [Column("RxDispEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxDispEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxDispEnteredDatetime { get; set; }

    [Column("RxDispLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxDispLastModifiedByUserid { get; set; }

    [Column("RxDispLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxDispLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxDispLastModifiedDatetime { get; set; }

    [StringLength(50)]
    public string? RxDispAgentName { get; set; }

    public int? RxDispDosageForm { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispDispensedDose { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispDispensedDoseRange { get; set; }

    public int? RxDispDoseUnit { get; set; }

    public int? RxDispAdminRoute { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispOrderDose { get; set; }

    public int? RxDispOrderUnit { get; set; }

    [StringLength(15)]
    public string? RxDispDoseStrength { get; set; }

    public int? RxDispDoseStrengthUnit { get; set; }

    public int? RxDispInfusionType { get; set; }

    public int? RxDispInfusionDuration { get; set; }

    public int? RxDispInfusionDurationUnit { get; set; }

    public int? RxDispSyringeQuantity { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispSyringeVolume { get; set; }

    public int? RxDispSyringeVolumeUnit { get; set; }

    [StringLength(1)]
    public string? RxDispChangeIndicator { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispAgentVolume { get; set; }

    public int? RxDispAgentVolumeUnit { get; set; }

    public int? RxDispHydraDispenseId { get; set; }

    [StringLength(255)]
    public string? RxDispCourseDescription { get; set; }

    [StringLength(255)]
    public string? RxDispErrorReason { get; set; }

    [StringLength(1)]
    public string? RxDispNotDispensedIndicator { get; set; }

    [Column(TypeName = "numeric(11, 0)")]
    public decimal? RxDispDispenseQuantity { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispDispenseVolume { get; set; }

    public int? RxDispUnit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RxDispExpiryDate { get; set; } = null!;

    [StringLength(10)]
    public string? RxDispPlacerOrderNo { get; set; }

    [StringLength(255)]
    public string? RxDispHydraOverrideReason { get; set; }

    [Column("RxDispHydraOverriddenBy_userid")]
    [StringLength(255)]
    public string? RxDispHydraOverriddenByUserid { get; set; }

    [Column("RxDispHydraOverriddenBy_inst_id")]
    [StringLength(30)]
    public string? RxDispHydraOverriddenByInstId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RxDispHydraOverriddenDatetime { get; set; } = null!;

    [StringLength(1)]
    public string? RxDispCustomSyringeIndicator { get; set; }

    [Column("ctrsyringe_id")]
    public int? CtrsyringeId { get; set; }

    [StringLength(1)]
    public string? RxDispReviewIndicator { get; set; }

    [StringLength(15)]
    public string? RxDispConcentration { get; set; }

    [StringLength(1)]
    public string? RxDispFormularyChecked { get; set; }
}
