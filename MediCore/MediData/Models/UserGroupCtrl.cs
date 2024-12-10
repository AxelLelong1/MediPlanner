using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GroupInstId", "UserGroupId", "InstId", "AppCd", "WindowLabel", "CtrlLabel")]
[Table("user_group_ctrl")]
[Index("GroupInstId", "UserGroupId", "InstId", Name = "nc1_user_group_ctrl")]
public partial class UserGroupCtrl
{
    [Key]
    [Column("group_inst_id")]
    [StringLength(30)]
    public string GroupInstId { get; set; } = null!;

    [Key]
    [Column("user_group_id")]
    [StringLength(10)]
    public string UserGroupId { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("window_label")]
    [StringLength(30)]
    public string WindowLabel { get; set; } = null!;

    [Key]
    [Column("ctrl_label")]
    [StringLength(30)]
    public string CtrlLabel { get; set; } = null!;

    [Column("enabled_flag")]
    [StringLength(1)]
    public string EnabledFlag { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("UserGroupCtrl")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [ForeignKey("AppCd, WindowLabel, CtrlLabel")]
    [InverseProperty("UserGroupCtrl")]
    public virtual DfltCtrl DfltCtrl { get; set; } = null!;

    [ForeignKey("GroupInstId, UserGroupId")]
    [InverseProperty("UserGroupCtrl")]
    public virtual UserGroup UserGroup { get; set; } = null!;
}
