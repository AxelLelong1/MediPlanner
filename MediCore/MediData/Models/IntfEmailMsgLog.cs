using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_email_msg_log")]
public partial class IntfEmailMsgLog
{
    [Key]
    [Column("intf_email_msg_log_id")]
    public int IntfEmailMsgLogId { get; set; }

    [Column("intf_email_id")]
    public int IntfEmailId { get; set; }

    [Column("intf_email_msg_id")]
    [StringLength(10)]
    public string IntfEmailMsgId { get; set; } = null!;

    [Column("hl7_in_out")]
    [StringLength(1)]
    public string? Hl7InOut { get; set; }

    [Column("hl7_seq_no")]
    public int? Hl7SeqNo { get; set; }

    [Column("msg_log_id")]
    public int? MsgLogId { get; set; }

    [Column("process_ind")]
    [StringLength(1)]
    public string ProcessInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
