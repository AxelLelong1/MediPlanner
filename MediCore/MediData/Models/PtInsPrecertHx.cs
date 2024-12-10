using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FinancialInsId", "InsPrecertId", "InsPrecertHxId")]
[Table("pt_ins_precert_hx")]
public partial class PtInsPrecertHx
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
    [Column("ins_precert_hx_id")]
    public int InsPrecertHxId { get; set; }

    [Column("precert_no")]
    [StringLength(20)]
    public string? PrecertNo { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("start_tstamp", TypeName = "datetime")]
    public DateTime? StartTstamp { get; set; }

    [Column("end_tstamp", TypeName = "datetime")]
    public DateTime? EndTstamp { get; set; }

    [Column("precert_chg_cmt")]
    public string? PrecertChgCmt { get; set; }

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
