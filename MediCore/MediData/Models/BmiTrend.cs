using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bmi_trend")]
public partial class BmiTrend
{
    [Key]
    [Column("bmi_trend_id")]
    public int BmiTrendId { get; set; }

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [Column("age_months")]
    public double? AgeMonths { get; set; }

    public double? P3 { get; set; }

    public double? P5 { get; set; }

    public double? P10 { get; set; }

    public double? P25 { get; set; }

    public double? P50 { get; set; }

    public double? P75 { get; set; }

    public double? P85 { get; set; }

    public double? P90 { get; set; }

    public double? P95 { get; set; }

    public double? P97 { get; set; }

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

    [ForeignKey("BaseTyp")]
    [InverseProperty("BmiTrend")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;

    [ForeignKey("ClsSchemeId")]
    [InverseProperty("BmiTrend")]
    public virtual ClsScheme ClsScheme { get; set; } = null!;
}
