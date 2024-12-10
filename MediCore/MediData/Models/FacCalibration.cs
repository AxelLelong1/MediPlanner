using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacCompId", "EffDate", "Sex", "AgeStart")]
[Table("fac_calibration")]
public partial class FacCalibration
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_comp_id")]
    public int FacCompId { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("sex")]
    [StringLength(1)]
    public string Sex { get; set; } = null!;

    [Key]
    [Column("age_start")]
    public int AgeStart { get; set; }

    [Column("age_end")]
    public int? AgeEnd { get; set; }

    [Column("min_norm", TypeName = "numeric(11, 4)")]
    public decimal? MinNorm { get; set; }

    [Column("max_norm", TypeName = "numeric(11, 4)")]
    public decimal? MaxNorm { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("lead_time")]
    public int? LeadTime { get; set; }

    [Column("lead_time_unit")]
    public int? LeadTimeUnit { get; set; }

    [Column("min_reason", TypeName = "numeric(11, 4)")]
    public decimal? MinReason { get; set; }

    [Column("max_reason", TypeName = "numeric(11, 4)")]
    public decimal? MaxReason { get; set; }

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

    [Column("min_abs", TypeName = "numeric(11, 4)")]
    public decimal? MinAbs { get; set; }

    [Column("max_abs", TypeName = "numeric(11, 4)")]
    public decimal? MaxAbs { get; set; }

    [ForeignKey("InstId, FacId, FacCompId")]
    [InverseProperty("FacCalibration")]
    public virtual FacComp FacComp { get; set; } = null!;
}
