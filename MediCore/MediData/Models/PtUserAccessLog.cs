using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAccessLogId")]
[Table("pt_user_access_log")]
[Index("OpenTstamp", Name = "nc1_pt_user_access_log")]
public partial class PtUserAccessLog
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_access_log_id")]
    public int PtAccessLogId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

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

    [Column("open_tstamp", TypeName = "datetime")]
    public DateTime? OpenTstamp { get; set; }

    [Column("close_tstamp", TypeName = "datetime")]
    public DateTime? CloseTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("access_inst_id")]
    [StringLength(30)]
    public string? AccessInstId { get; set; }

    [Column("chk_sum")]
    [MaxLength(200)]
    public byte[]? ChkSum { get; set; }
}
