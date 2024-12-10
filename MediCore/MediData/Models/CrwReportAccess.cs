using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ReportName", "GroupInstId", "UserGroupId")]
[Table("crw_report_access")]
public partial class CrwReportAccess
{
    [Key]
    [Column("report_name")]
    [StringLength(40)]
    public string ReportName { get; set; } = null!;

    [Key]
    [Column("group_inst_id")]
    [StringLength(30)]
    public string GroupInstId { get; set; } = null!;

    [Key]
    [Column("user_group_id")]
    [StringLength(10)]
    public string UserGroupId { get; set; } = null!;

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

    [ForeignKey("ReportName")]
    [InverseProperty("CrwReportAccess")]
    public virtual CrwReportList ReportNameNavigation { get; set; } = null!;

    [ForeignKey("GroupInstId, UserGroupId")]
    [InverseProperty("CrwReportAccess")]
    public virtual UserGroup UserGroup { get; set; } = null!;
}
