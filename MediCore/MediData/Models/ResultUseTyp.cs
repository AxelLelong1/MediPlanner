using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("result_use_typ")]
public partial class ResultUseTyp
{
    [Key]
    [Column("result_use_typ")]
    public int ResultUseTyp1 { get; set; }

    [Column("result_use_desc")]
    [StringLength(40)]
    public string ResultUseDesc { get; set; } = null!;

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

    [InverseProperty("ResultUseTypNavigation")]
    public virtual ICollection<MrTestResult> MrTestResult { get; set; } = new List<MrTestResult>();

    [InverseProperty("ResultUseTypNavigation")]
    public virtual ICollection<MrTrAsmt> MrTrAsmt { get; set; } = new List<MrTrAsmt>();
}
