using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stkh_key_cd")]
public partial class StkhKeyCd
{
    [Key]
    [Column("stkh_key_cd")]
    public int StkhKeyCd1 { get; set; }

    [Column("role_typ")]
    public int RoleTyp { get; set; }

    [Column("key_scope_typ")]
    public int KeyScopeTyp { get; set; }

    [Column("key_label")]
    [StringLength(40)]
    public string KeyLabel { get; set; } = null!;

    [Column("key_desc")]
    [StringLength(255)]
    public string? KeyDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("KeyScopeTyp")]
    [InverseProperty("StkhKeyCd")]
    public virtual PtKeyScopeTyp KeyScopeTypNavigation { get; set; } = null!;

    [ForeignKey("RoleTyp")]
    [InverseProperty("StkhKeyCd")]
    public virtual StkhRoleTyp RoleTypNavigation { get; set; } = null!;

    [InverseProperty("StkhKeyCdNavigation")]
    public virtual ICollection<StkhInstKeyCd> StkhInstKeyCd { get; set; } = new List<StkhInstKeyCd>();

    [InverseProperty("StkhKeyCdNavigation")]
    public virtual ICollection<StkhKey> StkhKey { get; set; } = new List<StkhKey>();
}
