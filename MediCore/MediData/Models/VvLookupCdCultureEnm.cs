using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvLookupCdCultureEnm
{
    [StringLength(30)]
    public string? TableName { get; set; }

    [StringLength(64)]
    public string? LookupCode { get; set; }

    public int? LookupType { get; set; }

    public long? SubSelector { get; set; }

    [Column("LookupDescriptionENU")]
    [StringLength(255)]
    public string? LookupDescriptionEnu { get; set; }

    [Column("LookupDescriptionFRA")]
    [StringLength(255)]
    public string? LookupDescriptionFra { get; set; }

    [Column("LookupDescriptionESN")]
    [StringLength(255)]
    public string? LookupDescriptionEsn { get; set; }

    [Column("LookupDescriptionCHS")]
    [StringLength(255)]
    public string? LookupDescriptionChs { get; set; }

    [Column("LookupDescriptionDEU")]
    [StringLength(255)]
    public string? LookupDescriptionDeu { get; set; }

    [Column("LookupDescriptionITA")]
    [StringLength(255)]
    public string? LookupDescriptionIta { get; set; }

    [Column("LookupDescriptionJPN")]
    [StringLength(255)]
    public string? LookupDescriptionJpn { get; set; }

    [Column("LookupDescriptionPTB")]
    [StringLength(255)]
    public string? LookupDescriptionPtb { get; set; }

    [Column("LookupDescriptionSVE")]
    [StringLength(255)]
    public string? LookupDescriptionSve { get; set; }
}
