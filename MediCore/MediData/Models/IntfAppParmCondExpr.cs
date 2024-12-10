using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmCondHeaderId", "ExpressionTyp")]
[Table("intf_app_parm_cond_expr")]
public partial class IntfAppParmCondExpr
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string IntfAppParmCondHeaderId { get; set; } = null!;

    [Key]
    [Column("expression_typ")]
    [StringLength(1)]
    public string ExpressionTyp { get; set; } = null!;

    [Column("expression")]
    public string? Expression { get; set; }

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime? BaseTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("IntfAppParmId, IntfAppParmCondHeaderId")]
    [InverseProperty("IntfAppParmCondExpr")]
    public virtual IntfAppParmCond IntfAppParmCond { get; set; } = null!;
}
