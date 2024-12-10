using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("status_typ")]
public partial class StatusTyp
{
    [Key]
    [Column("status_typ")]
    public int StatusTyp1 { get; set; }

    [Column("true_desc")]
    [StringLength(40)]
    public string TrueDesc { get; set; } = null!;

    [Column("false_desc")]
    [StringLength(40)]
    public string FalseDesc { get; set; } = null!;

    [Column("null_desc")]
    [StringLength(40)]
    public string NullDesc { get; set; } = null!;

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

    [InverseProperty("StatusTypNavigation")]
    public virtual ICollection<AsmtComp> AsmtComp { get; set; } = new List<AsmtComp>();

    [InverseProperty("StatusTypNavigation")]
    public virtual ICollection<TestComp> TestComp { get; set; } = new List<TestComp>();
}
