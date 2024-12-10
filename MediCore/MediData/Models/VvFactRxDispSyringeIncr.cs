using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactRxDispSyringeIncr
{
    [Column("ctrsyringe_id")]
    public int CtrsyringeId { get; set; }

    [Column("ctrsyringe_seq_no")]
    public int CtrsyringeSeqNo { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal RxDispSyringeVolume { get; set; }

    public int RxDispSyringeVolumeUnit { get; set; }

    [Column("RxDispSyringeEnteredBy_userid")]
    [StringLength(255)]
    public string? RxDispSyringeEnteredByUserid { get; set; }

    [Column("RxDispSyringeEnteredBy_inst_id")]
    [StringLength(30)]
    public string? RxDispSyringeEnteredByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxDispSyringeEnteredDatetime { get; set; }

    [Column("RxDispSyringeLastModifiedBy_userid")]
    [StringLength(255)]
    public string? RxDispSyringeLastModifiedByUserid { get; set; }

    [Column("RxDispSyringeLastModifiedBy_inst_id")]
    [StringLength(30)]
    public string? RxDispSyringeLastModifiedByInstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RxDispSyringeLastModifiedDatetime { get; set; }
}
