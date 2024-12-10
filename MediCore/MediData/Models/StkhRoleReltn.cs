using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stkh_role_reltn")]
public partial class StkhRoleReltn
{
    [Key]
    [Column("role_reltn_typ")]
    public int RoleReltnTyp { get; set; }

    [Column("from_role_typ")]
    public int FromRoleTyp { get; set; }

    [Column("from_stkh_cd")]
    [StringLength(1)]
    public string FromStkhCd { get; set; } = null!;

    [Column("to_role_typ")]
    public int ToRoleTyp { get; set; }

    [Column("to_stkh_cd")]
    [StringLength(1)]
    public string ToStkhCd { get; set; } = null!;

    [Column("role_reltn_desc")]
    [StringLength(255)]
    public string RoleReltnDesc { get; set; } = null!;

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

    [ForeignKey("FromRoleTyp")]
    [InverseProperty("StkhRoleReltnFromRoleTypNavigation")]
    public virtual StkhRoleTyp FromRoleTypNavigation { get; set; } = null!;

    [InverseProperty("RoleReltnTypNavigation")]
    public virtual ICollection<StkhStkhXref> StkhStkhXref { get; set; } = new List<StkhStkhXref>();

    [ForeignKey("ToRoleTyp")]
    [InverseProperty("StkhRoleReltnToRoleTypNavigation")]
    public virtual StkhRoleTyp ToRoleTypNavigation { get; set; } = null!;
}
