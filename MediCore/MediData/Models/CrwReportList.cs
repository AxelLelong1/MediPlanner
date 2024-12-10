using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("crw_report_list")]
public partial class CrwReportList
{
    [Key]
    [Column("report_name")]
    [StringLength(40)]
    public string ReportName { get; set; } = null!;

    [Column("report_title")]
    [StringLength(100)]
    public string ReportTitle { get; set; } = null!;

    [Column("report_desc")]
    [StringLength(1500)]
    public string ReportDesc { get; set; } = null!;

    [Column("report_typ")]
    public int ReportTyp { get; set; }

    [Column("report_env")]
    [StringLength(2)]
    public string? ReportEnv { get; set; }

    [Column("report_dw_name")]
    [StringLength(40)]
    public string? ReportDwName { get; set; }

    [Column("report_parm_level")]
    public int? ReportParmLevel { get; set; }

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

    [Column("cp_ind")]
    [StringLength(1)]
    public string? CpInd { get; set; }

    [Column("rx_ind")]
    [StringLength(1)]
    public string? RxInd { get; set; }

    [Column("tx_ind")]
    [StringLength(1)]
    public string? TxInd { get; set; }

    [Column("mgr_ind")]
    [StringLength(1)]
    public string? MgrInd { get; set; }

    [Column("pln_ind")]
    [StringLength(1)]
    public string? PlnInd { get; set; }

    [Column("sec_ind")]
    [StringLength(1)]
    public string? SecInd { get; set; }

    [Column("cta_ind")]
    [StringLength(1)]
    public string? CtaInd { get; set; }

    [Column("cta_mode_cd")]
    [StringLength(1)]
    public string? CtaModeCd { get; set; }

    [InverseProperty("ReportNameNavigation")]
    public virtual ICollection<CrwReportAccess> CrwReportAccess { get; set; } = new List<CrwReportAccess>();

    [InverseProperty("ReportNameNavigation")]
    public virtual ICollection<CrwReportParm> CrwReportParm { get; set; } = new List<CrwReportParm>();

    [ForeignKey("ReportTyp")]
    [InverseProperty("CrwReportList")]
    public virtual CrwReportTyp ReportTypNavigation { get; set; } = null!;
}
