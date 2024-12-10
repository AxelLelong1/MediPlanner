using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactRxAdminDetailIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctradmn_id")]
    public int CtradmnId { get; set; }

    [Column("ctradmn_detail_id")]
    public int CtradmnDetailId { get; set; }

    [Column("RxAdminDetailDatetimeID")]
    public long? RxAdminDetailDatetimeId { get; set; }

    [StringLength(5)]
    public string RxAdminDetailType { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? RxAdminDetailDoseTaken { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? RxAdminDetailDose { get; set; }

    [Column("RxAdminDetailApprDatetimeID")]
    public long? RxAdminDetailApprDatetimeId { get; set; }

    [Column("RxAdminDetailApprovedBy_userid")]
    [StringLength(255)]
    public string? RxAdminDetailApprovedByUserid { get; set; }

    [Column("RxAdminDetailApprovedBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminDetailApprovedByInstId { get; set; }

    [StringLength(1)]
    public string? RxAdminDetailValidEntry { get; set; }

    [Column("RxAdminDetailEnteredBy_userid")]
    [StringLength(255)]
    public string? RxAdminDetailEnteredByUserid { get; set; }

    [Column("RxAdminDetailEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminDetailEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RxAdminDetailEnteredDatetime { get; set; }

    [Column("RxAdminDetailLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxAdminDetailLastModifiedByUserid { get; set; }

    [Column("RxAdminDetailLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxAdminDetailLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxAdminDetailLastModifiedDatetime { get; set; }
}
