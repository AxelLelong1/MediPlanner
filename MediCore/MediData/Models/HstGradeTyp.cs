using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hst_grade_typ")]
public partial class HstGradeTyp
{
    [Key]
    [Column("hst_grade_typ")]
    public int HstGradeTyp1 { get; set; }

    [Column("hst_grade_desc")]
    [StringLength(10)]
    public string? HstGradeDesc { get; set; }

    [Column("diff_desc")]
    [StringLength(40)]
    public string? DiffDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
