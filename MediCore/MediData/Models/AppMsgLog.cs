using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AppMsgLogId")]
[Table("app_msg_log")]
public partial class AppMsgLog
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("app_msg_log_id")]
    public int AppMsgLogId { get; set; }

    [Column("msg_no")]
    [StringLength(10)]
    public string MsgNo { get; set; } = null!;

    [Column("msg_txt")]
    public string MsgTxt { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("sql_code")]
    public int? SqlCode { get; set; }

    [Column("sql_error_txt")]
    public string? SqlErrorTxt { get; set; }
}
