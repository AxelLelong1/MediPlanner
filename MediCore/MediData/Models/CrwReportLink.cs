using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CrwReportLinkId")]
[Table("crw_report_link")]
public partial class CrwReportLink
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("crw_report_link_id")]
    public int CrwReportLinkId { get; set; }

    [Column("report_name")]
    [StringLength(40)]
    public string ReportName { get; set; } = null!;

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Column("ctrl_label")]
    [StringLength(30)]
    public string CtrlLabel { get; set; } = null!;

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
