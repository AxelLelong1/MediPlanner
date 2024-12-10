using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_key_scope_typ")]
public partial class PtKeyScopeTyp
{
    [Key]
    [Column("pt_key_scope_typ")]
    public int PtKeyScopeTyp1 { get; set; }

    [Column("scope_typ_desc")]
    [StringLength(30)]
    public string ScopeTypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("PtKeyScopeTypNavigation")]
    public virtual ICollection<PtKeyCd> PtKeyCd { get; set; } = new List<PtKeyCd>();

    [InverseProperty("KeyScopeTypNavigation")]
    public virtual ICollection<StkhKeyCd> StkhKeyCd { get; set; } = new List<StkhKeyCd>();
}
