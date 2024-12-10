using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FinancialInsId", "InsPrecertId", "InsPrecertDetId", "InsPrecertDetHxId")]
[Table("pt_ins_precert_det_hx")]
public partial class PtInsPrecertDetHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("financial_ins_id")]
    public int FinancialInsId { get; set; }

    [Key]
    [Column("ins_precert_id")]
    public int InsPrecertId { get; set; }

    [Key]
    [Column("ins_precert_det_id")]
    public int InsPrecertDetId { get; set; }

    [Key]
    [Column("ins_precert_det_hx_id")]
    public int InsPrecertDetHxId { get; set; }

    [Column("visit_date", TypeName = "datetime")]
    public DateTime? VisitDate { get; set; }

    [Column("auto_adjust_ind")]
    [StringLength(1)]
    public string? AutoAdjustInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("new_covered_amt")]
    public int? NewCoveredAmt { get; set; }

    [Column("new_used_amt")]
    public int? NewUsedAmt { get; set; }

    [Column("covered_amt_chg")]
    public int? CoveredAmtChg { get; set; }

    [Column("used_amt_chg")]
    public int? UsedAmtChg { get; set; }

    [Column("precert_det_chg_cmt")]
    public string? PrecertDetChgCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
