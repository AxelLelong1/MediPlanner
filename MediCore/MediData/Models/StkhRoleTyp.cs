using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stkh_role_typ")]
public partial class StkhRoleTyp
{
    [Key]
    [Column("role_typ")]
    public int RoleTyp { get; set; }

    [Column("role_desc")]
    [StringLength(40)]
    public string RoleDesc { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

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

    [InverseProperty("StkhRoleTypNavigation")]
    public virtual ICollection<IntfStkhKeyMapRole> IntfStkhKeyMapRole { get; set; } = new List<IntfStkhKeyMapRole>();

    [InverseProperty("RoleTypNavigation")]
    public virtual ICollection<StkhKeyCd> StkhKeyCd { get; set; } = new List<StkhKeyCd>();

    [InverseProperty("RoleTypNavigation")]
    public virtual ICollection<StkhRole> StkhRole { get; set; } = new List<StkhRole>();

    [InverseProperty("FromRoleTypNavigation")]
    public virtual ICollection<StkhRoleReltn> StkhRoleReltnFromRoleTypNavigation { get; set; } = new List<StkhRoleReltn>();

    [InverseProperty("ToRoleTypNavigation")]
    public virtual ICollection<StkhRoleReltn> StkhRoleReltnToRoleTypNavigation { get; set; } = new List<StkhRoleReltn>();
}
