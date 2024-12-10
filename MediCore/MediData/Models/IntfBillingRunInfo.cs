using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "BillRunNo")]
[Table("intf_billing_run_info")]
public partial class IntfBillingRunInfo
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("bill_run_no")]
    public int BillRunNo { get; set; }

    [Column("intf_bill_run_seq_id")]
    [StringLength(12)]
    public string IntfBillRunSeqId { get; set; } = null!;

    [Column("total_trans")]
    public int? TotalTrans { get; set; }

    [Column("batch_id")]
    [StringLength(12)]
    public string? BatchId { get; set; }

    [Column("bill_run_desc")]
    [StringLength(255)]
    public string? BillRunDesc { get; set; }

    [Column("batch_no")]
    [StringLength(20)]
    public string BatchNo { get; set; } = null!;

    [Column("override_batch_no")]
    [StringLength(20)]
    public string? OverrideBatchNo { get; set; }

    [Column("total_msg")]
    public int? TotalMsg { get; set; }

    [Column("hl7_out_seq_no")]
    public int? Hl7OutSeqNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("IntfBillRunSeqId")]
    [InverseProperty("IntfBillingRunInfo")]
    public virtual IntfBillingRun IntfBillRunSeq { get; set; } = null!;
}
