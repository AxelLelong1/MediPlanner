using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid", "ExamCompId")]
[Table("user_exam_comp")]
public partial class UserExamComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Column("exam_cd")]
    [StringLength(1)]
    public string? ExamCd { get; set; }

    [Column("system_typ_id")]
    public int SystemTypId { get; set; }

    [Column("user_exam_comp_desc")]
    [StringLength(40)]
    public string UserExamCompDesc { get; set; } = null!;

    [Column("neg_desc")]
    [StringLength(100)]
    public string? NegDesc { get; set; }

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

    [Column("normal_asmt_level")]
    public int? NormalAsmtLevel { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [InverseProperty("UserExamComp")]
    public virtual ICollection<ExamAsmtAttr> ExamAsmtAttr { get; set; } = new List<ExamAsmtAttr>();

    [ForeignKey("ExamCompId")]
    [InverseProperty("UserExamComp")]
    public virtual ExamComp ExamComp { get; set; } = null!;
}
