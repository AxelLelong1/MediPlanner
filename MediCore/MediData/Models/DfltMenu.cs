using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "MenuLabel")]
[Table("dflt_menu")]
public partial class DfltMenu
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("menu_label")]
    [StringLength(100)]
    public string MenuLabel { get; set; } = null!;

    [Column("parent_menu_label")]
    [StringLength(100)]
    public string ParentMenuLabel { get; set; } = null!;

    [Column("menu_level")]
    public int MenuLevel { get; set; }

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
    [InverseProperty("DfltMenu")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [InverseProperty("DfltMenu")]
    public virtual ICollection<DfltXrefMenu> DfltXrefMenu { get; set; } = new List<DfltXrefMenu>();

    [InverseProperty("DfltMenu")]
    public virtual ICollection<UserGroupMenu> UserGroupMenu { get; set; } = new List<UserGroupMenu>();
}
