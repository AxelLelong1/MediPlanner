using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ReconciliationHxId")]
[Table("pt_reconciliation_hx")]
public partial class PtReconciliationHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("reconciliation_hx_id")]
    public int ReconciliationHxId { get; set; }

    [Column("reconciliation_date", TypeName = "datetime")]
    public DateTime? ReconciliationDate { get; set; }

    [Column("manual_update_ind")]
    [StringLength(1)]
    public string? ManualUpdateInd { get; set; }

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

    [Column("complete_recon_ind")]
    [StringLength(1)]
    public string? CompleteReconInd { get; set; }

    [Column("reconciliation_type")]
    [StringLength(20)]
    public string ReconciliationType { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtReconciliationHx")]
    public virtual Pt Pt { get; set; } = null!;
}
