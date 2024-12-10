using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AsmtCompName", "GradeNo")]
[Table("asmt_comp_grade")]
public partial class AsmtCompGrade
{
    [Key]
    [Column("asmt_comp_name")]
    [StringLength(30)]
    public string AsmtCompName { get; set; } = null!;

    [Key]
    [Column("grade_no")]
    public int GradeNo { get; set; }

    [Column("grade_desc")]
    [StringLength(100)]
    public string GradeDesc { get; set; } = null!;

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

    [ForeignKey("AsmtCompName")]
    [InverseProperty("AsmtCompGrade")]
    public virtual AsmtComp AsmtCompNameNavigation { get; set; } = null!;
}
