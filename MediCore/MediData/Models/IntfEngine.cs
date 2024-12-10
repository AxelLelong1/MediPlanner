using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_engine")]
public partial class IntfEngine
{
    [Key]
    [Column("intf_engine_id")]
    [StringLength(10)]
    public string IntfEngineId { get; set; } = null!;

    [Column("engine_name")]
    [StringLength(30)]
    public string EngineName { get; set; } = null!;

    [Column("prcs_intrvl_secs")]
    public int PrcsIntrvlSecs { get; set; }

    [Column("stats_hours_tokeep")]
    public int StatsHoursTokeep { get; set; }

    [Column("stats_days_tokeep")]
    public int StatsDaysTokeep { get; set; }

    [Column("stats_months_tokeep")]
    public int StatsMonthsTokeep { get; set; }

    [Column("run_wprocess_ind")]
    [StringLength(1)]
    public string RunWprocessInd { get; set; } = null!;

    [Column("last_prcs_time", TypeName = "datetime")]
    public DateTime LastPrcsTime { get; set; }

    [Column("log_path")]
    [StringLength(80)]
    public string? LogPath { get; set; }

    [Column("msg_log_purge_days")]
    public int? MsgLogPurgeDays { get; set; }

    [Column("sch_purge_days")]
    public int? SchPurgeDays { get; set; }

    [Column("run_trgr_evnts_ind")]
    [StringLength(1)]
    public string? RunTrgrEvntsInd { get; set; }

    [Column("debug_ind")]
    [StringLength(1)]
    public string? DebugInd { get; set; }

    [Column("imp_compl_ind")]
    [StringLength(1)]
    public string? ImpComplInd { get; set; }

    [Column("engine_typ")]
    [StringLength(1)]
    public string? EngineTyp { get; set; }

    [Column("engine_inst_id")]
    [StringLength(30)]
    public string? EngineInstId { get; set; }

    [Column("mntr_port")]
    [StringLength(6)]
    public string? MntrPort { get; set; }

    [Column("pid")]
    public int? Pid { get; set; }

    [Column("enabled_ind")]
    [StringLength(1)]
    public string? EnabledInd { get; set; }

    [Column("service_monitor_intrvl_min")]
    public int? ServiceMonitorIntrvlMin { get; set; }

    [Column("intf_service_id")]
    [StringLength(10)]
    public string? IntfServiceId { get; set; }

    [Column("start_mthd")]
    [StringLength(1)]
    public string? StartMthd { get; set; }

    [Column("log_intrvl")]
    public int? LogIntrvl { get; set; }

    [Column("sch_stop_ind")]
    [StringLength(1)]
    public string? SchStopInd { get; set; }

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

    [Column("heartbeat_prcs_intrvl_min")]
    public short? HeartbeatPrcsIntrvlMin { get; set; }

    [Column("engine_rpt_ind")]
    [StringLength(1)]
    public string EngineRptInd { get; set; } = null!;

    [Column("engine_rpt_level")]
    public int? EngineRptLevel { get; set; }

    [Column("engine_rpt_start_date", TypeName = "datetime")]
    public DateTime? EngineRptStartDate { get; set; }

    [Column("engine_rpt_start_time")]
    [StringLength(5)]
    public string? EngineRptStartTime { get; set; }

    [Column("engine_rpt_end_date", TypeName = "datetime")]
    public DateTime? EngineRptEndDate { get; set; }

    [Column("engine_rpt_end_time")]
    [StringLength(5)]
    public string? EngineRptEndTime { get; set; }

    [Column("scheduler_monitor_interval_min")]
    public int SchedulerMonitorIntervalMin { get; set; }

    [Column("varis_db_refresh_timer")]
    public int VarisDbRefreshTimer { get; set; }

    [InverseProperty("IntfEngine")]
    public virtual ICollection<IntfComm> IntfComm { get; set; } = new List<IntfComm>();

    [InverseProperty("IntfEngine")]
    public virtual ICollection<IntfSchDef> IntfSchDef { get; set; } = new List<IntfSchDef>();
}
