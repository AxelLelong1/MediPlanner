using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "SystemTypId")]
[Table("inst_exam_system")]
[Index("InstId", "ExamCd", Name = "nc1_inst_exam_system")]
public partial class InstExamSystem
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("system_typ_id")]
    public int SystemTypId { get; set; }

    [Column("exam_cd")]
    [StringLength(1)]
    public string? ExamCd { get; set; }

    [Column("inst_exam_system_desc")]
    [StringLength(30)]
    public string? InstExamSystemDesc { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [ForeignKey("SystemTypId")]
    [InverseProperty("InstExamSystem")]
    public virtual ExamSystem SystemTyp { get; set; } = null!;

    [InverseProperty("InstExamSystem")]
    public virtual ICollection<XrefSiteExam> XrefSiteExam { get; set; } = new List<XrefSiteExam>();
}
