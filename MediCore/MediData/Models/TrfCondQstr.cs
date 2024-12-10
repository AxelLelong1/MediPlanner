using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "CondRule", "QstrName")]
[Table("trf_cond_qstr")]
public partial class TrfCondQstr
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Key]
    [Column("qstr_name")]
    [StringLength(20)]
    public string QstrName { get; set; } = null!;

    [Key]
    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [ForeignKey("InstId, TrfDirctn, CondRule")]
    [InverseProperty("TrfCondQstr")]
    public virtual TrfCondRuleInst TrfCondRuleInst { get; set; } = null!;
}
