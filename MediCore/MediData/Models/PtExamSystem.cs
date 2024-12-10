using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtExamId", "PtExamSystemId")]
[Table("pt_exam_system")]
public partial class PtExamSystem
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_exam_id")]
    public int PtExamId { get; set; }

    [Key]
    [Column("pt_exam_system_id")]
    public int PtExamSystemId { get; set; }

    [Column("system_typ_id")]
    public int? SystemTypId { get; set; }

    [Column("system_desc")]
    [StringLength(30)]
    public string? SystemDesc { get; set; }

    [Column("system_asmt_cd")]
    [StringLength(1)]
    public string? SystemAsmtCd { get; set; }

    [Column("system_asmt_desc")]
    public string? SystemAsmtDesc { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("mr_ind")]
    [StringLength(1)]
    public string? MrInd { get; set; }

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

    [Column("custom_asmt_ind")]
    [StringLength(1)]
    public string? CustomAsmtInd { get; set; }

    [Column("dictated_ind")]
    [StringLength(1)]
    public string? DictatedInd { get; set; }

    [Column("asmt_system_desc")]
    public string? AsmtSystemDesc { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
