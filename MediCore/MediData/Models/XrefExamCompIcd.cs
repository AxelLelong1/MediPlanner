using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExamCompId", "InstId", "ClsSchemeId", "IcdCd")]
[Table("xref_exam_comp_icd")]
public partial class XrefExamCompIcd
{
    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Column("primary_cd_ind")]
    [StringLength(1)]
    public string? PrimaryCdInd { get; set; }

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

    [ForeignKey("ExamCompId")]
    [InverseProperty("XrefExamCompIcd")]
    public virtual ExamComp ExamComp { get; set; } = null!;
}
