using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "MenuLabel", "WindowLabelCtrl", "CtrlLabelCtrl")]
[Table("dflt_xref_menu")]
public partial class DfltXrefMenu
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("menu_label")]
    [StringLength(100)]
    public string MenuLabel { get; set; } = null!;

    [Key]
    [Column("window_label_ctrl")]
    [StringLength(30)]
    public string WindowLabelCtrl { get; set; } = null!;

    [Key]
    [Column("ctrl_label_ctrl")]
    [StringLength(30)]
    public string CtrlLabelCtrl { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("DfltXrefMenu")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [ForeignKey("AppCd, WindowLabelCtrl, CtrlLabelCtrl")]
    [InverseProperty("DfltXrefMenu")]
    public virtual DfltCtrl DfltCtrl { get; set; } = null!;

    [ForeignKey("AppCd, MenuLabel")]
    [InverseProperty("DfltXrefMenu")]
    public virtual DfltMenu DfltMenu { get; set; } = null!;
}
