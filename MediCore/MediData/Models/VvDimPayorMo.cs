using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPayorMo
{
    [StringLength(50)]
    public string? PayorCompanyName { get; set; }

    [StringLength(172)]
    public string? PayorAddress { get; set; }

    [StringLength(28)]
    public string? PayorPhone { get; set; }

    [StringLength(50)]
    public string? InsuranceCompanyParentOrganization { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctrins_co_id")]
    public int CtrinsCoId { get; set; }

    [Column("ctrins_co_parent_id")]
    public int? CtrinsCoParentId { get; set; }

    [Column("MOROIndicator")]
    [StringLength(2)]
    public string Moroindicator { get; set; } = null!;

    [Column("ctrPayorAuthorizationSer")]
    public int CtrPayorAuthorizationSer { get; set; }
}
