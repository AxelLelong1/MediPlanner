using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("resolution_typ")]
public partial class ResolutionTyp
{
    [Key]
    [Column("resolution_typ")]
    public int ResolutionTyp1 { get; set; }

    [Column("resolution_desc")]
    [StringLength(40)]
    public string ResolutionDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("ResolutionTypNavigation")]
    public virtual ICollection<PtDx> PtDx { get; set; } = new List<PtDx>();

    [InverseProperty("ResolutionTypNavigation")]
    public virtual ICollection<PtDxExternal> PtDxExternal { get; set; } = new List<PtDxExternal>();
}
