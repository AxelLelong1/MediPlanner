using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TypOfTest", "CompName", "ResultUseTyp")]
[Table("mr_test_result")]
[Index("CompName", Name = "nc1_mr_test_result")]
public partial class MrTestResult
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Key]
    [Column("result_use_typ")]
    public int ResultUseTyp { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("test_id")]
    public int? TestId { get; set; }

    [Column("test_result_group_id")]
    public int? TestResultGroupId { get; set; }

    [Column("test_result_id")]
    public int? TestResultId { get; set; }

    [Column("mr_tstamp", TypeName = "datetime")]
    public DateTime? MrTstamp { get; set; }

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

    [Column("threshold_ind")]
    [StringLength(1)]
    public string? ThresholdInd { get; set; }

    [ForeignKey("ResultUseTyp")]
    [InverseProperty("MrTestResult")]
    public virtual ResultUseTyp ResultUseTypNavigation { get; set; } = null!;
}
