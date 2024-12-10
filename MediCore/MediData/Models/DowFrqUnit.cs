using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dow_frq_unit")]
public partial class DowFrqUnit
{
    [Key]
    [Column("dow_frq_unit")]
    public int DowFrqUnit1 { get; set; }

    [Column("admn_dose_frq_desc")]
    [StringLength(40)]
    public string AdmnDoseFrqDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("min_req_dur", TypeName = "decimal(11, 4)")]
    public decimal? MinReqDur { get; set; }

    [Column("min_req_dur_unit")]
    public int? MinReqDurUnit { get; set; }

    [Column("day_frq")]
    public int? DayFrq { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("DowFrqUnitNavigation")]
    public virtual ICollection<AdmnDow> AdmnDow { get; set; } = new List<AdmnDow>();
}
