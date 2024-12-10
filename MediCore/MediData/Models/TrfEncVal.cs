using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScrubRule", "DecdVal")]
[Table("trf_enc_val")]
public partial class TrfEncVal
{
    [Key]
    [Column("scrub_rule")]
    [StringLength(30)]
    public string ScrubRule { get; set; } = null!;

    [Key]
    [Column("decd_val")]
    [StringLength(100)]
    public string DecdVal { get; set; } = null!;

    [Column("enc_val")]
    [StringLength(255)]
    public string EncVal { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [ForeignKey("ScrubRule")]
    [InverseProperty("TrfEncVal")]
    public virtual TrfScrubRule ScrubRuleNavigation { get; set; } = null!;
}
