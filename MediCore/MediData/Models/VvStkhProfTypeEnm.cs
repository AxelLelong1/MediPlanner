using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvStkhProfTypeEnm
{
    [StringLength(64)]
    public string? TableName { get; set; }

    [StringLength(64)]
    public string? LookupCode { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LookupType { get; set; }

    public long? SubSelector { get; set; }

    [Column("LookupDescriptionENU")]
    [StringLength(256)]
    public string? LookupDescriptionEnu { get; set; }

    [Column("LookupDescriptionFRA")]
    [StringLength(256)]
    public string? LookupDescriptionFra { get; set; }

    [Column("LookupDescriptionESN")]
    [StringLength(256)]
    public string? LookupDescriptionEsn { get; set; }

    [Column("LookupDescriptionCHS")]
    [StringLength(256)]
    public string? LookupDescriptionChs { get; set; }

    [Column("LookupDescriptionDEU")]
    [StringLength(256)]
    public string? LookupDescriptionDeu { get; set; }

    [Column("LookupDescriptionITA")]
    [StringLength(256)]
    public string? LookupDescriptionIta { get; set; }

    [Column("LookupDescriptionJPN")]
    [StringLength(256)]
    public string? LookupDescriptionJpn { get; set; }

    [Column("LookupDescriptionPTB")]
    [StringLength(256)]
    public string? LookupDescriptionPtb { get; set; }

    [Column("LookupDescriptionSVE")]
    [StringLength(256)]
    public string? LookupDescriptionSve { get; set; }
}
