using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "StkhRoleId")]
[Table("stkh_role")]
[Index("RoleTyp", Name = "nc1_stkh_role")]
public partial class StkhRole
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("stkh_role_id")]
    public int StkhRoleId { get; set; }

    [Column("role_typ")]
    public int RoleTyp { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("end_reason_cd")]
    [StringLength(3)]
    public string? EndReasonCd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [Column("stkh_cd")]
    [StringLength(1)]
    public string? StkhCd { get; set; }

    [Column("inactive_reason_txt")]
    [StringLength(255)]
    public string? InactiveReasonTxt { get; set; }

    [ForeignKey("RoleTyp")]
    [InverseProperty("StkhRole")]
    public virtual StkhRoleTyp RoleTypNavigation { get; set; } = null!;

    [ForeignKey("StkhId")]
    [InverseProperty("StkhRole")]
    public virtual Stkh Stkh { get; set; } = null!;
}
