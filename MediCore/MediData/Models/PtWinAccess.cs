using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "WindowLabel", "TransLogTstamp")]
[Table("pt_win_access")]
[Index("TransLogUserid", "TransLogTstamp", Name = "nc1_pt_win_access")]
public partial class PtWinAccess
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("window_label")]
    [StringLength(100)]
    public string WindowLabel { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("chk_sum")]
    [MaxLength(200)]
    public byte[]? ChkSum { get; set; }
}
