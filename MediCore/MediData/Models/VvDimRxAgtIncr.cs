using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimRxAgtIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrrx_id")]
    public int CtrrxId { get; set; }

    [Column("ctrrx_hydra_id")]
    public int? CtrrxHydraId { get; set; }

    [Column("ctrRxAgtItemNo")]
    public int CtrRxAgtItemNo { get; set; }

    [StringLength(50)]
    public string RxAgtAgentName { get; set; } = null!;

    public int? RxAgtDosageForm { get; set; }

    public int? RxAgtDoseLevel { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAgtRxDose { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RxAgtRxTotal { get; set; }

    public int RxAgtDosageUnit { get; set; }

    public int? RxAdminRoute { get; set; }

    public int? RxDoseFrequencyUnit { get; set; }

    public int? RxAdminFrequency { get; set; }

    public int? RxAdminFrequencyUnit { get; set; }

    public int? RxDuration { get; set; }

    public int? RxDurationUnit { get; set; }

    [StringLength(1)]
    public string RxRequired { get; set; } = null!;

    [StringLength(1)]
    public string? RxAgtStatus { get; set; }

    [StringLength(1)]
    public string? RxSubstitutionsAllowed { get; set; }

    [Column("RxDiscontinueDateID")]
    public long? RxDiscontinueDateId { get; set; }

    [Column("RxAdminStartDateID")]
    public long? RxAdminStartDateId { get; set; }

    [StringLength(3000)]
    public string? RxSubstitutionReason { get; set; }

    [StringLength(3000)]
    public string? RxDiscontinueReason { get; set; }

    [Column("RxDiscontinueEffectiveDateID")]
    public long? RxDiscontinueEffectiveDateId { get; set; }

    [StringLength(1)]
    public string? RxPrnIndicator { get; set; }

    [StringLength(1)]
    public string? RxPrnRepeatIndicator { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDoseRange { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxStrength { get; set; }

    public int? RxStrengthUnit { get; set; }

    [Column("RxTpInitDateID")]
    public long? RxTpInitDateId { get; set; }

    [Column(TypeName = "numeric(11, 0)")]
    public decimal? RxDispenseQuantity { get; set; }

    [StringLength(255)]
    public string? RxCourseDescription { get; set; }

    public int? RxDayofWeekFrequencyUnit { get; set; }

    public int? RxWeekFrequencyUnit { get; set; }

    [StringLength(15)]
    public string? RxPlacerOrderNo { get; set; }

    [Column("RxOrderUnit_DimLookupID")]
    public int? RxOrderUnitDimLookupId { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxOrderDose { get; set; }

    public int? RxAgtSequenceNo { get; set; }

    public int? RxInfusionType { get; set; }

    public int? RxInfusionDuration { get; set; }

    public int? RxInfusionTimescale { get; set; }

    [StringLength(1)]
    public string? RxAgtValidEntryInd { get; set; }

    public int? RxPrnReason { get; set; }

    [Column("RxAgtRxType_DimLookupID")]
    public int? RxAgtRxTypeDimLookupId { get; set; }

    [StringLength(1)]
    public string? RxRefillIndicator { get; set; }

    public int? RxRefillQuantity { get; set; }

    [StringLength(1)]
    public string? RxDispensedIndicator { get; set; }

    [StringLength(15)]
    public string? RxDoseStrength { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAgentVolume { get; set; }

    public int? RxAgentVolumeUnit { get; set; }

    [StringLength(1)]
    public string? RxDispenseDoseLevelIndicator { get; set; }

    [StringLength(1)]
    public string? RxDoseRecordIndicator { get; set; }

    [StringLength(1)]
    public string? RxAgtInactivateIndicator { get; set; }

    [Column("RxAgtRxEnteredBy_userid")]
    [StringLength(255)]
    public string? RxAgtRxEnteredByUserid { get; set; }

    [Column("RxAgtRxEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxAgtRxEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RxAgtRxEnteredTime { get; set; }

    [Column("RxAgtLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxAgtLastModifiedByUserid { get; set; }

    [Column("RxAgtLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxAgtLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxAgtLastModifiedTime { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAgtDosePercent { get; set; }

    [StringLength(1)]
    public string? RxAgtChangeIndicator { get; set; }

    [StringLength(1)]
    public string? RxAdhocActiveEntry { get; set; }

    public int? RxAgtCycleNo { get; set; }

    public int? RxAgtCycleDay { get; set; }

    [StringLength(1)]
    public string? RxAgtTakeAsDirected { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxDispenseVolume { get; set; }

    public int? RxDispenseUnit { get; set; }

    public int? RxAdminFrequencyUpper { get; set; }

    [StringLength(1)]
    public string? RxAgtNotDispensedIndicator { get; set; }

    public int? RxDispenseLocation { get; set; }

    [StringLength(1)]
    public string? RxOverrideDoseTimesIndicator { get; set; }

    [StringLength(1)]
    public string? RxSynchronizeDoseTimesIndicator { get; set; }

    [StringLength(1)]
    public string? RxReviewRequiredIndicator { get; set; }

    [StringLength(1)]
    public string? RxContinueRxIndicator { get; set; }

    [StringLength(1)]
    public string? RxAdminDoseChange { get; set; }

    public int? RxAdminDosesRecorded { get; set; }

    public int? RxAdminDoseTotal { get; set; }

    public int? RxDosesonHold { get; set; }

    [Column("RxApp_cd")]
    [StringLength(10)]
    public string? RxAppCd { get; set; }

    [StringLength(20)]
    public string? RxTpName { get; set; }

    [StringLength(10)]
    public string? RxTpVersion { get; set; }

    public int? RxTpPhase { get; set; }

    [StringLength(255)]
    public string? RxReason { get; set; }

    [StringLength(255)]
    public string? RxHydrationOverrideComment { get; set; }

    [Column("RxHydrationOverriddenBy_user_id")]
    [StringLength(255)]
    public string? RxHydrationOverriddenByUserId { get; set; }

    [Column("RxHydrationOverriddenBy_inst_id")]
    [StringLength(30)]
    public string? RxHydrationOverriddenByInstId { get; set; }

    [Column("RxHydrationOverrideDatetimeID")]
    public long? RxHydrationOverrideDatetimeId { get; set; }

    [StringLength(1)]
    public string? RxAgentLevelStatus { get; set; }

    public int? RxAgentDisplayOrder { get; set; }

    [StringLength(15)]
    public string? RxConcentration { get; set; }

    [StringLength(30)]
    public string? RxImmunizationCode { get; set; }

    [Column("RxImmunizationPresentedDateID")]
    public long? RxImmunizationPresentedDateId { get; set; }

    [Column("RxImmunizationPublishedDateID")]
    public long? RxImmunizationPublishedDateId { get; set; }

    [Column("RxImmunizationEnteredBy_userid")]
    [StringLength(255)]
    public string? RxImmunizationEnteredByUserid { get; set; }

    [Column("RxImmunizationEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxImmunizationEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxImmunizationEnteredDatetime { get; set; }

    [Column("RxImmunizationLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxImmunizationLastModifiedByUserid { get; set; }

    [Column("RxImmunizationLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxImmunizationLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxImmunizationLastModifiedDatetime { get; set; }
}
