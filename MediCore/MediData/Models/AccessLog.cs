using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("access_log")]
[Index("TransLogInstId", "TransLogUserid", "TransLogTstamp", Name = "nc1_access_log")]
[Index("TransLogTstamp", Name = "nc2_access_log")]
public partial class AccessLog
{
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("app_name")]
    [StringLength(10)]
    public string AppName { get; set; } = null!;

    [Column("access_cd")]
    public int AccessCd { get; set; }

    [Column("access_cmt")]
    [StringLength(30)]
    public string? AccessCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;
}
