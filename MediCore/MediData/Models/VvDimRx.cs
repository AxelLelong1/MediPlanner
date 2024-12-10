using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimRx
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrrx_id")]
    public int CtrrxId { get; set; }

    [StringLength(1)]
    public string RxStatus { get; set; } = null!;

    [Column("RxDateID")]
    public long? RxDateId { get; set; }

    public int? RxPharmacy { get; set; }

    public int RxType { get; set; }

    public int? CopiesPrinted { get; set; }

    [StringLength(1024)]
    public string? RxComment { get; set; }

    public int? RxPhysicianOrderId { get; set; }

    [Column("RxEnteredBy_userid")]
    [StringLength(255)]
    public string? RxEnteredByUserid { get; set; }

    [Column("RxEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxEnteredTime { get; set; }

    [Column("RxLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxLastModifiedByUserid { get; set; }

    [Column("RxLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxLastModifiedTime { get; set; }

    [Column("RxOrderedBy_userid")]
    [StringLength(255)]
    public string? RxOrderedByUserid { get; set; }

    [Column("RxOrderedBy_inst_id")]
    [StringLength(30)]
    public string? RxOrderedByInstId { get; set; }

    [StringLength(1)]
    public string? RxValidEntry { get; set; }

    public int? RxInternalPrints { get; set; }

    public int? RxPickupInternalPrints { get; set; }

    public int? RxPickupExternalPrints { get; set; }

    [Column("RxApprovedTimeID")]
    public long? RxApprovedTimeId { get; set; }

    [StringLength(20)]
    public string? RxTpName { get; set; }

    [StringLength(10)]
    public string? RxTpVersion { get; set; }

    public int? RxTpPhase { get; set; }

    [Column("RxCycleNO")]
    public int? RxCycleNo { get; set; }

    public int? RxCycleDay { get; set; }

    [StringLength(1)]
    public string? RxInteractionCheckingIndicator { get; set; }

    [StringLength(20)]
    public string? RxPlacerOrderNo { get; set; }

    [StringLength(1)]
    public string? RxCompletedIndicator { get; set; }

    public int? RxBillAccount { get; set; }

    [StringLength(1)]
    public string? RxDispensedIndicator { get; set; }

    [Column("RxApprovedBy_userid")]
    [StringLength(255)]
    public string? RxApprovedByUserid { get; set; }

    [Column("RxApprovedBy_inst_id")]
    [StringLength(30)]
    public string? RxApprovedByInstId { get; set; }

    [Column("RxTreatmentStartDateID")]
    public long? RxTreatmentStartDateId { get; set; }

    [StringLength(1)]
    public string? RxNotDispensedIndicator { get; set; }

    [StringLength(1)]
    public string? RxReOrderCommentIndicator { get; set; }

    [StringLength(1)]
    public string? RxReorderReviewIndicator { get; set; }

    [StringLength(1)]
    public string? RxPromptTreatmentStartDateIndicator { get; set; }

    public int? RxNoCycles { get; set; }

    public int? RxLineOfTreatment { get; set; }

    [StringLength(1024)]
    public string? RxCalculationAuditDescription { get; set; }

    public int? RxTreatmentIntent { get; set; }

    public int? RxTreatmentUse { get; set; }

    [Column("RxPharmacyApprovedBy_userid")]
    [StringLength(255)]
    public string? RxPharmacyApprovedByUserid { get; set; }

    [Column("RxPharmacyApprovedBy_inst_id")]
    [StringLength(30)]
    public string? RxPharmacyApprovedByInstId { get; set; }

    [Column("RxPharmacyApprovedTimeID")]
    public long? RxPharmacyApprovedTimeId { get; set; }

    [Column("RxPrintedBy_userid")]
    [StringLength(255)]
    public string? RxPrintedByUserid { get; set; }

    [Column("RxPrintedBy_inst_id")]
    [StringLength(30)]
    public string? RxPrintedByInstId { get; set; }

    [StringLength(255)]
    public string? RxErrorReason { get; set; }

    [Column("RxSupervisingPhysician_userid")]
    [StringLength(255)]
    public string? RxSupervisingPhysicianUserid { get; set; }

    [Column("RxSupervisingPhysician_inst_id")]
    [StringLength(30)]
    public string? RxSupervisingPhysicianInstId { get; set; }
}
