using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("financial")]
public partial class Financial
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("medicare_no")]
    [StringLength(30)]
    public string? MedicareNo { get; set; }

    [Column("medicade_no")]
    [StringLength(30)]
    public string? MedicadeNo { get; set; }

    [Column("appr_for_billing")]
    [StringLength(1)]
    public string? ApprForBilling { get; set; }

    [Column("pmt_system_id")]
    public int? PmtSystemId { get; set; }

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

    [Column("guar_ind")]
    [StringLength(1)]
    public string? GuarInd { get; set; }

    [Column("self_pay_ind")]
    [StringLength(1)]
    public string? SelfPayInd { get; set; }

    [Column("threshold_alert_ind")]
    [StringLength(1)]
    public string? ThresholdAlertInd { get; set; }

    [Column("precert_req_ind")]
    [StringLength(1)]
    public string? PrecertReqInd { get; set; }

    [Column("pt_bal", TypeName = "decimal(8, 2)")]
    public decimal? PtBal { get; set; }

    [Column("pt_last_pay_date", TypeName = "datetime")]
    public DateTime? PtLastPayDate { get; set; }

    [Column("ins_bal", TypeName = "decimal(8, 2)")]
    public decimal? InsBal { get; set; }

    [Column("ins_last_pay_date", TypeName = "datetime")]
    public DateTime? InsLastPayDate { get; set; }

    [Column("fin_cls_typ")]
    public int? FinClsTyp { get; set; }

    [Column("fin_cls_typ_inst_id")]
    [StringLength(30)]
    public string? FinClsTypInstId { get; set; }

    [ForeignKey("PmtSystemId")]
    [InverseProperty("Financial")]
    public virtual PmtSystem? PmtSystem { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("Financial")]
    public virtual Pt Pt { get; set; } = null!;
}
