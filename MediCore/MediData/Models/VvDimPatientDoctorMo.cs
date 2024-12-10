using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientDoctorMo
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_provider_id")]
    public int CtrptProviderId { get; set; }

    [Column("ctrprovider_stkh_id")]
    [StringLength(20)]
    public string? CtrproviderStkhId { get; set; }

    public int? ProviderRoleType { get; set; }

    [Column("ctrorg_stkh_id")]
    [StringLength(20)]
    public string? CtrorgStkhId { get; set; }

    [Column("org_role_typ")]
    public int? OrgRoleTyp { get; set; }

    public int? ProfRelationType { get; set; }

    [StringLength(40)]
    public string? ProfRelationTypeDesc { get; set; }

    [StringLength(1)]
    public string ReferralCode { get; set; } = null!;

    [StringLength(1)]
    public string InternalIndicator { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ReferralDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveEndDate { get; set; }

    [StringLength(3)]
    public string? EndReasonCode { get; set; }

    [StringLength(1)]
    public string ActiveEntryIndicator { get; set; } = null!;

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }
}
