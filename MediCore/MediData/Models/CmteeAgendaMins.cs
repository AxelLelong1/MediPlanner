using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_agenda_mins")]
public partial class CmteeAgendaMins
{
    [Key]
    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Column("chair_stkh_id")]
    [StringLength(20)]
    public string? ChairStkhId { get; set; }

    [Column("recorded_by_stkh_id")]
    [StringLength(20)]
    public string? RecordedByStkhId { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("adjourn_time", TypeName = "datetime")]
    public DateTime? AdjournTime { get; set; }

    [Column("mins_ltr_id")]
    public int? MinsLtrId { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("mins_appr_ind")]
    [StringLength(1)]
    public string? MinsApprInd { get; set; }

    [Column("prev_mins_appr_ind")]
    [StringLength(1)]
    public string? PrevMinsApprInd { get; set; }

    [Column("prev_mins_amend_desc")]
    public string? PrevMinsAmendDesc { get; set; }

    [Column("mins_business_txt")]
    public string? MinsBusinessTxt { get; set; }

    [Column("mins_review_txt")]
    public string? MinsReviewTxt { get; set; }

    [Column("dcmt_id")]
    public int? DcmtId { get; set; }

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
