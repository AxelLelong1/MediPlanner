using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimRxAdmin
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrRxAdminId")]
    public int CtrRxAdminId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    public int RxAdminRxId { get; set; }

    public int RxAdminItemNo { get; set; }

    public int RxAdminSequenceNo { get; set; }

    [StringLength(50)]
    public string? RxAdminAgentName { get; set; }

    public int? RxAdminDosageForm { get; set; }

    public int? RxAdminDoseLevel { get; set; }

    [Column("RxAdminDatetimeAdministeredID")]
    public long? RxAdminDatetimeAdministeredId { get; set; }

    public int? RxAdminAgentSequenceNo { get; set; }

    [StringLength(1)]
    public string? RxAdminAsAdvised { get; set; }

    [Column(TypeName = "decimal(11, 4)")]
    public decimal? RxAdminDose { get; set; }

    [StringLength(1)]
    public string? RxAdminDoseApproved { get; set; }

    public int? RxAdminHowRecorded { get; set; }

    [Column("RxAdminBy_userid")]
    [StringLength(255)]
    public string? RxAdminByUserid { get; set; }

    [Column("RxAdminBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminByInstId { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? RxAdminNoDosesTaken { get; set; }

    [Column("RxAdminExpectedDateTimeID")]
    public long? RxAdminExpectedDateTimeId { get; set; }

    [Column("RxAdminEnteredBy_userid")]
    [StringLength(255)]
    public string? RxAdminEnteredByUserid { get; set; }

    [Column("RxAdminEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RxAdminEnteredDatetime { get; set; }

    [Column("RxAdminLastModifiedby_userid")]
    [StringLength(255)]
    public string? RxAdminLastModifiedbyUserid { get; set; }

    [Column("RxAdminLastModifiedby_inst_id")]
    [StringLength(30)]
    public string? RxAdminLastModifiedbyInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxAdminLastModifiedDatetime { get; set; }

    public int? RxAdminAdminRoute { get; set; }

    public int? RxAdminAdminRouteUnit { get; set; }

    [StringLength(1)]
    public string? RxAdminValidEntry { get; set; }

    [StringLength(1)]
    public string? RxAdminCourseAdjustIndicator { get; set; }

    [Column("RxAdminStopDatetimeID")]
    public long? RxAdminStopDatetimeId { get; set; }

    [StringLength(1)]
    public string? RxAdminVarianceIndicator { get; set; }

    [StringLength(255)]
    public string? RxAdminErrorReason { get; set; }

    [Column("RxAdminDispenseVerifiedDatetimeID")]
    public long? RxAdminDispenseVerifiedDatetimeId { get; set; }

    [StringLength(1)]
    public string? RxAdminDispensedIndicator { get; set; }

    [StringLength(255)]
    public string? RxAdminCourseDescription { get; set; }

    [StringLength(1)]
    public string? RxAdminCorrected { get; set; }

    [StringLength(1)]
    public string? RxAdminAdhocEntry { get; set; }

    [StringLength(1)]
    public string? RxAdminNotDispensedIndicator { get; set; }

    public int? RxAdminDispensingLocation { get; set; }

    public int? RxAdminCycleNo { get; set; }

    public int? RxAdminCycleDay { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAdminWastage { get; set; }

    public int? RxAdminWastageUnit { get; set; }

    public int RxAdminRevisionNo { get; set; }

    [StringLength(30)]
    public string? RxAdminDrugLotNo { get; set; }

    public int? RxAdminManufacturer { get; set; }

    [StringLength(1)]
    public string RxAdminDisclosedFlag { get; set; } = null!;

    [StringLength(1)]
    public string? RxAdminRefusedIndicator { get; set; }

    [Column("RxAdminExpiryDateID")]
    public long? RxAdminExpiryDateId { get; set; }
}
