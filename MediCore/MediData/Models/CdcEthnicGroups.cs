using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class CdcEthnicGroups
{
    [Column("intf_map_cd")]
    [StringLength(10)]
    public string? IntfMapCd { get; set; }

    [Column("ethnic_group_desc")]
    [StringLength(64)]
    public string EthnicGroupDesc { get; set; } = null!;

    [Column("cdc_cd")]
    [StringLength(6)]
    public string? CdcCd { get; set; }

    [Column("ethnic_group_id")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EthnicGroupId { get; set; }

    [Column("user_defined_ind")]
    [StringLength(1)]
    [Unicode(false)]
    public string UserDefinedInd { get; set; } = null!;
}
