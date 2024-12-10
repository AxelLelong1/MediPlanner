using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("app_access_time")]
public partial class AppAccessTime
{
    [Key]
    [Column("access_time_id")]
    public int AccessTimeId { get; set; }

    [Column("group_inst_id")]
    [StringLength(30)]
    public string GroupInstId { get; set; } = null!;

    [Column("user_group_id")]
    [StringLength(10)]
    public string UserGroupId { get; set; } = null!;

    [Column("access_start_time", TypeName = "datetime")]
    public DateTime AccessStartTime { get; set; }

    [Column("access_end_time", TypeName = "datetime")]
    public DateTime AccessEndTime { get; set; }

    [Column("day_of_week")]
    [StringLength(3)]
    public string DayOfWeek { get; set; } = null!;

    [Column("efc_date", TypeName = "datetime")]
    public DateTime EfcDate { get; set; }

    [Column("exp_date", TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
