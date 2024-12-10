using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAuthId")]
[Table("pt_auth")]
[Index("PtId", "PtActualId", Name = "nc1_pt_auth")]
public partial class PtAuth
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_auth_id")]
    public int PtAuthId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("pt_actual_id")]
    public int? PtActualId { get; set; }

    [Column("pt_child_actual_id")]
    public int? PtChildActualId { get; set; }

    [Column("auth_event_typ")]
    public int? AuthEventTyp { get; set; }

    [Column("auth_tstamp", TypeName = "datetime")]
    public DateTime? AuthTstamp { get; set; }

    [Column("auth_cd")]
    [StringLength(3)]
    public string? AuthCd { get; set; }

    [Column("auth_userid")]
    [StringLength(255)]
    public string AuthUserid { get; set; } = null!;

    [Column("auth_inst_id")]
    [StringLength(30)]
    public string AuthInstId { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
