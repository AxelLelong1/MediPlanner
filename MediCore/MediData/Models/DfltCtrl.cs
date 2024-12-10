using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "WindowLabel", "CtrlLabel")]
[Table("dflt_ctrl")]
public partial class DfltCtrl
{
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

    [Column("ctrl_name")]
    [StringLength(50)]
    public string CtrlName { get; set; } = null!;

    [Column("mod_flag")]
    [StringLength(1)]
    public string ModFlag { get; set; } = null!;

    [Column("ctrl_order_no")]
    public int CtrlOrderNo { get; set; }

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
    [InverseProperty("DfltCtrl")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [InverseProperty("DfltCtrl")]
    public virtual ICollection<DfltXrefCtrl> DfltXrefCtrlDfltCtrl { get; set; } = new List<DfltXrefCtrl>();

    [InverseProperty("DfltCtrlNavigation")]
    public virtual ICollection<DfltXrefCtrl> DfltXrefCtrlDfltCtrlNavigation { get; set; } = new List<DfltXrefCtrl>();

    [InverseProperty("DfltCtrl")]
    public virtual ICollection<DfltXrefMenu> DfltXrefMenu { get; set; } = new List<DfltXrefMenu>();

    [InverseProperty("DfltCtrl")]
    public virtual ICollection<UserGroupCtrl> UserGroupCtrl { get; set; } = new List<UserGroupCtrl>();
}
