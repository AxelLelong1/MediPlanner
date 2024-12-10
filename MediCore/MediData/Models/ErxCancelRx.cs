using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "ErxCancelRxId")]
[Table("erx_cancel_rx")]
[Index("PtId", "ErxEventId", "ErxMsgTyp", Name = "nc1_erx_cancel_rx")]
public partial class ErxCancelRx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("erx_cancel_rx_id")]
    public int ErxCancelRxId { get; set; }

    [Column("erx_msg_typ")]
    [StringLength(6)]
    public string ErxMsgTyp { get; set; } = null!;

    [Column("erx_event_id")]
    public int ErxEventId { get; set; }

    [Column("sent_ind")]
    [StringLength(1)]
    public string SentInd { get; set; } = null!;

    [Column("sent_dt", TypeName = "datetime")]
    public DateTime? SentDt { get; set; }

    [Column("rcvd_ind")]
    [StringLength(1)]
    public string? RcvdInd { get; set; }

    [Column("rcvd_dt", TypeName = "datetime")]
    public DateTime? RcvdDt { get; set; }

    [Column("dest_pharm_id")]
    [StringLength(7)]
    public string DestPharmId { get; set; } = null!;

    [Column("resp_typ")]
    [StringLength(1)]
    public string? RespTyp { get; set; }

    [Column("resp_note")]
    [StringLength(70)]
    public string? RespNote { get; set; }

    [Column("resp_ref_no")]
    [StringLength(35)]
    public string? RespRefNo { get; set; }

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("cancel_userid")]
    [StringLength(255)]
    public string? CancelUserid { get; set; }

    [Column("cancel_inst_id")]
    [StringLength(30)]
    public string? CancelInstId { get; set; }

    [Column("disregard_ind")]
    [StringLength(1)]
    public string? DisregardInd { get; set; }

    [Column("resp_rcvd_dt", TypeName = "datetime")]
    public DateTime? RespRcvdDt { get; set; }

    [Column("resp_msg_id")]
    [StringLength(35)]
    public string? RespMsgId { get; set; }

    [Column("resp_relates_to_msg_id")]
    [StringLength(35)]
    public string? RespRelatesToMsgId { get; set; }

    [InverseProperty("ErxCancelRx")]
    public virtual ICollection<ErxCancelRxRespRsn> ErxCancelRxRespRsn { get; set; } = new List<ErxCancelRxRespRsn>();
}
