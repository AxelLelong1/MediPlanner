using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_billing_run")]
public partial class IntfBillingRun
{
    [Key]
    [Column("intf_bill_run_seq_id")]
    [StringLength(12)]
    public string IntfBillRunSeqId { get; set; } = null!;

    [Column("bill_run_no")]
    public int BillRunNo { get; set; }

    [Column("bill_run_date", TypeName = "datetime")]
    public DateTime? BillRunDate { get; set; }

    [Column("sel_start_date", TypeName = "datetime")]
    public DateTime? SelStartDate { get; set; }

    [Column("total_trans")]
    public int? TotalTrans { get; set; }

    [Column("status_ind")]
    [StringLength(1)]
    public string? StatusInd { get; set; }

    [Column("override_date", TypeName = "datetime")]
    public DateTime? OverrideDate { get; set; }

    [Column("bill_run_desc")]
    [StringLength(255)]
    public string? BillRunDesc { get; set; }

    [Column("bill_sys_id")]
    [StringLength(20)]
    public string? BillSysId { get; set; }

    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string? BillSysInstId { get; set; }

    [Column("total_msg")]
    public int? TotalMsg { get; set; }

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

    [Column("trans_posting_date", TypeName = "datetime")]
    public DateTime? TransPostingDate { get; set; }

    [Column("varis_bill_run_seq_id")]
    public int? VarisBillRunSeqId { get; set; }

    [InverseProperty("IntfBillRunSeq")]
    public virtual ICollection<IntfBillingRunInfo> IntfBillingRunInfo { get; set; } = new List<IntfBillingRunInfo>();
}
