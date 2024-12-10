using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_date")]
public partial class CmteeDate
{
    [Key]
    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("meeting_typ")]
    public int? MeetingTyp { get; set; }

    [Column("mtg_datetime", TypeName = "datetime")]
    public DateTime? MtgDatetime { get; set; }

    [Column("mtg_dur", TypeName = "numeric(5, 2)")]
    public decimal? MtgDur { get; set; }

    [Column("mtg_room")]
    [StringLength(30)]
    public string? MtgRoom { get; set; }

    [Column("mtg_deadline", TypeName = "datetime")]
    public DateTime? MtgDeadline { get; set; }

    [Column("date_confirm_ind")]
    [StringLength(1)]
    public string? DateConfirmInd { get; set; }

    [Column("meeting_occur_ind")]
    [StringLength(1)]
    public string? MeetingOccurInd { get; set; }

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
