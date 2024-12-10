using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtProviderId")]
[Table("pt_provider")]
[Index("ProviderStkhId", "ProviderRoleTyp", Name = "nc1_pt_provider")]
[Index("OrgStkhId", "OrgRoleTyp", Name = "nc2_pt_provider")]
public partial class PtProvider
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_provider_id")]
    public int PtProviderId { get; set; }

    [Column("provider_stkh_id")]
    [StringLength(20)]
    public string? ProviderStkhId { get; set; }

    [Column("provider_role_typ")]
    public int? ProviderRoleTyp { get; set; }

    [Column("org_stkh_id")]
    [StringLength(20)]
    public string? OrgStkhId { get; set; }

    [Column("org_role_typ")]
    public int? OrgRoleTyp { get; set; }

    [Column("prof_reltn_typ")]
    public int? ProfReltnTyp { get; set; }

    [Column("ref_cd")]
    [StringLength(1)]
    public string RefCd { get; set; } = null!;

    [Column("internal_ind")]
    [StringLength(1)]
    public string InternalInd { get; set; } = null!;

    [Column("ref_date", TypeName = "datetime")]
    public DateTime? RefDate { get; set; }

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

    [Column("send_corsp_ind")]
    [StringLength(1)]
    public string? SendCorspInd { get; set; }

    [Column("ref_note")]
    [StringLength(255)]
    public string? RefNote { get; set; }

    [Column("ref_internal_stkh_id")]
    [StringLength(20)]
    public string? RefInternalStkhId { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [ForeignKey("OrgStkhId")]
    [InverseProperty("PtProviderOrgStkh")]
    public virtual Stkh? OrgStkh { get; set; }

    [ForeignKey("ProviderStkhId")]
    [InverseProperty("PtProviderProviderStkh")]
    public virtual Stkh? ProviderStkh { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtProvider")]
    public virtual Pt Pt { get; set; } = null!;
}
