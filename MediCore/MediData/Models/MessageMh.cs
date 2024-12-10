using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MessageId", "RevisionNo")]
[Table("message_mh")]
public partial class MessageMh
{
    [Key]
    [Column("message_id")]
    public int MessageId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("external_message_id")]
    public int? ExternalMessageId { get; set; }

    [Column("thread_id")]
    [StringLength(64)]
    public string ThreadId { get; set; } = null!;

    [Column("in_reply_to_message_id")]
    public int? InReplyToMessageId { get; set; }

    [Column("created_tstamp", TypeName = "datetime")]
    public DateTime? CreatedTstamp { get; set; }

    [Column("delivered_tstamp", TypeName = "datetime")]
    public DateTime? DeliveredTstamp { get; set; }

    [Column("message_subject")]
    [StringLength(200)]
    public string? MessageSubject { get; set; }

    [Column("message_content")]
    public string? MessageContent { get; set; }

    [Column("message_typ")]
    [StringLength(20)]
    public string? MessageTyp { get; set; }

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

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("external_message_uid")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ExternalMessageUid { get; set; }
}
