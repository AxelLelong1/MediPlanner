using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_agenda")]
public partial class CmteeAgenda
{
    [Key]
    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("complete_ind")]
    [StringLength(1)]
    public string? CompleteInd { get; set; }

    [Column("agenda_cmt")]
    public string? AgendaCmt { get; set; }

    [Column("agenda_cmt_old")]
    public string? AgendaCmtOld { get; set; }

    [Column("agenda_ltr_id")]
    public int? AgendaLtrId { get; set; }

    [Column("memo_ltr_id")]
    public int? MemoLtrId { get; set; }

    [Column("rpt_cmtee_agenda_id")]
    public int? RptCmteeAgendaId { get; set; }

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
}
