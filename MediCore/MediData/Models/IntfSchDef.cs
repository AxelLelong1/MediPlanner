using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_sch_def")]
public partial class IntfSchDef
{
    [Key]
    [Column("sch_seq_no")]
    public int SchSeqNo { get; set; }

    [Column("sch_name")]
    [StringLength(30)]
    public string SchName { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("prcs_task")]
    [StringLength(15)]
    public string? PrcsTask { get; set; }

    [Column("minute_intrvl")]
    public int? MinuteIntrvl { get; set; }

    [Column("day_intrvl")]
    public int? DayIntrvl { get; set; }

    [Column("day_of_month")]
    public int? DayOfMonth { get; set; }

    [Column("sch_time")]
    [StringLength(5)]
    public string? SchTime { get; set; }

    [Column("daily_ind")]
    [StringLength(1)]
    public string? DailyInd { get; set; }

    [Column("mon_ind")]
    [StringLength(1)]
    public string? MonInd { get; set; }

    [Column("tues_ind")]
    [StringLength(1)]
    public string? TuesInd { get; set; }

    [Column("wed_ind")]
    [StringLength(1)]
    public string? WedInd { get; set; }

    [Column("thur_ind")]
    [StringLength(1)]
    public string? ThurInd { get; set; }

    [Column("fri_ind")]
    [StringLength(1)]
    public string? FriInd { get; set; }

    [Column("sat_ind")]
    [StringLength(1)]
    public string? SatInd { get; set; }

    [Column("sun_ind")]
    [StringLength(1)]
    public string? SunInd { get; set; }

    [Column("run_asap_ind")]
    [StringLength(1)]
    public string RunAsapInd { get; set; } = null!;

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string IntfEngineId { get; set; } = null!;

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

    [Column("bill_sys_inst_id")]
    [StringLength(30)]
    public string? BillSysInstId { get; set; }

    [Column("bill_sys_id")]
    [StringLength(20)]
    public string? BillSysId { get; set; }

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

    [Column("pre_custom")]
    [StringLength(80)]
    public string? PreCustom { get; set; }

    [Column("post_custom")]
    [StringLength(80)]
    public string? PostCustom { get; set; }

    [Column("sch_param")]
    [StringLength(255)]
    public string? SchParam { get; set; }

    [Column("srv_ind")]
    [StringLength(1)]
    public string? SrvInd { get; set; }

    [ForeignKey("IntfEngineId")]
    [InverseProperty("IntfSchDef")]
    public virtual IntfEngine IntfEngine { get; set; } = null!;

    [InverseProperty("SchSeqNoNavigation")]
    public virtual ICollection<IntfSch> IntfSch { get; set; } = new List<IntfSch>();
}
