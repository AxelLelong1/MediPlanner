using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid", "AccessTime", "WindowLabel", "CtrlLabel", "TransLogTstamp")]
[Table("user_privilege_log")]
public partial class UserPrivilegeLog
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("group_inst_id")]
    [StringLength(30)]
    public string GroupInstId { get; set; } = null!;

    [Column("user_group_id")]
    [StringLength(10)]
    public string UserGroupId { get; set; } = null!;

    [Column("computer_id")]
    [StringLength(30)]
    public string ComputerId { get; set; } = null!;

    [Key]
    [Column("access_time", TypeName = "datetime")]
    public DateTime AccessTime { get; set; }

    [Column("app_cd")]
    [StringLength(60)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Key]
    [Column("ctrl_label")]
    [StringLength(30)]
    public string CtrlLabel { get; set; } = null!;

    [Column("app_name")]
    [StringLength(60)]
    public string AppName { get; set; } = null!;

    [Column("access_cmt")]
    [StringLength(255)]
    public string AccessCmt { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("emergency_group_inst_id")]
    [StringLength(30)]
    public string? EmergencyGroupInstId { get; set; }

    [Column("emergency_user_group_id")]
    [StringLength(10)]
    public string? EmergencyUserGroupId { get; set; }
}
