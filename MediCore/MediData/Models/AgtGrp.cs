using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_grp")]
public partial class AgtGrp
{
    [Key]
    [Column("agt_grp_id")]
    public int AgtGrpId { get; set; }

    [Column("agt_grp_desc")]
    [StringLength(255)]
    public string AgtGrpDesc { get; set; } = null!;

    [Column("expiry_dur")]
    public int ExpiryDur { get; set; }

    [Column("expiry_dur_unit")]
    public int ExpiryDurUnit { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("pn_template_id")]
    public int? PnTemplateId { get; set; }

    [Column("pn_inst_id")]
    [StringLength(30)]
    public string? PnInstId { get; set; }

    [ForeignKey("PnInstId, PnTemplateId")]
    [InverseProperty("AgtGrp")]
    public virtual PnTemplate? PnTemplate { get; set; }
}
