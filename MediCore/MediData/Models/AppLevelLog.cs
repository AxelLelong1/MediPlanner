using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AppVersNo", "AppBuildNo", "AppLevelNo", "MachineName", "TransLogTstamp")]
[Table("app_level_log")]
public partial class AppLevelLog
{
    [Key]
    [Column("app_vers_no")]
    [StringLength(10)]
    public string AppVersNo { get; set; } = null!;

    [Key]
    [Column("app_build_no")]
    [StringLength(10)]
    public string AppBuildNo { get; set; } = null!;

    [Key]
    [Column("app_level_no")]
    public int AppLevelNo { get; set; }

    [Key]
    [Column("machine_name")]
    [StringLength(15)]
    public string MachineName { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;
}
