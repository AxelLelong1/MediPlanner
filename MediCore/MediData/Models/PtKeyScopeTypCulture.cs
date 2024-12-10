using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class PtKeyScopeTypCulture
{
    [Column("lookup_typ")]
    public int LookupTyp { get; set; }

    [Column("scope_typ_desc")]
    [StringLength(60)]
    public string? ScopeTypDesc { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;
}
