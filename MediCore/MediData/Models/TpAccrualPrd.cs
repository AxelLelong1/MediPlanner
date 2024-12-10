using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "ActivityId")]
[Table("tp_accrual_prd")]
public partial class TpAccrualPrd
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("activity_id")]
    public int ActivityId { get; set; }

    [Column("accrual_prd")]
    public int AccrualPrd { get; set; }

    [Column("expected_no")]
    public int? ExpectedNo { get; set; }

    [Column("actual_no")]
    public int? ActualNo { get; set; }

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

    [Column("accrual_typ")]
    public int? AccrualTyp { get; set; }

    [Column("accrual_asmt_typ")]
    public int? AccrualAsmtTyp { get; set; }

    [Column("ltr_id")]
    public int? LtrId { get; set; }
}
