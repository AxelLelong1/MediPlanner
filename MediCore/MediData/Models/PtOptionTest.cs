using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtOptionId", "PtResultId")]
[Table("pt_option_test")]
public partial class PtOptionTest
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_option_id")]
    public int PtOptionId { get; set; }

    [Key]
    [Column("pt_result_id")]
    public int PtResultId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("test_id")]
    public int? TestId { get; set; }

    [Column("test_result_group_id")]
    public int? TestResultGroupId { get; set; }

    [Column("test_result_id")]
    public int? TestResultId { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("next_inf_ind")]
    [StringLength(1)]
    public string? NextInfInd { get; set; }

    [Column("result_typ_expect")]
    [StringLength(1)]
    public string? ResultTypExpect { get; set; }

    [Column("result_typ_actual")]
    [StringLength(1)]
    public string? ResultTypActual { get; set; }

    [Column("was_inf_ind")]
    [StringLength(1)]
    public string? WasInfInd { get; set; }

    [Column("result_present_ind")]
    [StringLength(1)]
    public string? ResultPresentInd { get; set; }

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
}
