using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErxRxFillId", "RevisionNo")]
[Table("erx_rx_fill_mh")]
public partial class ErxRxFillMh
{
    [Key]
    [Column("erx_rx_fill_id")]
    public int ErxRxFillId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("rcvd_dt", TypeName = "datetime")]
    public DateTime RcvdDt { get; set; }

    [Column("fill_status_cd")]
    [StringLength(2)]
    public string? FillStatusCd { get; set; }

    [Column("fill_status_desc")]
    [StringLength(15)]
    public string? FillStatusDesc { get; set; }

    [Column("fill_status_note")]
    [StringLength(70)]
    public string? FillStatusNote { get; set; }

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

    [Column("pharm_id")]
    [StringLength(7)]
    public string PharmId { get; set; } = null!;

    [Column("placer_order_no")]
    [StringLength(35)]
    public string? PlacerOrderNo { get; set; }

    [Column("rx_ref_no")]
    [StringLength(35)]
    public string? RxRefNo { get; set; }

    [Column("msg_id")]
    [StringLength(35)]
    public string? MsgId { get; set; }

    [Column("relates_to_msg_id")]
    [StringLength(35)]
    public string? RelatesToMsgId { get; set; }

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

    [Column("erx_msg_typ")]
    [StringLength(8)]
    public string? ErxMsgTyp { get; set; }

    [Column("erx_event_id")]
    public int? ErxEventId { get; set; }
}
