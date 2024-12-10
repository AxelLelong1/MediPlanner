using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "HpiId")]
[Table("pt_hpi")]
public partial class PtHpi
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("hpi_id")]
    public int HpiId { get; set; }

    [Column("hpi_datetime", TypeName = "datetime")]
    public DateTime? HpiDatetime { get; set; }

    [Column("prov_userid")]
    [StringLength(255)]
    public string? ProvUserid { get; set; }

    [Column("prov_inst_id")]
    [StringLength(30)]
    public string? ProvInstId { get; set; }

    [Column("hpi_assessed_count")]
    public int? HpiAssessedCount { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("chief_complaint")]
    public string? ChiefComplaint { get; set; }

    [Column("loc_txt")]
    public string? LocTxt { get; set; }

    [Column("quality_txt")]
    public string? QualityTxt { get; set; }

    [Column("severity_txt")]
    public string? SeverityTxt { get; set; }

    [Column("timing_txt")]
    public string? TimingTxt { get; set; }

    [Column("duration_txt")]
    public string? DurationTxt { get; set; }

    [Column("context_txt")]
    public string? ContextTxt { get; set; }

    [Column("modifying_factors_txt")]
    public string? ModifyingFactorsTxt { get; set; }

    [Column("assoc_signs_txt")]
    public string? AssocSignsTxt { get; set; }

    [Column("hpi_txt")]
    public string? HpiTxt { get; set; }

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

    [Column("detail_ind")]
    [StringLength(1)]
    public string? DetailInd { get; set; }
}
