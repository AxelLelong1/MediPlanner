using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ReportName", "ParmName")]
[Table("crw_report_parm")]
public partial class CrwReportParm
{
    [Key]
    [Column("report_name")]
    [StringLength(40)]
    public string ReportName { get; set; } = null!;

    [Key]
    [Column("parm_name")]
    [StringLength(30)]
    public string ParmName { get; set; } = null!;

    [Column("parm_no")]
    public int? ParmNo { get; set; }

    [Column("parm_label")]
    [StringLength(50)]
    public string? ParmLabel { get; set; }

    [Column("parm_typ")]
    [StringLength(50)]
    public string? ParmTyp { get; set; }

    [Column("parm_init_value")]
    [StringLength(50)]
    public string? ParmInitValue { get; set; }

    [Column("parm_help")]
    [StringLength(200)]
    public string? ParmHelp { get; set; }

    [Column("display_typ")]
    [StringLength(50)]
    public string? DisplayTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("data_source_proc_name")]
    [StringLength(125)]
    public string? DataSourceProcName { get; set; }

    [Column("data_source_proc_args_typ")]
    [StringLength(50)]
    public string? DataSourceProcArgsTyp { get; set; }

    [Column("required_ind")]
    [StringLength(1)]
    public string? RequiredInd { get; set; }

    [Column("parent_parm_name")]
    [StringLength(30)]
    public string? ParentParmName { get; set; }

    [ForeignKey("ReportName")]
    [InverseProperty("CrwReportParm")]
    public virtual CrwReportList ReportNameNavigation { get; set; } = null!;
}
