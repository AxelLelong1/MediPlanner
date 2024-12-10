using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDerivedImageCode
{
    public long DerivedImageCodeSer { get; set; }

    public long SliceSer { get; set; }

    [StringLength(16)]
    public string Value { get; set; } = null!;

    [StringLength(16)]
    public string Designator { get; set; } = null!;

    [StringLength(16)]
    public string? Version { get; set; }

    [StringLength(64)]
    public string? Meaning { get; set; }

    [StringLength(64)]
    public string? Registry { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string? Uid { get; set; }

    [Column("ExternalID")]
    public string? ExternalId { get; set; }

    public string? CommonName { get; set; }

    public string? ResponsibleOrganization { get; set; }
}
