using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("db_inst")]
public partial class DbInst
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("install_flag")]
    [StringLength(1)]
    public string InstallFlag { get; set; } = null!;

    [Column("next_user_no")]
    public int NextUserNo { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("audit_reason_ind")]
    [StringLength(1)]
    public string? AuditReasonInd { get; set; }

    [Column("db_status_cd")]
    [StringLength(30)]
    public string? DbStatusCd { get; set; }

    [Column("db_status_date", TypeName = "datetime")]
    public DateTime? DbStatusDate { get; set; }

    [Column("db_vers_no")]
    [StringLength(10)]
    public string? DbVersNo { get; set; }

    [Column("db_build_no")]
    [StringLength(10)]
    public string? DbBuildNo { get; set; }

    [Column("dual_mod_ind")]
    [StringLength(1)]
    public string? DualModInd { get; set; }

    [Column("locale_id")]
    public int? LocaleId { get; set; }

    [Column("database_server_name")]
    [StringLength(30)]
    public string? DatabaseServerName { get; set; }

    [Column("database_server_port")]
    public int? DatabaseServerPort { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("DbInst")]
    public virtual Inst Inst { get; set; } = null!;
}
