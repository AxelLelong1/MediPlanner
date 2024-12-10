using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExamCompId", "ExamAsmtAttrId", "InstId", "Userid")]
[Table("exam_asmt_attr")]
[Index("InstId", "Userid", "ExamCompId", Name = "nc2_exam_asmt_attr")]
public partial class ExamAsmtAttr
{
    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Key]
    [Column("exam_asmt_attr_id")]
    public int ExamAsmtAttrId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("exam_comp_attr")]
    [StringLength(40)]
    public string? ExamCompAttr { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("asmt_value_typ")]
    [StringLength(10)]
    public string? AsmtValueTyp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("desc_phrase")]
    [StringLength(100)]
    public string? DescPhrase { get; set; }

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

    [InverseProperty("ExamAsmtAttr")]
    public virtual ICollection<ExamAsmt> ExamAsmt { get; set; } = new List<ExamAsmt>();

    [ForeignKey("InstId, Userid, ExamCompId")]
    [InverseProperty("ExamAsmtAttr")]
    public virtual UserExamComp UserExamComp { get; set; } = null!;
}
