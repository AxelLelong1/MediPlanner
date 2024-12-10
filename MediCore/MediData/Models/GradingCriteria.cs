using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GsAuthor", "EffDate", "TrTyp", "TrCompName", "TrGrade")]
[Table("grading_criteria")]
[Index("ClsSchemeId", Name = "nc1_grading_criteria")]
public partial class GradingCriteria
{
    [Key]
    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Key]
    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

    [Key]
    [Column("tr_grade")]
    public int TrGrade { get; set; }

    [Column("tr_min_range", TypeName = "numeric(11, 4)")]
    public decimal? TrMinRange { get; set; }

    [Column("tr_max_range", TypeName = "numeric(11, 4)")]
    public decimal? TrMaxRange { get; set; }

    [Column("upper_margin", TypeName = "numeric(11, 4)")]
    public decimal? UpperMargin { get; set; }

    [Column("lower_margin", TypeName = "numeric(11, 4)")]
    public decimal? LowerMargin { get; set; }

    [Column("trend", TypeName = "numeric(11, 4)")]
    public decimal? Trend { get; set; }

    [Column("tr_grading_desc")]
    [StringLength(255)]
    public string? TrGradingDesc { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string? ApprFlag { get; set; }

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

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("grading_criteria_id")]
    public int? GradingCriteriaId { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("tr_grading_enter_desc")]
    [StringLength(255)]
    public string? TrGradingEnterDesc { get; set; }

    [ForeignKey("GsAuthor, EffDate, TrTyp, TrCompName")]
    [InverseProperty("GradingCriteria")]
    public virtual TrComp TrComp { get; set; } = null!;
}
