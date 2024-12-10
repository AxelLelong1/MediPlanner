using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "SocHxDetailId")]
[Table("pt_soc_hx_detail")]
public partial class PtSocHxDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("soc_hx_detail_id")]
    public int SocHxDetailId { get; set; }

    [Column("base_cls_typ")]
    public int BaseClsTyp { get; set; }

    [Column("soc_hx_detail")]
    [StringLength(100)]
    public string? SocHxDetail { get; set; }

    [Column("soc_hx_detail_cmt")]
    public string? SocHxDetailCmt { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("duration")]
    public int? Duration { get; set; }

    [Column("duration_unit")]
    public int? DurationUnit { get; set; }

    [Column("time_unit")]
    public int? TimeUnit { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
