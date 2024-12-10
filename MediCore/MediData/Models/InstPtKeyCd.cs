using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "PtKeyCd")]
[Table("inst_pt_key_cd")]
public partial class InstPtKeyCd
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("pt_key_cd")]
    public int PtKeyCd { get; set; }

    [Column("inst_pt_key_desc")]
    [StringLength(40)]
    public string? InstPtKeyDesc { get; set; }

    [Column("pt_key_unique_ind")]
    [StringLength(1)]
    public string PtKeyUniqueInd { get; set; } = null!;

    [Column("pt_key_format")]
    [StringLength(25)]
    public string PtKeyFormat { get; set; } = null!;

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

    [Column("pt_key_dsp_seq")]
    public int? PtKeyDspSeq { get; set; }

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

    [Column("scan_ind")]
    [StringLength(1)]
    public string? ScanInd { get; set; }

    [Column("mr_pt_access_external_ind")]
    [StringLength(1)]
    public string? MrPtAccessExternalInd { get; set; }

    [Column("vptmgr_ind")]
    [StringLength(1)]
    public string? VptmgrInd { get; set; }

    [Column("vptmgr_id1_ind")]
    [StringLength(1)]
    public string? VptmgrId1Ind { get; set; }

    [Column("vptmgr_id2_ind")]
    [StringLength(1)]
    public string? VptmgrId2Ind { get; set; }

    [Column("display_only_ind")]
    [StringLength(1)]
    public string? DisplayOnlyInd { get; set; }

    [InverseProperty("InstPtKeyCd")]
    public virtual ICollection<IntfPtKeyMap> IntfPtKeyMap { get; set; } = new List<IntfPtKeyMap>();

    [ForeignKey("PtKeyCd")]
    [InverseProperty("InstPtKeyCd")]
    public virtual PtKeyCd PtKeyCdNavigation { get; set; } = null!;
}
