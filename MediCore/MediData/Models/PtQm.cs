using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "QmiId", "QmcpId")]
[Table("pt_qm")]
[Index("QmcpId", "PtId", "QmiId", Name = "nc1_pt_qm")]
public partial class PtQm
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("qmi_id")]
    public int QmiId { get; set; }

    [Key]
    [Column("qmcp_id")]
    public int QmcpId { get; set; }

    [Column("met_ind")]
    [StringLength(1)]
    public string? MetInd { get; set; }

    [Column("override_tstamp", TypeName = "datetime")]
    public DateTime? OverrideTstamp { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [Column("episode_count")]
    public int? EpisodeCount { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtQm")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("QmcpId")]
    [InverseProperty("PtQm")]
    public virtual QmCriteriaPart Qmcp { get; set; } = null!;

    [ForeignKey("QmiId")]
    [InverseProperty("PtQm")]
    public virtual QmInstance Qmi { get; set; } = null!;
}
