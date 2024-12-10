using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId")]
[Table("rx")]
[Index("DateTimeSent", Name = "nc1_rx")]
[Index("OrdByInstId", "OrdByUserid", "Status", Name = "nc2_rx")]
[Index("DateTimeSent", "PharmApprUserid", "RxTyp", "Status", "ValidEntryInd", Name = "nc4_rx")]
[Index("Status", "ValidEntryInd", Name = "nc5_rx")]
public partial class Rx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string Status { get; set; } = null!;

    [Column("date_time_sent", TypeName = "datetime")]
    public DateTime? DateTimeSent { get; set; }

    [Column("pharmacy_id")]
    public int? PharmacyId { get; set; }

    [Column("rx_typ")]
    public int RxTyp { get; set; }

    [Column("copies_printed")]
    public int? CopiesPrinted { get; set; }

    [Column("rx_cmt")]
    public string? RxCmt { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("ord_by_userid")]
    [StringLength(255)]
    public string? OrdByUserid { get; set; }

    [Column("ord_by_inst_id")]
    [StringLength(30)]
    public string? OrdByInstId { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("int_prints")]
    public int? IntPrints { get; set; }

    [Column("pp_int_prints")]
    public int? PpIntPrints { get; set; }

    [Column("pp_ext_prints")]
    public int? PpExtPrints { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("interact_chk_ind")]
    [StringLength(1)]
    public string? InteractChkInd { get; set; }

    [Column("placer_order_no")]
    [StringLength(20)]
    public string? PlacerOrderNo { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string? CompletedInd { get; set; }

    [Column("bill_acct_id")]
    public int? BillAcctId { get; set; }

    [Column("dispensed_ind")]
    [StringLength(1)]
    public string? DispensedInd { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("tx_start_date", TypeName = "datetime")]
    public DateTime? TxStartDate { get; set; }

    [Column("not_dispensed_ind")]
    [StringLength(1)]
    public string? NotDispensedInd { get; set; }

    [Column("reorder_cmt_ind")]
    [StringLength(1)]
    public string? ReorderCmtInd { get; set; }

    [Column("reorder_review_ind")]
    [StringLength(1)]
    public string? ReorderReviewInd { get; set; }

    [Column("prompt_tx_start_date_ind")]
    [StringLength(1)]
    public string? PromptTxStartDateInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("no_cycles")]
    public int? NoCycles { get; set; }

    [Column("tx_line")]
    public int? TxLine { get; set; }

    [Column("rx_calc_audit_desc")]
    public string? RxCalcAuditDesc { get; set; }

    [Column("tx_intent")]
    public int? TxIntent { get; set; }

    [Column("tx_use")]
    public int? TxUse { get; set; }

    [Column("pharm_appr_userid")]
    [StringLength(255)]
    public string? PharmApprUserid { get; set; }

    [Column("pharm_appr_inst_id")]
    [StringLength(30)]
    public string? PharmApprInstId { get; set; }

    [Column("pharm_appr_tstamp", TypeName = "datetime")]
    public DateTime? PharmApprTstamp { get; set; }

    [Column("rx_print_userid")]
    [StringLength(255)]
    public string? RxPrintUserid { get; set; }

    [Column("rx_print_inst_id")]
    [StringLength(30)]
    public string? RxPrintInstId { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [Column("supervisor_userid")]
    [StringLength(255)]
    public string? SupervisorUserid { get; set; }

    [Column("supervisor_inst_id")]
    [StringLength(30)]
    public string? SupervisorInstId { get; set; }

    [Column("allergies_req_ind")]
    [StringLength(1)]
    public string? AllergiesReqInd { get; set; }

    [Column("allergies_doc_ind")]
    [StringLength(1)]
    public string? AllergiesDocInd { get; set; }

    [Column("meds_req_ind")]
    [StringLength(1)]
    public string? MedsReqInd { get; set; }

    [Column("meds_doc_ind")]
    [StringLength(1)]
    public string? MedsDocInd { get; set; }

    [Column("main_typ_cls_value_id")]
    public int? MainTypClsValueId { get; set; }

    [Column("sub_typ_cls_value_id")]
    public int? SubTypClsValueId { get; set; }

    [Column("evidence_lvl_pln_typ")]
    public int? EvidenceLvlPlnTyp { get; set; }

    [Column("pathway_exists_ind")]
    [StringLength(1)]
    public string? PathwayExistsInd { get; set; }

    public long? HospitalSer { get; set; }

    [ForeignKey("RxTyp")]
    [InverseProperty("Rx")]
    public virtual RxTyp RxTypNavigation { get; set; } = null!;
}
