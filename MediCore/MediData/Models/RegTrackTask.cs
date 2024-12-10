using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("reg_track_task")]
public partial class RegTrackTask
{
    [Key]
    [Column("reg_track_task_id")]
    public int RegTrackTaskId { get; set; }

    [Column("reg_track_id")]
    public int RegTrackId { get; set; }

    [Column("reg_task_typ")]
    public int RegTaskTyp { get; set; }

    [Column("task_status_typ")]
    public int? TaskStatusTyp { get; set; }

    [Column("task_status_date", TypeName = "datetime")]
    public DateTime? TaskStatusDate { get; set; }

    [Column("task_req_ind")]
    [StringLength(1)]
    public string? TaskReqInd { get; set; }

    [Column("dcmnt_exist_ind")]
    [StringLength(1)]
    public string? DcmntExistInd { get; set; }

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
