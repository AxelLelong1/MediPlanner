using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErxRefillRqstId", "RevisionNo")]
[Table("erx_refill_rqst_mh")]
public partial class ErxRefillRqstMh
{
    [Key]
    [Column("erx_refill_rqst_id")]
    public int ErxRefillRqstId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_key")]
    [StringLength(35)]
    public string? PtKey { get; set; }

    [Column("pt_last_name")]
    [StringLength(35)]
    public string? PtLastName { get; set; }

    [Column("pt_first_name")]
    [StringLength(35)]
    public string? PtFirstName { get; set; }

    [Column("pt_init")]
    [StringLength(35)]
    public string? PtInit { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("recvd_dt", TypeName = "datetime")]
    public DateTime? RecvdDt { get; set; }

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

    [Column("prov_first_name")]
    [StringLength(35)]
    public string? ProvFirstName { get; set; }

    [Column("prov_last_name")]
    [StringLength(35)]
    public string? ProvLastName { get; set; }

    [Column("prov_id")]
    [StringLength(35)]
    public string? ProvId { get; set; }

    [Column("prov_id_typ")]
    [StringLength(3)]
    public string? ProvIdTyp { get; set; }

    [Column("pharm_id")]
    [StringLength(7)]
    public string? PharmId { get; set; }

    [Column("prod_code")]
    [StringLength(35)]
    public string? ProdCode { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string? AgtName { get; set; }

    [Column("drug_desc")]
    [StringLength(110)]
    public string? DrugDesc { get; set; }

    [Column("drug_strength")]
    [StringLength(70)]
    public string? DrugStrength { get; set; }

    [Column("sig")]
    [StringLength(140)]
    public string? Sig { get; set; }

    [Column("qty_disp")]
    [StringLength(15)]
    public string? QtyDisp { get; set; }

    [Column("drug_dt_qual")]
    [StringLength(3)]
    public string? DrugDtQual { get; set; }

    [Column("drug_dt_prd")]
    [StringLength(8)]
    public string? DrugDtPrd { get; set; }

    [Column("drug_dt_prd_qual")]
    [StringLength(3)]
    public string? DrugDtPrdQual { get; set; }

    [Column("prod_sub_code")]
    public int? ProdSubCode { get; set; }

    [Column("refill_qty")]
    public int? RefillQty { get; set; }

    [Column("refill_rqst_resp_cd")]
    [StringLength(1)]
    public string? RefillRqstRespCd { get; set; }

    [Column("refill_resp_rsn_cd")]
    [StringLength(3)]
    public string? RefillRespRsnCd { get; set; }

    [Column("refill_resp_desc")]
    [StringLength(70)]
    public string? RefillRespDesc { get; set; }

    [Column("no_refills_rqsted")]
    public int? NoRefillsRqsted { get; set; }

    [Column("no_refills_appr")]
    public int? NoRefillsAppr { get; set; }

    [Column("placer_order_no")]
    [StringLength(35)]
    public string? PlacerOrderNo { get; set; }

    [Column("rx_ref_no")]
    [StringLength(35)]
    public string? RxRefNo { get; set; }

    [Column("ss_msg_id")]
    [StringLength(35)]
    public string? SsMsgId { get; set; }

    [Column("resp_prov_stkh_id")]
    [StringLength(20)]
    public string? RespProvStkhId { get; set; }

    [Column("resp_svsr_stkh_id")]
    [StringLength(20)]
    public string? RespSvsrStkhId { get; set; }

    [Column("phys_rev_rqd")]
    [StringLength(1)]
    public string? PhysRevRqd { get; set; }

    [Column("prc_ind")]
    [StringLength(1)]
    public string? PrcInd { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("sent_ind")]
    [StringLength(1)]
    public string? SentInd { get; set; }

    [Column("rcvd_ind")]
    [StringLength(1)]
    public string? RcvdInd { get; set; }

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

    [Column("rcvd_dt", TypeName = "datetime")]
    public DateTime? RcvdDt { get; set; }

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

    [Column("resp_placer_order_no")]
    [StringLength(35)]
    public string? RespPlacerOrderNo { get; set; }

    [Column("obs_note")]
    [StringLength(140)]
    public string? ObsNote { get; set; }

    [Column("epcs_sent_cd")]
    [StringLength(3)]
    public string? EpcsSentCd { get; set; }

    [Column("epcs_source_rx_id")]
    public int? EpcsSourceRxId { get; set; }

    [Column("rqst_relates_to_msg_id")]
    [StringLength(35)]
    public string? RqstRelatesToMsgId { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }
}
