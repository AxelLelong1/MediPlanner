using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactRxAdminAgtLevelIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrrx_id")]
    public int CtrrxId { get; set; }

    [Column("ctritem_no")]
    public int CtritemNo { get; set; }

    [Column("ctragt_level_id")]
    public int CtragtLevelId { get; set; }

    public int? RxAdminAgtLevelSequence { get; set; }

    [Column("RxAdminAgtStartDateID")]
    public long? RxAdminAgtStartDateId { get; set; }

    [Column("RxAdminAgtEndDateID")]
    public long? RxAdminAgtEndDateId { get; set; }

    public int? RxAdminAgtNoDosesTaken { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAdminAgtDose { get; set; }

    public int? RxAdminAgtDoseUnit { get; set; }

    public int? RxAdminAgtHowRecorded { get; set; }

    [StringLength(1)]
    public string? RxAdminAgtValidEntry { get; set; }

    [Column("RxAdminAgtApprovedDatetimeID")]
    public long? RxAdminAgtApprovedDatetimeId { get; set; }

    [Column("RxAdminAgtApprovedBy_userid")]
    [StringLength(255)]
    public string? RxAdminAgtApprovedByUserid { get; set; }

    [Column("RxAdminAgtApprovedBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminAgtApprovedByInstId { get; set; }

    [Column("RxAdminAgtEnteredby_userid")]
    [StringLength(255)]
    public string? RxAdminAgtEnteredbyUserid { get; set; }

    [Column("RxAdminAgtEnteredby_inst_id")]
    [StringLength(30)]
    public string? RxAdminAgtEnteredbyInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxAdminAgtEnteredDatetime { get; set; }

    [Column("RxAdminAgtLastModifiedby_userid")]
    [StringLength(255)]
    public string? RxAdminAgtLastModifiedbyUserid { get; set; }

    [Column("RxAdminAgtLastModifiedby_inst_id")]
    [StringLength(30)]
    public string? RxAdminAgtLastModifiedbyInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxAdminAgtLastModifiedDatetime { get; set; }

    [StringLength(255)]
    public string? RxAdminAgtErrorReason { get; set; }
}
