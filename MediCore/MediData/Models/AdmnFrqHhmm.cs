using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AdmnFrqCd", "AdmnFrqX", "AdmnSeqNo")]
[Table("admn_frq_hhmm")]
public partial class AdmnFrqHhmm
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("admn_frq_cd")]
    public int AdmnFrqCd { get; set; }

    [Key]
    [Column("admn_frq_x")]
    public int AdmnFrqX { get; set; }

    [Key]
    [Column("admn_seq_no")]
    public int AdmnSeqNo { get; set; }

    [Column("admn_hhmm")]
    [StringLength(4)]
    public string? AdmnHhmm { get; set; }

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

    [ForeignKey("AdmnFrqCd")]
    [InverseProperty("AdmnFrqHhmm")]
    public virtual AdmnDoseFrqUnit AdmnFrqCdNavigation { get; set; } = null!;
}
