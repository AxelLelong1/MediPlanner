using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("compliance_prd")]
public partial class CompliancePrd
{
    [Key]
    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Column("compliance_pgm_id")]
    public int CompliancePgmId { get; set; }

    [Column("prd_name")]
    [StringLength(30)]
    public string PrdName { get; set; } = null!;

    [Column("prd_desc")]
    [StringLength(200)]
    public string? PrdDesc { get; set; }

    [Column("job_frq")]
    public int? JobFrq { get; set; }

    [Column("job_frq_day_of_week")]
    public int? JobFrqDayOfWeek { get; set; }

    [Column("job_execution_time")]
    [StringLength(5)]
    public string? JobExecutionTime { get; set; }

    [Column("job_id")]
    public Guid? JobId { get; set; }

    [Column("job_schedule_id")]
    public int? JobScheduleId { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("prd_start_dt", TypeName = "datetime")]
    public DateTime PrdStartDt { get; set; }

    [Column("prd_end_dt", TypeName = "datetime")]
    public DateTime PrdEndDt { get; set; }

    [Column("job_active_ind")]
    [StringLength(1)]
    public string JobActiveInd { get; set; } = null!;

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("mu_error_ind")]
    [StringLength(1)]
    public string? MuErrorInd { get; set; }

    [Column("tin")]
    [StringLength(20)]
    public string? Tin { get; set; }

    [Column("group_reporting_ind")]
    [StringLength(1)]
    public string? GroupReportingInd { get; set; }

    [ForeignKey("CompliancePgmId")]
    [InverseProperty("CompliancePrd")]
    public virtual CompliancePgm CompliancePgm { get; set; } = null!;

    [InverseProperty("CompliancePrd")]
    public virtual ICollection<PtProviderMu> PtProviderMu { get; set; } = new List<PtProviderMu>();

    [InverseProperty("CompliancePrd")]
    public virtual ICollection<QmInstance> QmInstance { get; set; } = new List<QmInstance>();
}
