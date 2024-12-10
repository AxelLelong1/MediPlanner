using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("behavior_cd")]
public partial class BehaviorCd
{
    [Key]
    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd1 { get; set; } = null!;

    [Column("behavior_desc")]
    [StringLength(50)]
    public string BehaviorDesc { get; set; } = null!;

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

    [InverseProperty("BehaviorCdNavigation")]
    public virtual ICollection<IcdoMorphCd> IcdoMorphCd { get; set; } = new List<IcdoMorphCd>();
}
