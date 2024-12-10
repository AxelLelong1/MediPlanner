using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TpKeyCd")]
[Table("inst_tp_key_cd")]
public partial class InstTpKeyCd
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("tp_key_cd")]
    public int TpKeyCd { get; set; }

    [Column("inst_tp_key_desc")]
    [StringLength(40)]
    public string? InstTpKeyDesc { get; set; }

    [Column("tp_key_unique_ind")]
    [StringLength(1)]
    public string TpKeyUniqueInd { get; set; } = null!;

    [Column("tp_key_format")]
    [StringLength(20)]
    public string TpKeyFormat { get; set; } = null!;

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

    [Column("tp_key_dsp_seq")]
    public int? TpKeyDspSeq { get; set; }

    [Column("optx_primary_ind")]
    [StringLength(1)]
    public string? OptxPrimaryInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string? ReqInd { get; set; }

    [Column("header_ind")]
    [StringLength(1)]
    public string? HeaderInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("format_mask")]
    [StringLength(60)]
    public string? FormatMask { get; set; }

    [Column("visible_ind")]
    [StringLength(1)]
    public string? VisibleInd { get; set; }

    [Column("unique_hist_ind")]
    [StringLength(1)]
    public string? UniqueHistInd { get; set; }

    [Column("sys_gnrt_ind")]
    [StringLength(1)]
    public string? SysGnrtInd { get; set; }

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

    [Column("intf_use_ind")]
    [StringLength(1)]
    public string? IntfUseInd { get; set; }

    [Column("intf_id_tag")]
    [StringLength(40)]
    public string? IntfIdTag { get; set; }
}
