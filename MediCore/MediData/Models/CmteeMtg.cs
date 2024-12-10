using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_mtg")]
public partial class CmteeMtg
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("mtg_freq_cd")]
    [StringLength(1)]
    public string? MtgFreqCd { get; set; }

    [Column("mtg_recur")]
    public int? MtgRecur { get; set; }

    [Column("mtg_dur", TypeName = "numeric(5, 2)")]
    public decimal? MtgDur { get; set; }

    [Column("mtg_mon_ind")]
    [StringLength(1)]
    public string? MtgMonInd { get; set; }

    [Column("mtg_tues_ind")]
    [StringLength(1)]
    public string? MtgTuesInd { get; set; }

    [Column("mtg_wed_ind")]
    [StringLength(1)]
    public string? MtgWedInd { get; set; }

    [Column("mtg_thur_ind")]
    [StringLength(1)]
    public string? MtgThurInd { get; set; }

    [Column("mtg_fri_ind")]
    [StringLength(1)]
    public string? MtgFriInd { get; set; }

    [Column("mtg_sat_ind")]
    [StringLength(1)]
    public string? MtgSatInd { get; set; }

    [Column("mtg_sun_ind")]
    [StringLength(1)]
    public string? MtgSunInd { get; set; }

    [Column("mtg_every_mth")]
    public int? MtgEveryMth { get; set; }

    [Column("mtg_week_of_month")]
    [StringLength(10)]
    public string? MtgWeekOfMonth { get; set; }

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
