using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("message_contact")]
public partial class MessageContact
{
    [Key]
    [Column("message_contact_id")]
    public int MessageContactId { get; set; }

    [Column("internal_contact_id")]
    [StringLength(20)]
    public string? InternalContactId { get; set; }

    [Column("message_contact_typ")]
    public int MessageContactTyp { get; set; }

    [Column("display_name")]
    [StringLength(100)]
    public string? DisplayName { get; set; }

    [Column("direct_address")]
    [StringLength(255)]
    public string? DirectAddress { get; set; }

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

    [Column("direct_smtp_address")]
    [StringLength(255)]
    public string? DirectSmtpAddress { get; set; }

    [InverseProperty("MessageContact")]
    public virtual ICollection<MessageAttribute> MessageAttribute { get; set; } = new List<MessageAttribute>();
}
