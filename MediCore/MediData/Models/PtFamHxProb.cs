using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FamHxProbId")]
[Table("pt_fam_hx_prob")]
public partial class PtFamHxProb
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("fam_hx_prob_id")]
    public int FamHxProbId { get; set; }

    [Column("fam_hx_id")]
    public int FamHxId { get; set; }

    [Column("prob_id")]
    public int? ProbId { get; set; }

    [Column("prob_desc")]
    [StringLength(255)]
    public string? ProbDesc { get; set; }

    [Column("cancer_typ")]
    public int? CancerTyp { get; set; }

    [Column("cause_of_death_ind")]
    [StringLength(1)]
    public string? CauseOfDeathInd { get; set; }

    [Column("prob_cmt")]
    [StringLength(255)]
    public string? ProbCmt { get; set; }

    [Column("dx_age")]
    public int? DxAge { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("duration")]
    public int? Duration { get; set; }

    [Column("time_unit")]
    public int? TimeUnit { get; set; }

    [Column("resolution_typ")]
    public int? ResolutionTyp { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("dx_cd")]
    [StringLength(20)]
    public string? DxCd { get; set; }
}
