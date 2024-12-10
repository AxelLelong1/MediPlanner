using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("epcs_audit_log")]
public partial class EpcsAuditLog
{
    [Key]
    [Column("epcs_audit_log_id")]
    public int EpcsAuditLogId { get; set; }

    [Column("event_typ_desc")]
    [StringLength(25)]
    public string EventTypDesc { get; set; } = null!;

    [Column("event_desc")]
    public string EventDesc { get; set; } = null!;

    [Column("event_datetime", TypeName = "datetime")]
    public DateTime EventDatetime { get; set; }

    [Column("pgm_name")]
    [StringLength(255)]
    public string? PgmName { get; set; }

    [Column("app_userid")]
    [StringLength(10)]
    public string? AppUserid { get; set; }

    [Column("db_login")]
    [StringLength(256)]
    public string? DbLogin { get; set; }

    [Column("pre_tamper")]
    public string? PreTamper { get; set; }

    [Column("post_tamper")]
    public string? PostTamper { get; set; }

    [Column("parent_epcs_audit_log_id")]
    public int? ParentEpcsAuditLogId { get; set; }

    [Column("epcs_source_key")]
    [StringLength(255)]
    public string? EpcsSourceKey { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("epcs_hash")]
    [MaxLength(32)]
    public byte[]? EpcsHash { get; set; }
}
