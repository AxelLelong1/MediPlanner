using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimConstantResource
{
    [StringLength(16)]
    public string ResourceId { get; set; } = null!;

    [StringLength(64)]
    public string? ResourceFullName { get; set; }

    [StringLength(16)]
    public string ResourceAliasName { get; set; } = null!;

    [StringLength(30)]
    public string ResourceType { get; set; } = null!;

    public int ResourceTypeNum { get; set; }

    [StringLength(16)]
    public string ResourceObjectStatus { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Schedulable { get; set; }

    [StringLength(4000)]
    public string? ResourceCompleteAddress { get; set; }

    public int? IsPrimaryResourceAddress { get; set; }

    [StringLength(64)]
    public string? ResourceAddressType { get; set; }

    [StringLength(254)]
    public string? ResourceAddressComment { get; set; }

    [StringLength(64)]
    public string? ResourcePrimaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? ResourceSecondaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? ResourcePagerNumber { get; set; }

    [StringLength(64)]
    public string? ResourceFaxNumber { get; set; }

    [Column("ResourceEMailAddress")]
    [StringLength(64)]
    public string? ResourceEmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResourceOriginationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResourceTerminationDate { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }
}
