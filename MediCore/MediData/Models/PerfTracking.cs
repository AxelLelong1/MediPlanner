using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("perf_tracking")]
public partial class PerfTracking
{
    [Key]
    [Column("perf_tracking_id")]
    public int PerfTrackingId { get; set; }

    [Column("tracking_start_tstamp", TypeName = "datetime")]
    public DateTime? TrackingStartTstamp { get; set; }

    [Column("tracking_end_tstamp", TypeName = "datetime")]
    public DateTime? TrackingEndTstamp { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pk_id_txt")]
    [StringLength(256)]
    public string? PkIdTxt { get; set; }

    [Column("perf_tracking_typ_id")]
    public int? PerfTrackingTypId { get; set; }

    [Column("tracking_typ_error_txt")]
    [StringLength(256)]
    public string? TrackingTypErrorTxt { get; set; }

    [Column("workstation_name")]
    [StringLength(256)]
    public string? WorkstationName { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("app_vers_no")]
    [StringLength(10)]
    public string? AppVersNo { get; set; }

    [Column("app_build_no")]
    [StringLength(10)]
    public string? AppBuildNo { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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
}
