using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("scheduled_export")]
public partial class ScheduledExport
{
    [Key]
    [Column("scheduled_export_id")]
    public int ScheduledExportId { get; set; }

    [Column("recurrence_typ")]
    public int RecurrenceTyp { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string Status { get; set; } = null!;

    [Column("selection_typ")]
    [StringLength(1)]
    public string SelectionTyp { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("scheduled_export_time", TypeName = "datetime")]
    public DateTime ScheduledExportTime { get; set; }

    [Column("scheduled_export_day_of_week")]
    public int? ScheduledExportDayOfWeek { get; set; }

    [Column("scheduled_export_day_of_month")]
    public int? ScheduledExportDayOfMonth { get; set; }

    [Column("password")]
    [StringLength(255)]
    public string Password { get; set; } = null!;

    [Column("last_run_date", TypeName = "datetime")]
    public DateTime? LastRunDate { get; set; }

    [Column("scheduled_export_date", TypeName = "datetime")]
    public DateTime? ScheduledExportDate { get; set; }

    [Column("has_schedule_changes")]
    [StringLength(1)]
    public string HasScheduleChanges { get; set; } = null!;

    [Column("schedule_modified_date", TypeName = "datetime")]
    public DateTime ScheduleModifiedDate { get; set; }

    [Column("pt_list_query_id")]
    public int? PtListQueryId { get; set; }

    [Column("last_run_scheduled_date", TypeName = "datetime")]
    public DateTime? LastRunScheduledDate { get; set; }

    [Column("temp_folder")]
    public string? TempFolder { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("patients_exported")]
    public int? PatientsExported { get; set; }

    [Column("total_patients")]
    public int? TotalPatients { get; set; }

    [Column("elapsed_ticks")]
    public long? ElapsedTicks { get; set; }

    [Column("export_name")]
    [StringLength(255)]
    public string ExportName { get; set; } = null!;

    [Column("failure_acknowledged")]
    [StringLength(1)]
    public string? FailureAcknowledged { get; set; }
}
