﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "OutcomeId", "EvalId")]
[Table("tp_eval")]
public partial class TpEval
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Key]
    [Column("outcome_id")]
    public int OutcomeId { get; set; }

    [Key]
    [Column("eval_id")]
    public int EvalId { get; set; }

    [Column("tperiod_id")]
    public int TperiodId { get; set; }

    [Column("offset_time")]
    [StringLength(4)]
    public string? OffsetTime { get; set; }

    [Column("offset_desc")]
    [StringLength(40)]
    public string? OffsetDesc { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("TpName, TpVersNo, OutcomeId")]
    [InverseProperty("TpEval")]
    public virtual TpOutcome TpOutcome { get; set; } = null!;
}
