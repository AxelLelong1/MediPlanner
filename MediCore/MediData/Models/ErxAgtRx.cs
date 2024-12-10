using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ErxAgtRxId")]
[Table("erx_agt_rx")]
[Index("PtId", "ErxRefillRqstId", Name = "nc1_erx_agt_rx")]
[Index("PtId", "PtVisitId", "RxId", "ItemNo", "SentInd", "RsnNotSent", Name = "nc2_erx_agt_rx")]
[Index("RsnNotSent", "PtId", "PtVisitId", "RxId", "ItemNo", "SentInd", "ErxAgtRxId", Name = "nc3_erx_agt_rx")]
[Index("SentInd", "RsnNotSent", Name = "nc4_erx_agt_rx")]
public partial class ErxAgtRx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("erx_agt_rx_id")]
    public int ErxAgtRxId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("disp_qty")]
    [StringLength(15)]
    public string? DispQty { get; set; }

    [Column("erx_refill_rqst_id")]
    public int? ErxRefillRqstId { get; set; }

    [Column("dest_pharm_id")]
    [StringLength(7)]
    public string? DestPharmId { get; set; }

    [Column("stkh_name_id")]
    public int? StkhNameId { get; set; }

    [Column("sent_ind")]
    [StringLength(1)]
    public string? SentInd { get; set; }

    [Column("rsn_not_sent")]
    public int? RsnNotSent { get; set; }

    [Column("rcvd_ind")]
    [StringLength(1)]
    public string? RcvdInd { get; set; }

    [Column("rcvd_dt", TypeName = "datetime")]
    public DateTime? RcvdDt { get; set; }

    [Column("rx_ref_no")]
    [StringLength(35)]
    public string? RxRefNo { get; set; }

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

    [Column("sig")]
    [StringLength(140)]
    public string? Sig { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

    [Column("ndc_cd")]
    [StringLength(11)]
    public string? NdcCd { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("dea_class_fmt_cd")]
    [StringLength(10)]
    public string? DeaClassFmtCd { get; set; }

    [Column("nadean_cd")]
    [StringLength(9)]
    public string? NadeanCd { get; set; }

    [Column("epcs_source_rx_id")]
    public int? EpcsSourceRxId { get; set; }

    [Column("epcs_sent_cd")]
    [StringLength(3)]
    public string? EpcsSentCd { get; set; }

    [Column("ghb_reason")]
    public string? GhbReason { get; set; }
}
