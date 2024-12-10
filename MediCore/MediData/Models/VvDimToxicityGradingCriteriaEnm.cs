using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimToxicityGradingCriteriaEnm
{
    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("tr_typ")]
    [StringLength(30)]
    public string? TrTyp { get; set; }

    [Column("ToxicityTypeENU")]
    [StringLength(100)]
    public string? ToxicityTypeEnu { get; set; }

    [Column("ToxicityTypeFRA")]
    [StringLength(100)]
    public string? ToxicityTypeFra { get; set; }

    [Column("ToxicityTypeESN")]
    [StringLength(100)]
    public string? ToxicityTypeEsn { get; set; }

    [Column("ToxicityTypeCHS")]
    [StringLength(100)]
    public string? ToxicityTypeChs { get; set; }

    [Column("ToxicityTypeDEU")]
    [StringLength(100)]
    public string? ToxicityTypeDeu { get; set; }

    [Column("ToxicityTypeITA")]
    [StringLength(100)]
    public string? ToxicityTypeIta { get; set; }

    [Column("ToxicityTypeJPN")]
    [StringLength(100)]
    public string? ToxicityTypeJpn { get; set; }

    [Column("ToxicityTypePTB")]
    [StringLength(100)]
    public string? ToxicityTypePtb { get; set; }

    [Column("ToxicityTypeSVE")]
    [StringLength(100)]
    public string? ToxicityTypeSve { get; set; }

    [Column("tr_comp_name")]
    [StringLength(30)]
    public string? TrCompName { get; set; }

    [Column("ToxicityComponentNameENU")]
    [StringLength(100)]
    public string? ToxicityComponentNameEnu { get; set; }

    [Column("ToxicityComponentNameFRA")]
    [StringLength(100)]
    public string? ToxicityComponentNameFra { get; set; }

    [Column("ToxicityComponentNameESN")]
    [StringLength(100)]
    public string? ToxicityComponentNameEsn { get; set; }

    [Column("ToxicityComponentNameCHS")]
    [StringLength(100)]
    public string? ToxicityComponentNameChs { get; set; }

    [Column("ToxicityComponentNameDEU")]
    [StringLength(100)]
    public string? ToxicityComponentNameDeu { get; set; }

    [Column("ToxicityComponentNameITA")]
    [StringLength(100)]
    public string? ToxicityComponentNameIta { get; set; }

    [Column("ToxicityComponentNameJPN")]
    [StringLength(100)]
    public string? ToxicityComponentNameJpn { get; set; }

    [Column("ToxicityComponentNamePTB")]
    [StringLength(100)]
    public string? ToxicityComponentNamePtb { get; set; }

    [Column("ToxicityComponentNameSVE")]
    [StringLength(100)]
    public string? ToxicityComponentNameSve { get; set; }

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

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("grading_criteria_id")]
    public int? GradingCriteriaId { get; set; }

    [Column("tr_grading_enter_desc")]
    [StringLength(255)]
    public string? TrGradingEnterDesc { get; set; }

    [Column("GradingDescENU")]
    [StringLength(500)]
    public string? GradingDescEnu { get; set; }

    [Column("GradingDescFRA")]
    [StringLength(500)]
    public string? GradingDescFra { get; set; }

    [Column("GradingDescESN")]
    [StringLength(500)]
    public string? GradingDescEsn { get; set; }

    [Column("GradingDescCHS")]
    [StringLength(500)]
    public string? GradingDescChs { get; set; }

    [Column("GradingDescDEU")]
    [StringLength(500)]
    public string? GradingDescDeu { get; set; }

    [Column("GradingDescITA")]
    [StringLength(500)]
    public string? GradingDescIta { get; set; }

    [Column("GradingDescJPN")]
    [StringLength(500)]
    public string? GradingDescJpn { get; set; }

    [Column("GradingDescPTB")]
    [StringLength(500)]
    public string? GradingDescPtb { get; set; }

    [Column("GradingDescSVE")]
    [StringLength(500)]
    public string? GradingDescSve { get; set; }
}
