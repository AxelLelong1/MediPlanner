using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ComplianceItemId", "CompliancePgmId")]
[Table("compliance_item")]
public partial class ComplianceItem
{
    [Key]
    [Column("compliance_item_id")]
    public int ComplianceItemId { get; set; }

    [Key]
    [Column("compliance_pgm_id")]
    public int CompliancePgmId { get; set; }

    [Column("compliance_item")]
    [StringLength(60)]
    public string? ComplianceItem1 { get; set; }

    [Column("compliance_desc")]
    [StringLength(200)]
    public string? ComplianceDesc { get; set; }

    [Column("target_pct", TypeName = "numeric(5, 2)")]
    public decimal? TargetPct { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

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

    [Column("base_required_ind")]
    [StringLength(1)]
    public string? BaseRequiredInd { get; set; }

    [Column("performance_weight_pct")]
    public int? PerformanceWeightPct { get; set; }

    [Column("binary_ind")]
    [StringLength(1)]
    public string? BinaryInd { get; set; }

    [Column("bonus_ind")]
    [StringLength(1)]
    public string? BonusInd { get; set; }

    [Column("total_calc_method")]
    [StringLength(10)]
    public string? TotalCalcMethod { get; set; }

    [Column("exclusion_limit")]
    public int? ExclusionLimit { get; set; }

    [InverseProperty("ComplianceItem")]
    public virtual ICollection<ProviderMuSum> ProviderMuSum { get; set; } = new List<ProviderMuSum>();
}
