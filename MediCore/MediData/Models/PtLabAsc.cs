using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("pt_lab_asc")]
[Index("PtId", "PtVisitId", "TestId", Name = "nc1_pt_lab_asc")]
[Index("AscNo", "AscDatetime", Name = "nc2_pt_lab_asc")]
public partial class PtLabAsc
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("test_id")]
    public int? TestId { get; set; }

    [Column("pt_lab_asc_seq_no")]
    [StringLength(15)]
    public string PtLabAscSeqNo { get; set; } = null!;

    [Column("asc_no")]
    [StringLength(15)]
    public string AscNo { get; set; } = null!;

    [Column("asc_datetime", TypeName = "datetime")]
    public DateTime AscDatetime { get; set; }

    [Column("pt_lab_asc_cmt")]
    public string? PtLabAscCmt { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("audtr_flag")]
    [StringLength(1)]
    public string? AudtrFlag { get; set; }
}
