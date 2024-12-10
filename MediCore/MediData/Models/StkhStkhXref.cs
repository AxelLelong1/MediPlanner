using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stkh_stkh_xref")]
[Index("FromStkhId", "FromRoleTyp", Name = "nc1_stkh_stkh_xref")]
[Index("ToStkhId", "ToRoleTyp", Name = "nc2_stkh_stkh_xref")]
public partial class StkhStkhXref
{
    [Key]
    [Column("stkh_stkh_id")]
    [StringLength(14)]
    public string StkhStkhId { get; set; } = null!;

    [Column("role_reltn_typ")]
    public int RoleReltnTyp { get; set; }

    [Column("from_stkh_id")]
    [StringLength(20)]
    public string FromStkhId { get; set; } = null!;

    [Column("from_role_typ")]
    public int FromRoleTyp { get; set; }

    [Column("to_stkh_id")]
    [StringLength(20)]
    public string ToStkhId { get; set; } = null!;

    [Column("to_role_typ")]
    public int ToRoleTyp { get; set; }

    [Column("pref_corsp_mthd_cd")]
    [StringLength(1)]
    public string? PrefCorspMthdCd { get; set; }

    [Column("pref_mail_ind")]
    [StringLength(1)]
    public string PrefMailInd { get; set; } = null!;

    [Column("pref_fax_ind")]
    [StringLength(1)]
    public string PrefFaxInd { get; set; } = null!;

    [Column("pref_email_ind")]
    [StringLength(1)]
    public string PrefEmailInd { get; set; } = null!;

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

    [Column("loc_desc")]
    [StringLength(40)]
    public string? LocDesc { get; set; }

    [ForeignKey("FromStkhId")]
    [InverseProperty("StkhStkhXrefFromStkh")]
    public virtual Stkh FromStkh { get; set; } = null!;

    [ForeignKey("RoleReltnTyp")]
    [InverseProperty("StkhStkhXref")]
    public virtual StkhRoleReltn RoleReltnTypNavigation { get; set; } = null!;

    [ForeignKey("ToStkhId")]
    [InverseProperty("StkhStkhXrefToStkh")]
    public virtual Stkh ToStkh { get; set; } = null!;
}
