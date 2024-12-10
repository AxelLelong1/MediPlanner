using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "StkhKeyCd")]
[Table("stkh_inst_key_cd")]
public partial class StkhInstKeyCd
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("stkh_key_cd")]
    public int StkhKeyCd { get; set; }

    [Column("role_typ")]
    public int RoleTyp { get; set; }

    [Column("inst_label")]
    [StringLength(30)]
    public string InstLabel { get; set; } = null!;

    [Column("inst_desc")]
    [StringLength(255)]
    public string? InstDesc { get; set; }

    [Column("sys_gnrt_ind")]
    [StringLength(1)]
    public string SysGnrtInd { get; set; } = null!;

    [Column("format_mask")]
    [StringLength(60)]
    public string? FormatMask { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string ReqInd { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("visible_ind")]
    [StringLength(1)]
    public string VisibleInd { get; set; } = null!;

    [Column("unique_ind")]
    [StringLength(1)]
    public string UniqueInd { get; set; } = null!;

    [Column("unique_hist_ind")]
    [StringLength(1)]
    public string UniqueHistInd { get; set; } = null!;

    [Column("next_seq")]
    [StringLength(15)]
    public string? NextSeq { get; set; }

    [Column("start_val")]
    [StringLength(15)]
    public string? StartVal { get; set; }

    [Column("end_val")]
    [StringLength(15)]
    public string? EndVal { get; set; }

    [Column("increment")]
    public int? Increment { get; set; }

    [Column("prefix_list")]
    [StringLength(80)]
    public string? PrefixList { get; set; }

    [Column("cur_prefix")]
    [StringLength(10)]
    public string? CurPrefix { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("rx_print_ind")]
    [StringLength(1)]
    public string? RxPrintInd { get; set; }

    [ForeignKey("StkhKeyCd")]
    [InverseProperty("StkhInstKeyCd")]
    public virtual StkhKeyCd StkhKeyCdNavigation { get; set; } = null!;
}
