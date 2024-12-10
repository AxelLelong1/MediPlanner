using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid")]
[Table("online_log")]
public partial class OnlineLog
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("app_name")]
    [StringLength(10)]
    public string AppName { get; set; } = null!;

    [Column("login_time", TypeName = "datetime")]
    public DateTime LoginTime { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("user_db_id")]
    [StringLength(10)]
    public string? UserDbId { get; set; }

    [Column("user_sp_id")]
    public int? UserSpId { get; set; }

    [Column("last_h_tstamp", TypeName = "datetime")]
    public DateTime? LastHTstamp { get; set; }

    [Column("app_session_id")]
    [StringLength(38)]
    public string? AppSessionId { get; set; }

    [ForeignKey("AppName")]
    [InverseProperty("OnlineLog")]
    public virtual App AppNameNavigation { get; set; } = null!;
}
