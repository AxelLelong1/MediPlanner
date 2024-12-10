using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("varis_db_info")]
public partial class VarisDbInfo
{
    [Key]
    [Column("login_userid")]
    [StringLength(255)]
    public string LoginUserid { get; set; } = null!;

    [Column("login_pwd")]
    [StringLength(20)]
    public string? LoginPwd { get; set; }

    [Column("dbms")]
    [StringLength(4)]
    public string Dbms { get; set; } = null!;

    [Column("svr_name")]
    [StringLength(30)]
    public string SvrName { get; set; } = null!;

    [Column("db_name")]
    [StringLength(30)]
    public string DbName { get; set; } = null!;

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

    [Column("srv_port")]
    public int? SrvPort { get; set; }

    [Column("osp_userid")]
    [StringLength(255)]
    public string? OspUserid { get; set; }

    [Column("osp_password")]
    [StringLength(255)]
    public string? OspPassword { get; set; }

    [Column("varis_db_refresh_timer")]
    public int? VarisDbRefreshTimer { get; set; }
}
