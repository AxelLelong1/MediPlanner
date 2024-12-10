using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AuthEventTyp")]
[Table("inst_auth_event")]
public partial class InstAuthEvent
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("auth_event_typ")]
    public int AuthEventTyp { get; set; }

    [Column("auth_event_typ_desc")]
    [StringLength(100)]
    public string AuthEventTypDesc { get; set; } = null!;

    [Column("esig_pref_cd")]
    [StringLength(5)]
    public string EsigPrefCd { get; set; } = null!;

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

    [Column("auth_method")]
    public int? AuthMethod { get; set; }

    [Column("ref_table_name")]
    [StringLength(128)]
    public string? RefTableName { get; set; }
}
