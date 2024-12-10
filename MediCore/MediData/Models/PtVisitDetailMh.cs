using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "VisitDetailId", "RevisionNo")]
[Table("pt_visit_detail_mh")]
public partial class PtVisitDetailMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("visit_detail_id")]
    public int VisitDetailId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("visit_detail_typ")]
    public int VisitDetailTyp { get; set; }

    [Column("visit_detail_grp_id")]
    public int? VisitDetailGrpId { get; set; }

    [Column("detail_userid")]
    [StringLength(255)]
    public string? DetailUserid { get; set; }

    [Column("detail_inst_id")]
    [StringLength(30)]
    public string? DetailInstId { get; set; }

    [Column("component_count")]
    public int? ComponentCount { get; set; }

    [Column("visit_detail_desc")]
    public string? VisitDetailDesc { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("dictation_queue_id")]
    public int? DictationQueueId { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("visit_detail_tstamp", TypeName = "datetime")]
    public DateTime? VisitDetailTstamp { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
