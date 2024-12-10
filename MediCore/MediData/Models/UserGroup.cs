using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GroupInstId", "UserGroupId")]
[Table("user_group")]
public partial class UserGroup
{
    [Key]
    [Column("group_inst_id")]
    [StringLength(30)]
    public string GroupInstId { get; set; } = null!;

    [Key]
    [Column("user_group_id")]
    [StringLength(10)]
    public string UserGroupId { get; set; } = null!;

    [Column("user_group_desc")]
    [StringLength(40)]
    public string UserGroupDesc { get; set; } = null!;

    [Column("invalid_login_nm")]
    public int InvalidLoginNm { get; set; }

    [Column("passwd_chg_days")]
    public int PasswdChgDays { get; set; }

    [Column("app_lock_second")]
    public int AppLockSecond { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [InverseProperty("UserGroup")]
    public virtual ICollection<CrwReportAccess> CrwReportAccess { get; set; } = new List<CrwReportAccess>();

    [ForeignKey("GroupInstId")]
    [InverseProperty("UserGroup")]
    public virtual Inst GroupInst { get; set; } = null!;

    [InverseProperty("UserGroup")]
    public virtual ICollection<UserGroupCtrl> UserGroupCtrl { get; set; } = new List<UserGroupCtrl>();

    [InverseProperty("UserGroup")]
    public virtual ICollection<UserGroupMenu> UserGroupMenu { get; set; } = new List<UserGroupMenu>();

    [InverseProperty("UserGroup")]
    public virtual ICollection<Userid> UseridUserGroup { get; set; } = new List<Userid>();

    [InverseProperty("UserGroupNavigation")]
    public virtual ICollection<Userid> UseridUserGroupNavigation { get; set; } = new List<Userid>();
}
