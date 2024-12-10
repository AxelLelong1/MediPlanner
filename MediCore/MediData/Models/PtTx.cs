using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtTxId")]
[Table("pt_tx")]
[Index("PtId", "DateTpInit", "PlnTyp", Name = "nc1_pt_tx")]
public partial class PtTx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_tx_id")]
    public int PtTxId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("pln_typ")]
    public int? PlnTyp { get; set; }

    [Column("tx_desc")]
    [StringLength(255)]
    public string? TxDesc { get; set; }

    [Column("tx_modality")]
    public int? TxModality { get; set; }

    [Column("tx_start_date", TypeName = "datetime")]
    public DateTime TxStartDate { get; set; }

    [Column("tx_end_date", TypeName = "datetime")]
    public DateTime? TxEndDate { get; set; }

    [Column("internal_ind")]
    [StringLength(1)]
    public string? InternalInd { get; set; }

    [Column("ct_ind")]
    [StringLength(1)]
    public string? CtInd { get; set; }

    [Column("no_cycles")]
    public int? NoCycles { get; set; }

    [Column("cycle_length")]
    public int? CycleLength { get; set; }

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

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("start_cycle")]
    public int? StartCycle { get; set; }

    [Column("start_day")]
    public int? StartDay { get; set; }

    [Column("ack_tp_vers_no")]
    [StringLength(10)]
    public string? AckTpVersNo { get; set; }

    [Column("tx_line")]
    public int? TxLine { get; set; }

    [Column("tx_intent")]
    public int? TxIntent { get; set; }

    [Column("no_cycles_complete")]
    public int? NoCyclesComplete { get; set; }

    [Column("tx_start_date_cd")]
    public int? TxStartDateCd { get; set; }

    [Column("tx_end_date_cd")]
    public int? TxEndDateCd { get; set; }

    [Column("total_dose", TypeName = "numeric(11, 4)")]
    public decimal? TotalDose { get; set; }

    [Column("total_dose_unit")]
    public int? TotalDoseUnit { get; set; }

    [Column("tx_cmt")]
    public string? TxCmt { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("tx_use")]
    public int? TxUse { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("auto_end_ind")]
    [StringLength(1)]
    public string? AutoEndInd { get; set; }

    [Column("auto_end_by_userid")]
    [StringLength(255)]
    public string? AutoEndByUserid { get; set; }

    [Column("auto_end_by_user_inst_id")]
    [StringLength(30)]
    public string? AutoEndByUserInstId { get; set; }

    [Column("auto_end_tstamp", TypeName = "datetime")]
    public DateTime? AutoEndTstamp { get; set; }

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
}
