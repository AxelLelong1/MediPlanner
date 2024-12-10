using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("asmt_mthd")]
public partial class AsmtMthd
{
    [Key]
    [Column("asmt_mthd")]
    public int AsmtMthd1 { get; set; }

    [Column("asmt_desc")]
    [StringLength(40)]
    public string AsmtDesc { get; set; } = null!;

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

    [InverseProperty("AsmtMthdNavigation")]
    public virtual ICollection<TrComp> TrComp { get; set; } = new List<TrComp>();
}
