using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExamCompId", "ExamAsmtAttrId", "ExamAsmtId", "InstId", "Userid")]
[Table("exam_asmt")]
[Index("InstId", "Userid", "ExamCompId", Name = "nc2_exam_asmt")]
public partial class ExamAsmt
{
    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Key]
    [Column("exam_asmt_attr_id")]
    public int ExamAsmtAttrId { get; set; }

    [Key]
    [Column("exam_asmt_id")]
    public int ExamAsmtId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("exam_asmt_cd")]
    [StringLength(1)]
    public string ExamAsmtCd { get; set; } = null!;

    [Column("exam_asmt_desc")]
    [StringLength(200)]
    public string ExamAsmtDesc { get; set; } = null!;

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

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [ForeignKey("ExamCompId, ExamAsmtAttrId, InstId, Userid")]
    [InverseProperty("ExamAsmt")]
    public virtual ExamAsmtAttr ExamAsmtAttr { get; set; } = null!;
}
