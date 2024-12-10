using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("trf_cond_rule")]
public partial class TrfCondRule
{
    [Key]
    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("operator")]
    [StringLength(2)]
    public string Operator { get; set; } = null!;

    [Column("ovride_typ")]
    [StringLength(10)]
    public string OvrideTyp { get; set; } = null!;

    [Column("ovride_val")]
    [StringLength(255)]
    public string? OvrideVal { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [InverseProperty("CondRuleNavigation")]
    public virtual ICollection<TrfCondRuleInst> TrfCondRuleInst { get; set; } = new List<TrfCondRuleInst>();

    [InverseProperty("CondRuleNavigation")]
    public virtual ICollection<TrfScrubCondRul> TrfScrubCondRul { get; set; } = new List<TrfScrubCondRul>();
}
