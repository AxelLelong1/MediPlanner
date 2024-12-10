using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Dbms", "DbmsMsgNo")]
[Table("app_msg_dbms")]
public partial class AppMsgDbms
{
    [Key]
    [Column("dbms")]
    [StringLength(10)]
    public string Dbms { get; set; } = null!;

    [Key]
    [Column("dbms_msg_no")]
    [StringLength(20)]
    public string DbmsMsgNo { get; set; } = null!;

    [Column("msg_no")]
    [StringLength(10)]
    public string? MsgNo { get; set; }

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
}
