using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "MsgLogId")]
[Table("intf_msg_log")]
[Index("MsgId", Name = "nc1_intf_msg_log")]
[Index("TransLogTstamp", Name = "nc2_intf_msg_log")]
[Index("MsgNo", Name = "nc3_intf_msg_log")]
public partial class IntfMsgLog
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("msg_log_id")]
    public int MsgLogId { get; set; }

    [Column("msg_id")]
    public int? MsgId { get; set; }

    [Column("msg_log_typ")]
    [StringLength(3)]
    public string? MsgLogTyp { get; set; }

    [Column("msg_log_txt")]
    [StringLength(255)]
    public string? MsgLogTxt { get; set; }

    [Column("msg_no")]
    [StringLength(10)]
    public string? MsgNo { get; set; }

    [Column("msg_txt")]
    public string? MsgTxt { get; set; }

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

    [Column("msg_sql_txt")]
    public string? MsgSqlTxt { get; set; }

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string? IntfEngineId { get; set; }

    [Column("intf_comm_id")]
    [StringLength(10)]
    public string? IntfCommId { get; set; }

    [Column("severity")]
    public int? Severity { get; set; }

    [Column("msg_sent_ind")]
    [StringLength(1)]
    public string? MsgSentInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
