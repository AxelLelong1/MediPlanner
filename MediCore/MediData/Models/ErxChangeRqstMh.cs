using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErxChangeRqstId", "RevisionNo")]
[Table("erx_change_rqst_mh")]
public partial class ErxChangeRqstMh
{
    [Key]
    [Column("erx_change_rqst_id")]
    public int ErxChangeRqstId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("erx_change_rqst_typ")]
    [StringLength(3)]
    public string? ErxChangeRqstTyp { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("rqst_rcvd_dt", TypeName = "datetime")]
    public DateTime RqstRcvdDt { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("rx_id")]
    public int? RxId { get; set; }

    [Column("item_no")]
    public int? ItemNo { get; set; }

    [Column("prov_stkh_id")]
    [StringLength(20)]
    public string? ProvStkhId { get; set; }

    [Column("svsr_stkh_id")]
    [StringLength(20)]
    public string? SvsrStkhId { get; set; }

    [Column("pharm_id")]
    [StringLength(7)]
    public string PharmId { get; set; } = null!;

    [Column("resp_cd")]
    [StringLength(1)]
    public string? RespCd { get; set; }

    [Column("resp_rsn_cd")]
    [StringLength(3)]
    public string? RespRsnCd { get; set; }

    [Column("resp_note")]
    [StringLength(70)]
    public string? RespNote { get; set; }

    [Column("placer_order_no")]
    [StringLength(35)]
    public string? PlacerOrderNo { get; set; }

    [Column("resp_placer_order_no")]
    [StringLength(35)]
    public string? RespPlacerOrderNo { get; set; }

    [Column("rx_ref_no")]
    [StringLength(35)]
    public string? RxRefNo { get; set; }

    [Column("obs_note")]
    [StringLength(140)]
    public string? ObsNote { get; set; }

    [Column("rqst_msg_id")]
    [StringLength(35)]
    public string? RqstMsgId { get; set; }

    [Column("rqst_relates_to_msg_id")]
    [StringLength(35)]
    public string? RqstRelatesToMsgId { get; set; }

    [Column("resp_prov_stkh_id")]
    [StringLength(20)]
    public string? RespProvStkhId { get; set; }

    [Column("resp_svsr_stkh_id")]
    [StringLength(20)]
    public string? RespSvsrStkhId { get; set; }

    [Column("disregard_ind")]
    [StringLength(1)]
    public string? DisregardInd { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("sent_ind")]
    [StringLength(1)]
    public string? SentInd { get; set; }

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

    [Column("resp_rcvd_ind")]
    [StringLength(1)]
    public string? RespRcvdInd { get; set; }

    [Column("resp_rcvd_dt", TypeName = "datetime")]
    public DateTime? RespRcvdDt { get; set; }

    [Column("epcs_sent_cd")]
    [StringLength(3)]
    public string? EpcsSentCd { get; set; }

    [Column("epcs_source_rx_id")]
    public int? EpcsSourceRxId { get; set; }

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

    [Column("change_to_erx_drug_id")]
    public int? ChangeToErxDrugId { get; set; }
}
