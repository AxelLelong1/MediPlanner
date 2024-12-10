using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppCd", "WindowLabelXref", "CtrlLabelXref", "WindowLabelCtrl", "CtrlLabelCtrl")]
[Table("dflt_xref_ctrl")]
public partial class DfltXrefCtrl
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Key]
    [Column("window_label_xref")]
    [StringLength(30)]
    public string WindowLabelXref { get; set; } = null!;

    [Key]
    [Column("ctrl_label_xref")]
    [StringLength(30)]
    public string CtrlLabelXref { get; set; } = null!;

    [Key]
    [Column("window_label_ctrl")]
    [StringLength(30)]
    public string WindowLabelCtrl { get; set; } = null!;

    [Key]
    [Column("ctrl_label_ctrl")]
    [StringLength(30)]
    public string CtrlLabelCtrl { get; set; } = null!;

    [Column("xref_level")]
    public int XrefLevel { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("DfltXrefCtrl")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [ForeignKey("AppCd, WindowLabelCtrl, CtrlLabelCtrl")]
    [InverseProperty("DfltXrefCtrlDfltCtrl")]
    public virtual DfltCtrl DfltCtrl { get; set; } = null!;

    [ForeignKey("AppCd, WindowLabelXref, CtrlLabelXref")]
    [InverseProperty("DfltXrefCtrlDfltCtrlNavigation")]
    public virtual DfltCtrl DfltCtrlNavigation { get; set; } = null!;
}
