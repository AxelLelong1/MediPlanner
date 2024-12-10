using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("trf_cond_pt_hist")]
public partial class TrfCondPtHist
{
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("trf_tstamp", TypeName = "datetime")]
    public DateTime TrfTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("void_ind")]
    [StringLength(1)]
    public string? VoidInd { get; set; }
}
