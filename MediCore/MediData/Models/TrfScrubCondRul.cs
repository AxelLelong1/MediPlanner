using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScrubRule", "CondRule")]
[Table("trf_scrub_cond_rul")]
public partial class TrfScrubCondRul
{
    [Key]
    [Column("scrub_rule")]
    [StringLength(30)]
    public string ScrubRule { get; set; } = null!;

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

    [ForeignKey("CondRule")]
    [InverseProperty("TrfScrubCondRul")]
    public virtual TrfCondRule CondRuleNavigation { get; set; } = null!;

    [ForeignKey("ScrubRule")]
    [InverseProperty("TrfScrubCondRul")]
    public virtual TrfScrubRule ScrubRuleNavigation { get; set; } = null!;
}
