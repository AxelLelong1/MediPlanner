using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgtName")]
[Table("max_cum_dose")]
public partial class MaxCumDose
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("max_cum_dose", TypeName = "numeric(11, 4)")]
    public decimal? MaxCumDose1 { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("max_bsa")]
    public int? MaxBsa { get; set; }

    [Column("min_dose", TypeName = "numeric(11, 4)")]
    public decimal? MinDose { get; set; }

    [Column("max_daily_dose", TypeName = "numeric(11, 4)")]
    public decimal? MaxDailyDose { get; set; }

    [Column("max_bolus", TypeName = "numeric(11, 4)")]
    public decimal? MaxBolus { get; set; }

    [Column("min_therapeutic", TypeName = "numeric(11, 4)")]
    public decimal? MinTherapeutic { get; set; }

    [Column("dose_limiting_flag")]
    [StringLength(1)]
    public string? DoseLimitingFlag { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }
}
