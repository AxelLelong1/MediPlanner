using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GroupInstId", "UserGroupId", "InstId", "AppCd", "MenuLabel")]
[Table("user_group_menu")]
[Index("GroupInstId", "UserGroupId", "InstId", Name = "nc1_user_group_menu")]
public partial class UserGroupMenu
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
    [Column("menu_label")]
    [StringLength(100)]
    public string MenuLabel { get; set; } = null!;

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

    [ForeignKey("AppCd")]
    [InverseProperty("UserGroupMenu")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [ForeignKey("AppCd, MenuLabel")]
    [InverseProperty("UserGroupMenu")]
    public virtual DfltMenu DfltMenu { get; set; } = null!;

    [ForeignKey("GroupInstId, UserGroupId")]
    [InverseProperty("UserGroupMenu")]
    public virtual UserGroup UserGroup { get; set; } = null!;
}
