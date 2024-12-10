using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExamCompId", "CultureCd")]
[Table("exam_comp_culture")]
public partial class ExamCompCulture
{
    [Key]
    [Column("exam_comp_id")]
    public int ExamCompId { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("exam_cd")]
    [StringLength(1)]
    public string ExamCd { get; set; } = null!;

    [Column("system_typ_id")]
    public int SystemTypId { get; set; }

    [Column("lookup_desc")]
    [StringLength(40)]
    public string? LookupDesc { get; set; }

    [Column("lookup_desc_neg")]
    [StringLength(100)]
    public string? LookupDescNeg { get; set; }

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
