using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("reg_track")]
public partial class RegTrack
{
    [Key]
    [Column("reg_track_id")]
    public int RegTrackId { get; set; }

    [Column("reg_track_typ")]
    public int RegTrackTyp { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_ae_id")]
    public int? PtAeId { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("task_init_date", TypeName = "datetime")]
    public DateTime? TaskInitDate { get; set; }

    [Column("appr_ready_date", TypeName = "datetime")]
    public DateTime? ApprReadyDate { get; set; }

    [Column("pi_ready_sign_ind")]
    [StringLength(1)]
    public string? PiReadySignInd { get; set; }

    [Column("pi_sign_ind")]
    [StringLength(1)]
    public string? PiSignInd { get; set; }

    [Column("pi_sign_date", TypeName = "datetime")]
    public DateTime? PiSignDate { get; set; }

    [Column("track_cmt")]
    public string? TrackCmt { get; set; }

    [Column("report_ind")]
    [StringLength(1)]
    public string? ReportInd { get; set; }

    [Column("on_site_ind")]
    [StringLength(1)]
    public string? OnSiteInd { get; set; }

    [Column("cust_form_result_id")]
    public int? CustFormResultId { get; set; }

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
