using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TestId", "TestResultGroupId")]
[Table("test_result_group")]
[Index("PtVisitId", Name = "nc9_test_result_group")]
public partial class TestResultGroup
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("test_id")]
    public int TestId { get; set; }

    [Key]
    [Column("test_result_group_id")]
    public int TestResultGroupId { get; set; }

    [Column("group_seq_no")]
    public int GroupSeqNo { get; set; }

    [Column("fac_group_id")]
    public int? FacGroupId { get; set; }

    [Column("fac_group_name")]
    [StringLength(30)]
    public string? FacGroupName { get; set; }

    [Column("group_ind")]
    [StringLength(1)]
    public string? GroupInd { get; set; }

    [Column("fac_rqstn_order_no")]
    public int? FacRqstnOrderNo { get; set; }

    [Column("fac_rqstn_cat_desc")]
    [StringLength(40)]
    public string? FacRqstnCatDesc { get; set; }

    [Column("placer_order_no")]
    [StringLength(20)]
    public string? PlacerOrderNo { get; set; }

    [Column("group_order_no")]
    public int? GroupOrderNo { get; set; }

    [Column("perform_date_start", TypeName = "datetime")]
    public DateTime? PerformDateStart { get; set; }

    [Column("perform_date_end", TypeName = "datetime")]
    public DateTime? PerformDateEnd { get; set; }

    [Column("intf_filler_no")]
    [StringLength(75)]
    public string? IntfFillerNo { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

    [Column("spcmn_collc_ind")]
    [StringLength(1)]
    public string? SpcmnCollcInd { get; set; }

    [Column("order_appr_ind")]
    [StringLength(1)]
    public string? OrderApprInd { get; set; }

    [Column("cancel_ind")]
    [StringLength(1)]
    public string? CancelInd { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("result_appr_ind")]
    [StringLength(1)]
    public string? ResultApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("order_cmt_ind")]
    [StringLength(1)]
    public string? OrderCmtInd { get; set; }

    [Column("result_cmt_ind")]
    [StringLength(1)]
    public string? ResultCmtInd { get; set; }

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

    [Column("result_ind")]
    [StringLength(1)]
    public string? ResultInd { get; set; }

    [Column("producer_stkh_id")]
    [StringLength(20)]
    public string? ProducerStkhId { get; set; }

    [Column("extrnl_placer_order_no")]
    [StringLength(75)]
    public string? ExtrnlPlacerOrderNo { get; set; }

    [Column("spsr_stkh_id")]
    [StringLength(20)]
    public string? SpsrStkhId { get; set; }

    [Column("order_reason_desc")]
    [StringLength(255)]
    public string? OrderReasonDesc { get; set; }

    [Column("read_only_ind")]
    [StringLength(1)]
    public string? ReadOnlyInd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("spcmn_rcvd_date", TypeName = "datetime")]
    public DateTime? SpcmnRcvdDate { get; set; }

    [Column("results_rpt_date", TypeName = "datetime")]
    public DateTime? ResultsRptDate { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
