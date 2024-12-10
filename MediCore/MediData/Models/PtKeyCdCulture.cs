using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class PtKeyCdCulture
{
    [Column("lookup_typ")]
    public int LookupTyp { get; set; }

    [Column("pt_key_desc")]
    [StringLength(80)]
    public string? PtKeyDesc { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;
}
