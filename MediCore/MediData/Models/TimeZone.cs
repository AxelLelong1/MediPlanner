using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("time_zone")]
public partial class TimeZone
{
    [Key]
    [Column("time_zone_id", TypeName = "numeric(5, 0)")]
    public decimal TimeZoneId { get; set; }

    [Column("time_zone_desc")]
    [StringLength(50)]
    public string TimeZoneDesc { get; set; } = null!;

    [Column("dst_eff_date", TypeName = "datetime")]
    public DateTime? DstEffDate { get; set; }

    [Column("dst_exp_date", TypeName = "datetime")]
    public DateTime? DstExpDate { get; set; }

    [Column("dst_observed_ind")]
    [StringLength(1)]
    public string DstObservedInd { get; set; } = null!;

    [Column("gmt_offset_cd")]
    [StringLength(1)]
    public string? GmtOffsetCd { get; set; }

    [Column("gmt_offset_amt")]
    [StringLength(5)]
    public string? GmtOffsetAmt { get; set; }

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
