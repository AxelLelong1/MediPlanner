using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("admn_dose_frq_unit")]
public partial class AdmnDoseFrqUnit
{
    [Key]
    [Column("admn_dose_frq_unit")]
    public int AdmnDoseFrqUnit1 { get; set; }

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

    [Column("min_req_dur")]
    public int? MinReqDur { get; set; }

    [Column("min_req_dur_unit")]
    public int? MinReqDurUnit { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("short_desc")]
    [StringLength(30)]
    public string? ShortDesc { get; set; }

    [Column("long_desc")]
    [StringLength(30)]
    public string? LongDesc { get; set; }

    [Column("no_of_admn_times")]
    public int? NoOfAdmnTimes { get; set; }

    [Column("time_specific_ind")]
    [StringLength(1)]
    public string? TimeSpecificInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [InverseProperty("AdmnFrqCdNavigation")]
    public virtual ICollection<AdmnFrqHhmm> AdmnFrqHhmm { get; set; } = new List<AdmnFrqHhmm>();
}
