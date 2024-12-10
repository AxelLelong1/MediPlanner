using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "CompliancePrdId", "ComplianceItemId", "CompliancePgmId")]
[Table("provider_mu_sum")]
public partial class ProviderMuSum
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Key]
    [Column("compliance_item_id")]
    public int ComplianceItemId { get; set; }

    [Key]
    [Column("compliance_pgm_id")]
    public int CompliancePgmId { get; set; }

    [Column("sum_last_updated", TypeName = "datetime")]
    public DateTime? SumLastUpdated { get; set; }

    [Column("mu_pct", TypeName = "numeric(4, 3)")]
    public decimal? MuPct { get; set; }

    [Column("numerator", TypeName = "numeric(11, 2)")]
    public decimal? Numerator { get; set; }

    [Column("denominator", TypeName = "numeric(11, 2)")]
    public decimal? Denominator { get; set; }

    [Column("total_numerator", TypeName = "numeric(11, 2)")]
    public decimal? TotalNumerator { get; set; }

    [Column("total_denominator", TypeName = "numeric(11, 2)")]
    public decimal? TotalDenominator { get; set; }

    [Column("manual_numerator", TypeName = "numeric(11, 2)")]
    public decimal? ManualNumerator { get; set; }

    [Column("manual_denominator", TypeName = "numeric(11, 2)")]
    public decimal? ManualDenominator { get; set; }

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

    [ForeignKey("ComplianceItemId, CompliancePgmId")]
    [InverseProperty("ProviderMuSum")]
    public virtual ComplianceItem ComplianceItem { get; set; } = null!;
}
