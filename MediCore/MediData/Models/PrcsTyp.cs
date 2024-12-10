using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prcs_typ")]
public partial class PrcsTyp
{
    [Key]
    [Column("prcs_typ")]
    public int PrcsTyp1 { get; set; }

    [Column("prcs_desc")]
    [StringLength(50)]
    public string PrcsDesc { get; set; } = null!;

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

    [InverseProperty("PrcsTypNavigation")]
    public virtual ICollection<Phase> Phase { get; set; } = new List<Phase>();

    [InverseProperty("PrcsTypNavigation")]
    public virtual ICollection<PtTpPhase> PtTpPhase { get; set; } = new List<PtTpPhase>();
}
