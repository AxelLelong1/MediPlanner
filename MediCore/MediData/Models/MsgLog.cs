using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("msg_log")]
public partial class MsgLog
{
    [Key]
    [Column("msg_id")]
    public int MsgId { get; set; }

    [Column("msg_desc")]
    [StringLength(255)]
    public string? MsgDesc { get; set; }

    [Column("msg_criteria")]
    [StringLength(255)]
    public string? MsgCriteria { get; set; }

    [Column("rem_id")]
    [StringLength(30)]
    public string? RemId { get; set; }

    [Column("reminder_id")]
    public int? ReminderId { get; set; }

    [Column("authorized_stkh_id")]
    [StringLength(20)]
    public string? AuthorizedStkhId { get; set; }

    [Column("authorized_dt", TypeName = "datetime")]
    public DateTime? AuthorizedDt { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string? CompletedInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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
