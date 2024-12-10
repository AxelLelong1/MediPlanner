using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("message_attribute")]
[Index("MessageContactId", Name = "nc1_message_attribute")]
public partial class MessageAttribute
{
    [Key]
    [Column("message_attribute_id")]
    public int MessageAttributeId { get; set; }

    [Column("message_id")]
    public int MessageId { get; set; }

    [Column("message_contact_id")]
    public int MessageContactId { get; set; }

    [Column("message_recipient_typ")]
    [StringLength(10)]
    public string? MessageRecipientTyp { get; set; }

    [Column("read_tstamp", TypeName = "datetime")]
    public DateTime? ReadTstamp { get; set; }

    [Column("read_ind")]
    [StringLength(1)]
    public string? ReadInd { get; set; }

    [Column("archived_ind")]
    [StringLength(1)]
    public string? ArchivedInd { get; set; }

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

    [Column("received_tstamp", TypeName = "datetime")]
    public DateTime? ReceivedTstamp { get; set; }

    [Column("message_status_desc")]
    [StringLength(30)]
    public string? MessageStatusDesc { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("MessageAttribute")]
    public virtual Message Message { get; set; } = null!;

    [ForeignKey("MessageContactId")]
    [InverseProperty("MessageAttribute")]
    public virtual MessageContact MessageContact { get; set; } = null!;
}
