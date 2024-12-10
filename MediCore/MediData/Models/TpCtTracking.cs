using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpCtTrackingId", "TpName", "TpVersNo")]
[Table("tp_ct_tracking")]
public partial class TpCtTracking
{
    [Key]
    [Column("tp_ct_tracking_id")]
    public int TpCtTrackingId { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("reg_docs_typ")]
    public int? RegDocsTyp { get; set; }

    [Column("budget_typ")]
    public int? BudgetTyp { get; set; }

    [Column("contract_typ")]
    public int? ContractTyp { get; set; }

    [Column("form1_typ")]
    public int? Form1Typ { get; set; }

    [Column("form1_sign_typ")]
    public int? Form1SignTyp { get; set; }

    [Column("icf_typ")]
    public int? IcfTyp { get; set; }

    [Column("plso_typ")]
    public int? PlsoTyp { get; set; }

    [Column("instruments_typ")]
    public int? InstrumentsTyp { get; set; }

    [Column("work_file_typ")]
    public int? WorkFileTyp { get; set; }

    [Column("next_step_typ")]
    public int? NextStepTyp { get; set; }

    [Column("process_appr_date", TypeName = "datetime")]
    public DateTime? ProcessApprDate { get; set; }

    [Column("rsc_review_typ")]
    public int? RscReviewTyp { get; set; }

    [Column("ibc_review_typ")]
    public int? IbcReviewTyp { get; set; }

    [Column("protocol_1572_typ")]
    public int? Protocol1572Typ { get; set; }

    [Column("fin_disclosure_typ")]
    public int? FinDisclosureTyp { get; set; }

    [Column("priority_list_typ")]
    public int? PriorityListTyp { get; set; }

    [Column("accrual_proj_amt")]
    public int? AccrualProjAmt { get; set; }

    [Column("accrual_est_annual_amt")]
    public int? AccrualEstAnnualAmt { get; set; }

    [Column("managed_by_typ")]
    public int? ManagedByTyp { get; set; }

    [Column("show_on_web_ind")]
    public int? ShowOnWebInd { get; set; }

    [Column("res_review_status_typ")]
    public int? ResReviewStatusTyp { get; set; }

    [Column("protocol_received_status_typ")]
    public int? ProtocolReceivedStatusTyp { get; set; }

    [Column("study_mat_offsite_ind")]
    public int? StudyMatOffsiteInd { get; set; }

    [Column("study_mat_offsite_dt", TypeName = "datetime")]
    public DateTime? StudyMatOffsiteDt { get; set; }

    [Column("study_mat_offsite_loc")]
    [StringLength(55)]
    public string? StudyMatOffsiteLoc { get; set; }

    [Column("study_mat_offsite_box")]
    [StringLength(10)]
    public string? StudyMatOffsiteBox { get; set; }

    [Column("pt_mat_offsite_ind")]
    public int? PtMatOffsiteInd { get; set; }

    [Column("pt_mat_offsite_dt", TypeName = "datetime")]
    public DateTime? PtMatOffsiteDt { get; set; }

    [Column("pt_mat_offsite_loc")]
    [StringLength(55)]
    public string? PtMatOffsiteLoc { get; set; }

    [Column("pt_mat_offsite_box")]
    [StringLength(10)]
    public string? PtMatOffsiteBox { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

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
