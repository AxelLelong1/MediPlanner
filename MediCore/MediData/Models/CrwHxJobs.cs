using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "SessionId", "JobNo")]
[Table("crw_hx_jobs")]
public partial class CrwHxJobs
{
    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("session_id")]
    [StringLength(25)]
    public string SessionId { get; set; } = null!;

    [Key]
    [Column("job_no")]
    public int JobNo { get; set; }

    [Column("spid")]
    public int? Spid { get; set; }

    [Column("report_name")]
    [StringLength(40)]
    public string? ReportName { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("str_1")]
    [StringLength(50)]
    public string? Str1 { get; set; }

    [Column("str_2")]
    [StringLength(50)]
    public string? Str2 { get; set; }

    [Column("str_3")]
    [StringLength(50)]
    public string? Str3 { get; set; }

    [Column("str_4")]
    [StringLength(50)]
    public string? Str4 { get; set; }

    [Column("str_5")]
    [StringLength(50)]
    public string? Str5 { get; set; }

    [Column("str_6")]
    [StringLength(50)]
    public string? Str6 { get; set; }

    [Column("str_7")]
    [StringLength(50)]
    public string? Str7 { get; set; }

    [Column("str_8")]
    [StringLength(50)]
    public string? Str8 { get; set; }

    [Column("str_9")]
    [StringLength(50)]
    public string? Str9 { get; set; }

    [Column("dt_1", TypeName = "datetime")]
    public DateTime? Dt1 { get; set; }

    [Column("dt_2", TypeName = "datetime")]
    public DateTime? Dt2 { get; set; }

    [Column("dt_3", TypeName = "datetime")]
    public DateTime? Dt3 { get; set; }

    [Column("dt_4", TypeName = "datetime")]
    public DateTime? Dt4 { get; set; }

    [Column("dt_5", TypeName = "datetime")]
    public DateTime? Dt5 { get; set; }

    [Column("int_1")]
    public int? Int1 { get; set; }

    [Column("int_2")]
    public int? Int2 { get; set; }

    [Column("int_3")]
    public int? Int3 { get; set; }

    [Column("int_4")]
    public int? Int4 { get; set; }

    [Column("int_5")]
    public int? Int5 { get; set; }

    [Column("int_6")]
    public int? Int6 { get; set; }

    [Column("int_7")]
    public int? Int7 { get; set; }

    [Column("int_8")]
    public int? Int8 { get; set; }

    [Column("int_9")]
    public int? Int9 { get; set; }

    [Column("num_1", TypeName = "numeric(11, 4)")]
    public decimal? Num1 { get; set; }

    [Column("num_2", TypeName = "numeric(11, 4)")]
    public decimal? Num2 { get; set; }

    [Column("num_3", TypeName = "numeric(11, 4)")]
    public decimal? Num3 { get; set; }

    [Column("num_4", TypeName = "numeric(11, 4)")]
    public decimal? Num4 { get; set; }

    [Column("num_5", TypeName = "numeric(11, 4)")]
    public decimal? Num5 { get; set; }

    [Column("hdr_1")]
    [StringLength(125)]
    public string Hdr1 { get; set; } = null!;

    [Column("hdr_2")]
    [StringLength(125)]
    public string Hdr2 { get; set; } = null!;

    [Column("hdr_3")]
    [StringLength(125)]
    public string Hdr3 { get; set; } = null!;

    [Column("hdr_4")]
    [StringLength(125)]
    public string Hdr4 { get; set; } = null!;

    [Column("hdr_5")]
    [StringLength(125)]
    public string Hdr5 { get; set; } = null!;

    [Column("hdr_6")]
    [StringLength(125)]
    public string Hdr6 { get; set; } = null!;

    [Column("hdr_7")]
    [StringLength(125)]
    public string Hdr7 { get; set; } = null!;

    [Column("user_inst_id")]
    [StringLength(30)]
    public string? UserInstId { get; set; }

    [Column("report_group_id")]
    [StringLength(25)]
    public string? ReportGroupId { get; set; }

    [Column("report_completed_on_tstamp", TypeName = "datetime")]
    public DateTime? ReportCompletedOnTstamp { get; set; }
}
