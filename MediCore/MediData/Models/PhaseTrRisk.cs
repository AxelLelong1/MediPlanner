using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "TrRiskTyp")]
[Table("phase_tr_risk")]
public partial class PhaseTrRisk
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Key]
    [Column("tr_risk_typ")]
    public int TrRiskTyp { get; set; }

    [Column("tr_risk_score", TypeName = "numeric(11, 4)")]
    public decimal? TrRiskScore { get; set; }

    [Column("tr_risk_treat_ind")]
    [StringLength(1)]
    public string? TrRiskTreatInd { get; set; }

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

    [ForeignKey("TpName, TpVersNo, PhaseSeqNo")]
    [InverseProperty("PhaseTrRisk")]
    public virtual Phase Phase { get; set; } = null!;
}
