using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtExamId")]
[Table("pt_exam")]
public partial class PtExam
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

    [Column("exam_cd")]
    [StringLength(1)]
    public string? ExamCd { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string? Userid { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("datetime_appr", TypeName = "datetime")]
    public DateTime? DatetimeAppr { get; set; }

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

    [Column("exam_datetime", TypeName = "datetime")]
    public DateTime? ExamDatetime { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }
}
