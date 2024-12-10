using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("WindowName", "TransLogInstId", "TransLogUserid", "TransLogTstamp")]
[Table("user_win_access")]
[Index("PtId", Name = "nc1_user_win_access")]
public partial class UserWinAccess
{
    [Key]
    [Column("window_name")]
    [StringLength(30)]
    public string WindowName { get; set; } = null!;

    [Column("window_label")]
    [StringLength(50)]
    public string WindowLabel { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Key]
    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Key]
    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("action_cd")]
    [StringLength(1)]
    public string? ActionCd { get; set; }

    [Column("chk_sum")]
    [MaxLength(200)]
    public byte[]? ChkSum { get; set; }
}
