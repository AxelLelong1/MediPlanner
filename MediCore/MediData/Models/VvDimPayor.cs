using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPayor
{
    [StringLength(64)]
    public string PayorCompanyName { get; set; } = null!;

    [StringLength(64)]
    public string? PayorPhone { get; set; }

    [StringLength(348)]
    public string? PayorAddress { get; set; }

    [StringLength(32)]
    public string? PayorPlanType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayorPlanExpiraryDate { get; set; }

    [StringLength(16)]
    public string PayorPlanNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [StringLength(64)]
    public string? AuthorizedBy { get; set; }

    [StringLength(64)]
    public string? AuthorizationPhone { get; set; }

    [Column("AuthorizationFAX")]
    [StringLength(64)]
    public string? AuthorizationFax { get; set; }

    [Column("ctrPayorSer")]
    public long CtrPayorSer { get; set; }

    [Column("ctrPlanTypeSer")]
    public long? CtrPlanTypeSer { get; set; }

    [Column("ctrPayorAuthorizationSer")]
    public long CtrPayorAuthorizationSer { get; set; }

    [Column("MOROIndicator")]
    [StringLength(2)]
    public string Moroindicator { get; set; } = null!;
}
