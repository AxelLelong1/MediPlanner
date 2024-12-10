using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "TpGrantId")]
[Table("tp_grant_item")]
public partial class TpGrantItem
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
    [Column("tp_grant_id")]
    public int TpGrantId { get; set; }

    [Column("tp_financial_id")]
    public int? TpFinancialId { get; set; }

    [Column("grant_period")]
    public int? GrantPeriod { get; set; }

    [Column("grant_start_date", TypeName = "datetime")]
    public DateTime? GrantStartDate { get; set; }

    [Column("grant_end_date", TypeName = "datetime")]
    public DateTime? GrantEndDate { get; set; }

    [Column("direct_grant_amount", TypeName = "numeric(11, 2)")]
    public decimal? DirectGrantAmount { get; set; }

    [Column("indirect_grant_amount", TypeName = "numeric(11, 2)")]
    public decimal? IndirectGrantAmount { get; set; }

    [Column("total_grant_amount", TypeName = "numeric(18, 2)")]
    public decimal? TotalGrantAmount { get; set; }

    [Column("grant_cmt")]
    [StringLength(255)]
    public string? GrantCmt { get; set; }

    [Column("rpt_include_ind")]
    [StringLength(1)]
    public string? RptIncludeInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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
}
