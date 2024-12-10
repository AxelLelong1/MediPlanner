using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtAsmtId", "AsmtCompName")]
[Table("pt_asmt_result")]
public partial class PtAsmtResult
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_asmt_id")]
    public int PtAsmtId { get; set; }

    [Key]
    [Column("asmt_comp_name")]
    [StringLength(30)]
    public string AsmtCompName { get; set; } = null!;

    [Column("asmt_group_name")]
    [StringLength(30)]
    public string? AsmtGroupName { get; set; }

    [Column("result_meas_typ")]
    public int ResultMeasTyp { get; set; }

    [Column("asmt_value", TypeName = "decimal(11, 4)")]
    public decimal? AsmtValue { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("uom_desc")]
    [StringLength(40)]
    public string? UomDesc { get; set; }

    [Column("min_norm", TypeName = "decimal(11, 4)")]
    public decimal? MinNorm { get; set; }

    [Column("max_norm", TypeName = "decimal(11, 4)")]
    public decimal? MaxNorm { get; set; }

    [Column("asmt_grade_no")]
    public int? AsmtGradeNo { get; set; }

    [Column("grade_desc")]
    [StringLength(100)]
    public string? GradeDesc { get; set; }

    [Column("asmt_status")]
    [StringLength(1)]
    public string? AsmtStatus { get; set; }

    [Column("status_desc")]
    [StringLength(40)]
    public string? StatusDesc { get; set; }

    [Column("asmt_cmt_txt")]
    public string? AsmtCmtTxt { get; set; }

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

    [Column("asmt_comp_seq")]
    public int? AsmtCompSeq { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
